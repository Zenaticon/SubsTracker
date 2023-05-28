
namespace SubsTracker.UI
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.signupHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.signupButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // signupHeader
            // 
            this.signupHeader.AutoSize = false;
            this.signupHeader.Location = new System.Drawing.Point(12, 12);
            this.signupHeader.Name = "signupHeader";
            this.signupHeader.Size = new System.Drawing.Size(658, 52);
            this.signupHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.signupHeader.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.signupHeader.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupHeader.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupHeader.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.signupHeader.StateCommon.Border.Width = 2;
            this.signupHeader.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.signupHeader.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupHeader.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupHeader.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupHeader.TabIndex = 13;
            this.signupHeader.Values.Description = "";
            this.signupHeader.Values.Heading = "SignUp Page";
            this.signupHeader.Values.Image = null;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(176, 289);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(148, 44);
            this.signupButton.TabIndex = 9;
            this.signupButton.Values.Text = "Create Account";
            this.signupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(173, 146);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(176, 166);
            this.usernameInput.MaxLength = 40;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(148, 27);
            this.usernameInput.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(173, 196);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(176, 216);
            this.passwordInput.MaxLength = 40;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.Size = new System.Drawing.Size(148, 27);
            this.passwordInput.TabIndex = 6;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(330, 196);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.confirmPasswordLabel.TabIndex = 7;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(333, 216);
            this.confirmPasswordInput.MaxLength = 40;
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.PasswordChar = '●';
            this.confirmPasswordInput.Size = new System.Drawing.Size(148, 27);
            this.confirmPasswordInput.TabIndex = 8;
            this.confirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(329, 146);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(332, 166);
            this.emailInput.MaxLength = 40;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(148, 27);
            this.emailInput.TabIndex = 4;
            // 
            // SignupForm
            // 
            this.AcceptButton = this.signupButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.signupHeader);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubsTracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignupForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeader signupHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signupButton;
        private System.Windows.Forms.Label usernameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordInput;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox confirmPasswordInput;
        private System.Windows.Forms.Label emailLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailInput;
    }
}