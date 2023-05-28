using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SubsTracker.Core;

namespace SubsTracker.UI
{
    public partial class SignupForm : Form
    {
        private static readonly DataManager dm = new DataManager();
        public SignupForm()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            usernameInput.Text = "";
            emailInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
        }

        private async void SignupButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> users = dm.GetUsers();
                User currentUser = new User
                {
                    Username = usernameInput.Text,
                    Email = emailInput.Text,
                    Password = passwordInput.Text
                };

                if (string.IsNullOrEmpty(currentUser.Username))
                {
                    throw new ArgumentNullException(nameof(currentUser.Username), "Please provide a username.");
                }
                if (string.IsNullOrEmpty(currentUser.Email))
                {
                    throw new ArgumentNullException(nameof(currentUser.Email), "Please provide a email.");
                }
                if (string.IsNullOrEmpty(currentUser.Password))
                {
                    throw new ArgumentNullException(nameof(currentUser.Password), "Please provide a password.");
                }
                if (string.IsNullOrEmpty(confirmPasswordInput.Text))
                {
                    throw new ArgumentNullException("Confirm Password", "Please provide a password.");
                }

                User user = users.Find(u => u.Username == currentUser.Username);

                if (user != null)
                {
                    throw new ArgumentException("Username already exists. Please enter another username.", "Username");
                }

                user = users.Find(u => u.Email == currentUser.Email);

                if (user != null)
                {
                    throw new ArgumentException("Email already exists. Please enter another email.", "Email");
                }


                if (passwordInput.Text == confirmPasswordInput.Text)
                {
                    await dm.AddUser(currentUser);

                    LoginForm._loginForm.usernameInput.Text = currentUser.Username;
                    DialogResult = DialogResult.OK;
                    ResetForm();
                }
                else
                {
                    throw new ArgumentException("Passwords do not match. Please try again.", "Confirm Password");
                }
                users = null;
                user = null;
                currentUser = null;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            ResetForm();
        }
    }
}