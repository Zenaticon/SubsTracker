using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SubsTracker.Core;

namespace SubsTracker.UI
{
    public partial class LoginForm : Form
    {
        public static LoginForm _loginForm;
        public static SignupForm _signupForm;

        private static readonly DataManager dm = new DataManager();
        public LoginForm()
        {
            InitializeComponent();
            _signupForm = new SignupForm();
            _loginForm = this;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> users = dm.GetUsers();

                User currentUser = new User
                {
                    Username = usernameInput.Text,
                    Password = passwordInput.Text
                };

                // Check if username and password are provided
                if (string.IsNullOrEmpty(currentUser.Username))
                {
                    throw new ArgumentNullException(nameof(currentUser.Username), "Please provide a username.");
                }

                if (string.IsNullOrEmpty(currentUser.Password))
                {
                    throw new ArgumentNullException(nameof(currentUser.Password), "Please provide a password.");
                }

                User user = users.Find(u => u.Username == currentUser.Username);

                if (user == null)
                {
                    throw new UnauthorizedAccessException("Invalid username. Please enter a valid username.");
                }

                if (user.Password == passwordInput.Text)
                {
                    //MessageBox.Show("Succesfully logged in.");
                    DashboardForm _dashboardForm = new DashboardForm(user);
                    _dashboardForm.Show();
                    Hide();
                }
                else
                {
                    throw new UnauthorizedAccessException("Invalid password. Please enter a valid password.");
                }
                users = null;
                user = null;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
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

        private void SignupButton_Click(object sender, EventArgs e)
        {
            _signupForm.ShowDialog();
        }
    }
}
