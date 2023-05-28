using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SubsTracker.Core;
using SubsTracker.UI.Components;

namespace SubsTracker.UI
{
    public partial class DashboardForm : Form
    {
        private static User currentUser;
        private static bool closeApp;
        private static Guid _subId = Guid.Empty;
        private static readonly DataManager dm = new DataManager();

        private static readonly Dictionary<string, string> iconsDict = new Dictionary<string, string>(){
                { "substracker", "SubsTracker" },
                { "netflix", "Netflix" },
                { "hbomax", "HBO Max" },
                { "spotify", "Spotify" },
                { "youtube", "YouTube" },
                { "twitch", "Twitch" }
        };

        private static readonly string[] _iconsStr = { "SubsTracker", "Netflix", "HBO Max", "Spotify", "YouTube", "Twitch" };
        private static readonly string[] _typeStr = { "Monthly", "Yearly" };
        private static readonly string[] _monthStr = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public DashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            closeApp = true;
        }

        private void ResetForm()
        {
            currentUser = dm.GetUsers().Find(u => u.Id == currentUser.Id);
            //Reset subscriptions page
            _subId = Guid.Empty;
            //nameInput.Text = null;
            if (nameInput.InvokeRequired)
            {
                nameInput.Invoke(new Action(() => nameInput.Text = ""));
            }
            else
            {
                nameInput.Text = "";
            }
            iconInput.SelectedItem = "";
            amountInput.Value = 5;
            //currencyInput.Text = null;
            if (currencyInput.InvokeRequired)
            {
                currencyInput.Invoke(new Action(() => currencyInput.Text = ""));
            }
            else
            {
                currencyInput.Text = "";
            }
            typeInput.SelectedItem = "";
            dayInput.Value = 1;
            monthInput.SelectedItem = "";

            //subscriptionPanel.Controls.Clear();
            if (subscriptionPanel.InvokeRequired)
            {
                subscriptionPanel.Invoke(new Action(() => subscriptionPanel.Controls.Clear()));
            }
            else
            {
                subscriptionPanel.Controls.Clear();
            }

            List<Subscription> subscriptions = dm.GetSubscriptions();

            subscriptions = subscriptions.FindAll(s => s.UserId == currentUser.Id);

            if (!IsEmpty(subscriptions))
            {
                //noSubscriptionLabel.Visible = false;
                if (noSubscriptionLabel.InvokeRequired)
                {
                    noSubscriptionLabel.Invoke(new Action(() => noSubscriptionLabel.Visible = false));
                }
                else
                {
                    noSubscriptionLabel.Visible = false;
                }
                foreach (Subscription subscription in subscriptions)
                {
                    AddItem(subscription.Id, subscription.Provider, subscription.Icon + ".png", subscription.Amount, subscription.Currency, subscription.Type, subscription.Day, subscription.Month);
                }
            }
            else
            {
                //noSubscriptionLabel.Visible = true;
                if (noSubscriptionLabel.InvokeRequired)
                {
                    noSubscriptionLabel.Invoke(new Action(() => noSubscriptionLabel.Visible = true));
                }
                else
                {
                    noSubscriptionLabel.Visible = true;
                }
            }
            subscriptions = null;

            //Reset account
            userIdLabel.Text = "Account Id: " + currentUser.Id.ToString();
            usernameInput.Text = currentUser.Username;
            welcomeLabel.Text = "Welcome, " + currentUser.Username;
            emailInput.Text = currentUser.Email;
            passwordInput.Text = "";

            oldPasswordInput.Text = "";
            newPasswordInput.Text = "";
            confirmNewPasswordInput.Text = "";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            userIdLabel.Text = "Account Id: " + currentUser.Id.ToString();
            usernameInput.Text = currentUser.Username;
            welcomeLabel.Text = "Welcome, " + currentUser.Username;
            emailInput.Text = currentUser.Email;
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(closeApp)
                LoginForm._loginForm.Close();
        }

        private async void UpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameInput.Text))
                {
                    throw new ArgumentNullException("Username", "Please provide a username.");
                }
                if (string.IsNullOrEmpty(emailInput.Text))
                {
                    throw new ArgumentNullException("Email", "Please provide an email.");
                }
                if (string.IsNullOrEmpty(passwordInput.Text))
                {
                    throw new ArgumentNullException("Password", "Please provide a password.");
                }
                if (passwordInput.Text != currentUser.Password)
                {
                    throw new UnauthorizedAccessException("Invalid password. Please enter a valid password.");
                }

                User user = new User()
                {
                    Id = currentUser.Id,
                    Username = usernameInput.Text,
                    Email = emailInput.Text,
                    Password = currentUser.Password
                };

                await dm.UpdateUser(user);
                user = null;
                ResetForm();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }

        }

        private async void ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(oldPasswordInput.Text))
                {
                    throw new ArgumentNullException("Old Password", "Please provide the old password.");
                }
                if (string.IsNullOrEmpty(newPasswordInput.Text))
                {
                    throw new ArgumentNullException("New Password", "Please provide the new password.");
                }
                if (string.IsNullOrEmpty(confirmNewPasswordInput.Text))
                {
                    throw new ArgumentNullException("Confirm Password", "Please confirm the new password.");
                }
                if (oldPasswordInput.Text != currentUser.Password)
                {
                    throw new UnauthorizedAccessException("Invalid old password. Please enter a valid password.");
                }
                if (newPasswordInput.Text != confirmNewPasswordInput.Text)
                {
                    throw new UnauthorizedAccessException("New password don't match. Please confirm the new password.");
                }

                User user = new User()
                {
                    Id = currentUser.Id,
                    Username = currentUser.Username,
                    Email = currentUser.Email,
                    Password = newPasswordInput.Text
                };

                await dm.UpdateUser(user);
                user = null;
                closeApp = false;
                Close();
                LoginForm._loginForm.passwordInput.Text = null;
                LoginForm._loginForm.Show();
                MessageBox.Show("Your password was succesfully changed.");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private async void DeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(passwordInput.Text))
                {
                    throw new ArgumentNullException("Password", "Please provide a password.");
                }
                if (currentUser.Password != passwordInput.Text)
                {
                    throw new UnauthorizedAccessException("Invalid password. Please enter a valid password.");
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<Subscription> subscriptions = dm.GetSubscriptions();
                    List<Subscription> _subscriptions = subscriptions.FindAll(s => s.UserId == currentUser.Id);
                    foreach(Subscription subscription in _subscriptions)
                    {
                        await dm.DeleteSubscription(subscription);
                    }
                    await dm.DeleteUser(currentUser);
                    subscriptions = null;
                    _subscriptions = null;
                    closeApp = false;
                    Close();
                    LoginForm._loginForm.usernameInput.Text = null;
                    LoginForm._loginForm.passwordInput.Text = null;
                    LoginForm._loginForm.Show();
                    MessageBox.Show("Your account was successfully deleted.");
                }
                else
                {
                    // The user clicked No, do nothing
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        public void AddItem(Guid id, string name, string icon, double ammount, string currency, bool type, int day, string month)
        {
            var _subscription = new SubscriptionWidget()
            {
                SubId = id,
                SubName = name,
                Amount = ammount.ToString(),
                Currency = currency,
                Type = type,
                Day = day,
                Month = month,
                Icon = Image.FromFile("icons/" + icon)
            };
            //subscriptionPanel.Controls.Add(_subscription);
            if (subscriptionPanel.InvokeRequired)
            {
                subscriptionPanel.Invoke(new Action(() => subscriptionPanel.Controls.Add(_subscription)));
            }
            else
            {
                subscriptionPanel.Controls.Add(_subscription);
            }

            _subscription.OnSelect += (sub, ex) =>
            {
                var wdg = (SubscriptionWidget)sub;
                _subId = wdg.SubId;
                nameInput.Text = wdg.SubName;
                iconInput.SelectedItem = iconsDict[icon.Replace(".png","")];
                amountInput.Value = Convert.ToDecimal(wdg.Amount);
                currencyInput.Text = wdg.Currency;
                typeInput.Text = (wdg.Type ? "Monthly" : "Yearly");
                dayInput.Value = wdg.Day;
                monthInput.Text = wdg.Month;
                wdg = null;
            };

            _subscription.OnSelectDelete += async (sub, ex) =>
            {
                var wdg = (SubscriptionWidget)sub;
                List<Subscription> subscriptions = dm.GetSubscriptions();
                Subscription subscription = subscriptions.Find(s => s.Id == wdg.SubId);
                await dm.DeleteSubscription(subscription);
                ResetForm();
                wdg = null;
            };
            _subscription = null;
        }

        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return list.Count == 0;
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            List<Subscription> subscriptions = dm.GetSubscriptions();

            subscriptions = subscriptions.FindAll(s => s.UserId == currentUser.Id);

            if(!IsEmpty(subscriptions))
            {
                noSubscriptionLabel.Visible = false;
                foreach(Subscription subscription in subscriptions)
                {
                    AddItem(subscription.Id, subscription.Provider, subscription.Icon + ".png", subscription.Amount, subscription.Currency, subscription.Type, subscription.Day, subscription.Month);
                }
            }
            else
            {
                noSubscriptionLabel.Visible = true;
            }
            subscriptions = null;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            closeApp = false;
            Close();
            LoginForm._loginForm.passwordInput.Text = null;
            LoginForm._loginForm.Show();
        }

        private void TypeInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeInput.SelectedIndex.Equals(0))
            {
                monthLabel.Visible = false;
                monthInput.Visible = false;
            }
            else
            {
                monthLabel.Visible = true;
                monthInput.Visible = true;
            }
        }

        private async void AddSubscriptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameInput.Text))
                {
                    throw new ArgumentNullException("Name", "Please provide a subscription name.");
                }
                if (!_iconsStr.Contains(iconInput.SelectedItem))
                {
                    throw new ArgumentNullException("Icon", "Please select an icon.");
                }
                if (string.IsNullOrEmpty(amountInput.Text))
                {
                    throw new ArgumentNullException("Amount", "Please provide an amount.");
                }
                if (string.IsNullOrEmpty(currencyInput.Text))
                {
                    throw new ArgumentNullException("Currency", "Please provide a currency.");
                }
                if (!_typeStr.Contains(typeInput.Text))
                {
                    throw new ArgumentNullException("Type", "Please select a type.");
                }
                if (string.IsNullOrEmpty(dayInput.Text))
                {
                    throw new ArgumentNullException("Day", "Please provide a day.");
                }
                if (!_monthStr.Contains(monthInput.Text))
                {
                    throw new ArgumentNullException("Month", "Please provide a month.");
                }
                Subscription subscription = new Subscription()
                {
                    Provider = nameInput.Text,
                    Icon = iconInput.SelectedItem.ToString().Replace(" ", "").ToLower(),
                    Amount = Convert.ToDouble(Math.Round(amountInput.Value,2)),
                    Currency = currencyInput.Text.ToUpper(),
                    Type = typeInput.Text == "Monthly",
                    Day = Convert.ToInt32(dayInput.Value),
                    Month = monthInput.Text
                };
                await dm.AddSubscription(currentUser, subscription);
                subscription = null;
                ResetForm();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private async void UpdateSubscriptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameInput.Text))
                {
                    throw new ArgumentNullException("Name", "Please provide a subscription name.");
                }
                if (!_iconsStr.Contains(iconInput.SelectedItem))
                {
                    throw new ArgumentNullException("Icon", "Please select an icon.");
                }
                if (string.IsNullOrEmpty(amountInput.Text))
                {
                    throw new ArgumentNullException("Amount", "Please provide an amount.");
                }
                if (string.IsNullOrEmpty(currencyInput.Text))
                {
                    throw new ArgumentNullException("Currency", "Please provide a currency.");
                }
                if (!_typeStr.Contains(typeInput.Text))
                {
                    throw new ArgumentNullException("Type", "Please select a type.");
                }
                if (string.IsNullOrEmpty(dayInput.Text))
                {
                    throw new ArgumentNullException("Day", "Please provide a day.");
                }
                if (!_monthStr.Contains(monthInput.Text))
                {
                    throw new ArgumentNullException("Month", "Please provide a month.");
                }
                if (_subId == Guid.Empty)
                {
                    throw new UnauthorizedAccessException("Invalid selection. Please select a subscription.");
                }
                Subscription subscription = new Subscription()
                {
                    Id = _subId,
                    UserId = currentUser.Id,
                    Provider = nameInput.Text,
                    Icon = iconInput.SelectedItem.ToString().Replace(" ", "").ToLower(),
                    Amount = Convert.ToDouble(Math.Round(amountInput.Value,2)),
                    Currency = currencyInput.Text.ToUpper(),
                    Type = typeInput.Text == "Monthly",
                    Day = Convert.ToInt32(dayInput.Value),
                    Month = monthInput.Text
                };
                await dm.UpdateSubscription(subscription);
                subscription = null;
                ResetForm();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
