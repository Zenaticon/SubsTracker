
namespace SubsTracker.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.loginButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.signupButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // loginHeader
            // 
            this.loginHeader.AutoSize = false;
            this.loginHeader.Location = new System.Drawing.Point(12, 12);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.Size = new System.Drawing.Size(658, 52);
            this.loginHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.loginHeader.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.loginHeader.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginHeader.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginHeader.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.loginHeader.StateCommon.Border.Width = 2;
            this.loginHeader.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.loginHeader.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginHeader.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginHeader.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeader.TabIndex = 6;
            this.loginHeader.Values.Description = "";
            this.loginHeader.Values.Heading = "LogIn Page";
            this.loginHeader.Values.Image = null;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(180, 173);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(183, 193);
            this.usernameInput.MaxLength = 40;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(148, 27);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(334, 173);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(337, 193);
            this.passwordInput.MaxLength = 40;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.Size = new System.Drawing.Size(148, 27);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(181, 257);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 44);
            this.loginButton.TabIndex = 4;
            this.loginButton.Values.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(337, 257);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(150, 44);
            this.signupButton.TabIndex = 5;
            this.signupButton.Values.Text = "Sign Up";
            this.signupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.loginHeader);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubsTracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonHeader loginHeader;
        private System.Windows.Forms.Label usernameLabel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordInput;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signupButton;
    }
}

