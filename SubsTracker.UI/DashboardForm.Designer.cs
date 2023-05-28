
namespace SubsTracker.UI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.signupHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dashboardNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.subscriptionsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.noSubscriptionLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthInput = new System.Windows.Forms.ComboBox();
            this.dayInput = new System.Windows.Forms.NumericUpDown();
            this.dayLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.currencyInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconInput = new System.Windows.Forms.ComboBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.updateSubscriptionButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addSubscriptionButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.subscriptionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.accountSettingsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.deleteAccount = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.changePassword = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.confirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.confirmNewPasswordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.updateInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardNavigator)).BeginInit();
            this.dashboardNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsPage)).BeginInit();
            this.subscriptionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountSettingsPage)).BeginInit();
            this.accountSettingsPage.SuspendLayout();
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
            this.signupHeader.TabIndex = 23;
            this.signupHeader.Values.Description = "";
            this.signupHeader.Values.Heading = "Dashboard";
            this.signupHeader.Values.Image = null;
            // 
            // dashboardNavigator
            // 
            this.dashboardNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.dashboardNavigator.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.dashboardNavigator.Location = new System.Drawing.Point(12, 70);
            this.dashboardNavigator.Name = "dashboardNavigator";
            this.dashboardNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            this.dashboardNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.subscriptionsPage,
            this.accountSettingsPage});
            this.dashboardNavigator.SelectedIndex = 0;
            this.dashboardNavigator.Size = new System.Drawing.Size(658, 371);
            this.dashboardNavigator.TabIndex = 29;
            this.dashboardNavigator.Text = "kryptonNavigator1";
            // 
            // subscriptionsPage
            // 
            this.subscriptionsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.subscriptionsPage.Controls.Add(this.noSubscriptionLabel);
            this.subscriptionsPage.Controls.Add(this.monthLabel);
            this.subscriptionsPage.Controls.Add(this.monthInput);
            this.subscriptionsPage.Controls.Add(this.dayInput);
            this.subscriptionsPage.Controls.Add(this.dayLabel);
            this.subscriptionsPage.Controls.Add(this.typeLabel);
            this.subscriptionsPage.Controls.Add(this.typeInput);
            this.subscriptionsPage.Controls.Add(this.currencyInput);
            this.subscriptionsPage.Controls.Add(this.nameInput);
            this.subscriptionsPage.Controls.Add(this.amountInput);
            this.subscriptionsPage.Controls.Add(this.iconLabel);
            this.subscriptionsPage.Controls.Add(this.iconInput);
            this.subscriptionsPage.Controls.Add(this.currencyLabel);
            this.subscriptionsPage.Controls.Add(this.amountLabel);
            this.subscriptionsPage.Controls.Add(this.nameLabel);
            this.subscriptionsPage.Controls.Add(this.updateSubscriptionButton);
            this.subscriptionsPage.Controls.Add(this.addSubscriptionButton);
            this.subscriptionsPage.Controls.Add(this.subscriptionPanel);
            this.subscriptionsPage.Flags = 65534;
            this.subscriptionsPage.LastVisibleSet = true;
            this.subscriptionsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.subscriptionsPage.Name = "subscriptionsPage";
            this.subscriptionsPage.Size = new System.Drawing.Size(656, 338);
            this.subscriptionsPage.Text = "Subscriptions";
            this.subscriptionsPage.ToolTipTitle = "Page ToolTip";
            this.subscriptionsPage.UniqueName = "507E95BB7D3846EEAA943FA69CD857ED";
            // 
            // noSubscriptionLabel
            // 
            this.noSubscriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.noSubscriptionLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSubscriptionLabel.Location = new System.Drawing.Point(3, 3);
            this.noSubscriptionLabel.Name = "noSubscriptionLabel";
            this.noSubscriptionLabel.Size = new System.Drawing.Size(326, 332);
            this.noSubscriptionLabel.TabIndex = 55;
            this.noSubscriptionLabel.Text = "You don\'t have any subscriptions. Add a subscription and it will we shown here.";
            this.noSubscriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Location = new System.Drawing.Point(496, 267);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(47, 17);
            this.monthLabel.TabIndex = 54;
            this.monthLabel.Text = "Month";
            // 
            // monthInput
            // 
            this.monthInput.DisplayMember = "mon";
            this.monthInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthInput.FormattingEnabled = true;
            this.monthInput.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthInput.Location = new System.Drawing.Point(499, 287);
            this.monthInput.Name = "monthInput";
            this.monthInput.Size = new System.Drawing.Size(154, 38);
            this.monthInput.TabIndex = 8;
            this.monthInput.Text = "Jan";
            // 
            // dayInput
            // 
            this.dayInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayInput.Location = new System.Drawing.Point(499, 216);
            this.dayInput.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayInput.Name = "dayInput";
            this.dayInput.Size = new System.Drawing.Size(154, 33);
            this.dayInput.TabIndex = 7;
            this.dayInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Location = new System.Drawing.Point(496, 196);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(33, 17);
            this.dayLabel.TabIndex = 51;
            this.dayLabel.Text = "Day";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Location = new System.Drawing.Point(335, 196);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 50;
            this.typeLabel.Text = "Type";
            // 
            // typeInput
            // 
            this.typeInput.DisplayMember = "mon";
            this.typeInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.typeInput.Location = new System.Drawing.Point(338, 216);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(154, 38);
            this.typeInput.TabIndex = 6;
            this.typeInput.Text = "Monthly";
            this.typeInput.SelectedIndexChanged += new System.EventHandler(this.TypeInput_SelectedIndexChanged);
            // 
            // currencyInput
            // 
            this.currencyInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyInput.Location = new System.Drawing.Point(499, 148);
            this.currencyInput.MaxLength = 3;
            this.currencyInput.Name = "currencyInput";
            this.currencyInput.Size = new System.Drawing.Size(154, 33);
            this.currencyInput.TabIndex = 5;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(338, 81);
            this.nameInput.MaxLength = 20;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(154, 33);
            this.nameInput.TabIndex = 2;
            // 
            // amountInput
            // 
            this.amountInput.DecimalPlaces = 2;
            this.amountInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.Location = new System.Drawing.Point(338, 148);
            this.amountInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(154, 33);
            this.amountInput.TabIndex = 4;
            this.amountInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.BackColor = System.Drawing.Color.Transparent;
            this.iconLabel.Location = new System.Drawing.Point(496, 61);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(34, 17);
            this.iconLabel.TabIndex = 44;
            this.iconLabel.Text = "Icon";
            // 
            // iconInput
            // 
            this.iconInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconInput.FormattingEnabled = true;
            this.iconInput.Items.AddRange(new object[] {
            "SubsTracker",
            "Netflix",
            "HBO Max",
            "Spotify",
            "YouTube",
            "Twitch"});
            this.iconInput.Location = new System.Drawing.Point(499, 81);
            this.iconInput.Name = "iconInput";
            this.iconInput.Size = new System.Drawing.Size(154, 38);
            this.iconInput.TabIndex = 3;
            this.iconInput.Text = "SubsTracker";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.BackColor = System.Drawing.Color.Transparent;
            this.currencyLabel.Location = new System.Drawing.Point(496, 128);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(65, 17);
            this.currencyLabel.TabIndex = 39;
            this.currencyLabel.Text = "Currency";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel.Location = new System.Drawing.Point(335, 128);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 37;
            this.amountLabel.Text = "Amount";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(335, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 35;
            this.nameLabel.Text = "Name";
            // 
            // updateSubscriptionButton
            // 
            this.updateSubscriptionButton.Location = new System.Drawing.Point(488, 9);
            this.updateSubscriptionButton.Name = "updateSubscriptionButton";
            this.updateSubscriptionButton.Size = new System.Drawing.Size(165, 44);
            this.updateSubscriptionButton.TabIndex = 10;
            this.updateSubscriptionButton.Values.Text = "Update Subscription";
            this.updateSubscriptionButton.Click += new System.EventHandler(this.UpdateSubscriptionButton_Click);
            // 
            // addSubscriptionButton
            // 
            this.addSubscriptionButton.Location = new System.Drawing.Point(335, 9);
            this.addSubscriptionButton.Name = "addSubscriptionButton";
            this.addSubscriptionButton.Size = new System.Drawing.Size(147, 44);
            this.addSubscriptionButton.TabIndex = 9;
            this.addSubscriptionButton.Values.Text = "Add Subscription";
            this.addSubscriptionButton.Click += new System.EventHandler(this.AddSubscriptionButton_Click);
            // 
            // subscriptionPanel
            // 
            this.subscriptionPanel.AutoScroll = true;
            this.subscriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.subscriptionPanel.Location = new System.Drawing.Point(3, 3);
            this.subscriptionPanel.Name = "subscriptionPanel";
            this.subscriptionPanel.Size = new System.Drawing.Size(326, 332);
            this.subscriptionPanel.TabIndex = 0;
            // 
            // accountSettingsPage
            // 
            this.accountSettingsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.accountSettingsPage.Controls.Add(this.deleteAccount);
            this.accountSettingsPage.Controls.Add(this.userIdLabel);
            this.accountSettingsPage.Controls.Add(this.changePassword);
            this.accountSettingsPage.Controls.Add(this.oldPasswordLabel);
            this.accountSettingsPage.Controls.Add(this.oldPasswordInput);
            this.accountSettingsPage.Controls.Add(this.newPasswordLabel);
            this.accountSettingsPage.Controls.Add(this.newPasswordInput);
            this.accountSettingsPage.Controls.Add(this.emailLabel);
            this.accountSettingsPage.Controls.Add(this.emailInput);
            this.accountSettingsPage.Controls.Add(this.confirmNewPasswordLabel);
            this.accountSettingsPage.Controls.Add(this.confirmNewPasswordInput);
            this.accountSettingsPage.Controls.Add(this.updateInfo);
            this.accountSettingsPage.Controls.Add(this.usernameLabel);
            this.accountSettingsPage.Controls.Add(this.usernameInput);
            this.accountSettingsPage.Controls.Add(this.passwordLabel);
            this.accountSettingsPage.Controls.Add(this.passwordInput);
            this.accountSettingsPage.Flags = 65534;
            this.accountSettingsPage.LastVisibleSet = true;
            this.accountSettingsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.accountSettingsPage.Name = "accountSettingsPage";
            this.accountSettingsPage.Size = new System.Drawing.Size(656, 338);
            this.accountSettingsPage.Text = "Account Settings";
            this.accountSettingsPage.ToolTipTitle = "Page ToolTip";
            this.accountSettingsPage.UniqueName = "3ECD849B10C84FB9BFA01383175A2FA7";
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(170, 243);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.deleteAccount.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.deleteAccount.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteAccount.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteAccount.Size = new System.Drawing.Size(117, 44);
            this.deleteAccount.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.deleteAccount.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.deleteAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteAccount.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteAccount.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteAccount.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteAccount.TabIndex = 15;
            this.deleteAccount.Values.Text = "Delete Account";
            this.deleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.userIdLabel.Location = new System.Drawing.Point(62, 20);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(116, 17);
            this.userIdLabel.TabIndex = 32;
            this.userIdLabel.Text = "Account ID: 0000";
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(378, 243);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(148, 44);
            this.changePassword.TabIndex = 19;
            this.changePassword.Values.Text = "Change Password";
            this.changePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.oldPasswordLabel.Location = new System.Drawing.Point(375, 50);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(95, 17);
            this.oldPasswordLabel.TabIndex = 29;
            this.oldPasswordLabel.Text = "Old Password";
            // 
            // oldPasswordInput
            // 
            this.oldPasswordInput.Location = new System.Drawing.Point(378, 70);
            this.oldPasswordInput.Name = "oldPasswordInput";
            this.oldPasswordInput.PasswordChar = '●';
            this.oldPasswordInput.Size = new System.Drawing.Size(222, 27);
            this.oldPasswordInput.TabIndex = 16;
            this.oldPasswordInput.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLabel.Location = new System.Drawing.Point(375, 100);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(100, 17);
            this.newPasswordLabel.TabIndex = 27;
            this.newPasswordLabel.Text = "New Password";
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.Location = new System.Drawing.Point(378, 120);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.PasswordChar = '●';
            this.newPasswordInput.Size = new System.Drawing.Size(222, 27);
            this.newPasswordInput.TabIndex = 17;
            this.newPasswordInput.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(62, 100);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(65, 120);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(222, 27);
            this.emailInput.TabIndex = 12;
            // 
            // confirmNewPasswordLabel
            // 
            this.confirmNewPasswordLabel.AutoSize = true;
            this.confirmNewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmNewPasswordLabel.Location = new System.Drawing.Point(375, 150);
            this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            this.confirmNewPasswordLabel.Size = new System.Drawing.Size(152, 17);
            this.confirmNewPasswordLabel.TabIndex = 23;
            this.confirmNewPasswordLabel.Text = "Confirm New Password";
            // 
            // confirmNewPasswordInput
            // 
            this.confirmNewPasswordInput.Location = new System.Drawing.Point(378, 170);
            this.confirmNewPasswordInput.Name = "confirmNewPasswordInput";
            this.confirmNewPasswordInput.PasswordChar = '●';
            this.confirmNewPasswordInput.Size = new System.Drawing.Size(222, 27);
            this.confirmNewPasswordInput.TabIndex = 18;
            this.confirmNewPasswordInput.UseSystemPasswordChar = true;
            // 
            // updateInfo
            // 
            this.updateInfo.Location = new System.Drawing.Point(65, 243);
            this.updateInfo.Name = "updateInfo";
            this.updateInfo.Size = new System.Drawing.Size(99, 44);
            this.updateInfo.TabIndex = 14;
            this.updateInfo.Values.Text = "Update Info";
            this.updateInfo.Click += new System.EventHandler(this.UpdateInfo_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Location = new System.Drawing.Point(62, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(65, 70);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(222, 27);
            this.usernameInput.TabIndex = 11;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(62, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(65, 170);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.Size = new System.Drawing.Size(222, 27);
            this.passwordInput.TabIndex = 13;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoEllipsis = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(376, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(220, 21);
            this.welcomeLabel.TabIndex = 34;
            this.welcomeLabel.Text = "Welcome, username";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(602, 14);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(67, 33);
            this.logoutButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Values.Text = "Log Out";
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.dashboardNavigator);
            this.Controls.Add(this.signupHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubsTracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.Shown += new System.EventHandler(this.DashboardForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardNavigator)).EndInit();
            this.dashboardNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsPage)).EndInit();
            this.subscriptionsPage.ResumeLayout(false);
            this.subscriptionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountSettingsPage)).EndInit();
            this.accountSettingsPage.ResumeLayout(false);
            this.accountSettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonHeader signupHeader;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator dashboardNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage subscriptionsPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage accountSettingsPage;
        private System.Windows.Forms.Label userIdLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton changePassword;
        private System.Windows.Forms.Label oldPasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox oldPasswordInput;
        private System.Windows.Forms.Label newPasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newPasswordInput;
        private System.Windows.Forms.Label emailLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailInput;
        private System.Windows.Forms.Label confirmNewPasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox confirmNewPasswordInput;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateInfo;
        private System.Windows.Forms.Label usernameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordInput;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteAccount;
        private System.Windows.Forms.FlowLayoutPanel subscriptionPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logoutButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addSubscriptionButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateSubscriptionButton;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox iconInput;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.TextBox currencyInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.NumericUpDown amountInput;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox monthInput;
        private System.Windows.Forms.NumericUpDown dayInput;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeInput;
        private System.Windows.Forms.Label noSubscriptionLabel;
    }
}