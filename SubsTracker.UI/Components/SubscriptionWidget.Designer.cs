
namespace SubsTracker.UI.Components
{
    partial class SubscriptionWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subscriptionName = new System.Windows.Forms.Label();
            this.subscriptionAmmount = new System.Windows.Forms.Label();
            this.subscriptionPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.deleteButton = new System.Windows.Forms.PictureBox();
            this.subscriptionDate = new System.Windows.Forms.Label();
            this.subscriptionIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionPanel)).BeginInit();
            this.subscriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // subscriptionName
            // 
            this.subscriptionName.AutoSize = true;
            this.subscriptionName.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subscriptionName.Location = new System.Drawing.Point(71, 5);
            this.subscriptionName.Name = "subscriptionName";
            this.subscriptionName.Size = new System.Drawing.Size(72, 34);
            this.subscriptionName.TabIndex = 2;
            this.subscriptionName.Text = "Netflix";
            this.subscriptionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subscriptionName.Click += new System.EventHandler(this.SubscriptionName_Click);
            // 
            // subscriptionAmmount
            // 
            this.subscriptionAmmount.AutoSize = true;
            this.subscriptionAmmount.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subscriptionAmmount.Location = new System.Drawing.Point(71, 35);
            this.subscriptionAmmount.Name = "subscriptionAmmount";
            this.subscriptionAmmount.Size = new System.Drawing.Size(107, 30);
            this.subscriptionAmmount.TabIndex = 3;
            this.subscriptionAmmount.Text = "999.99 EUR";
            this.subscriptionAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subscriptionAmmount.Click += new System.EventHandler(this.SubscriptionAmmount_Click);
            // 
            // subscriptionPanel
            // 
            this.subscriptionPanel.Controls.Add(this.deleteButton);
            this.subscriptionPanel.Controls.Add(this.subscriptionDate);
            this.subscriptionPanel.Controls.Add(this.subscriptionIcon);
            this.subscriptionPanel.Controls.Add(this.subscriptionAmmount);
            this.subscriptionPanel.Controls.Add(this.subscriptionName);
            this.subscriptionPanel.Location = new System.Drawing.Point(5, 5);
            this.subscriptionPanel.Name = "subscriptionPanel";
            this.subscriptionPanel.Size = new System.Drawing.Size(390, 70);
            this.subscriptionPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.subscriptionPanel.StateCommon.Color2 = System.Drawing.Color.Silver;
            this.subscriptionPanel.TabIndex = 4;
            this.subscriptionPanel.Click += new System.EventHandler(this.SubscriptionPanel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::SubsTracker.UI.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(330, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 5;
            this.deleteButton.TabStop = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // subscriptionDate
            // 
            this.subscriptionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscriptionDate.AutoEllipsis = true;
            this.subscriptionDate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionDate.Location = new System.Drawing.Point(199, 35);
            this.subscriptionDate.Name = "subscriptionDate";
            this.subscriptionDate.Size = new System.Drawing.Size(125, 30);
            this.subscriptionDate.TabIndex = 4;
            this.subscriptionDate.Text = "20 Jun 2024";
            this.subscriptionDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subscriptionDate.Click += new System.EventHandler(this.SubscriptionDate_Click);
            // 
            // subscriptionIcon
            // 
            this.subscriptionIcon.Image = global::SubsTracker.UI.Properties.Resources.netflix;
            this.subscriptionIcon.Location = new System.Drawing.Point(5, 5);
            this.subscriptionIcon.Name = "subscriptionIcon";
            this.subscriptionIcon.Size = new System.Drawing.Size(60, 60);
            this.subscriptionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subscriptionIcon.TabIndex = 0;
            this.subscriptionIcon.TabStop = false;
            this.subscriptionIcon.Click += new System.EventHandler(this.SubscriptionIcon_Click);
            // 
            // SubscriptionWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.subscriptionPanel);
            this.Name = "SubscriptionWidget";
            this.Size = new System.Drawing.Size(400, 80);
            this.Load += new System.EventHandler(this.SubscriptionWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionPanel)).EndInit();
            this.subscriptionPanel.ResumeLayout(false);
            this.subscriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox subscriptionIcon;
        private System.Windows.Forms.Label subscriptionName;
        private System.Windows.Forms.Label subscriptionAmmount;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel subscriptionPanel;
        private System.Windows.Forms.Label subscriptionDate;
        private System.Windows.Forms.PictureBox deleteButton;
    }
}
