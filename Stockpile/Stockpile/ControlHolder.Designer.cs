namespace Stockpile
{
    partial class ControlHolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlHolder));
            this.lblCartCount = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaymentMethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShippingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxWishList = new System.Windows.Forms.ToolStripComboBox();
            this.editWishListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.Location = new System.Drawing.Point(482, 227);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(16, 18);
            this.lblCartCount.TabIndex = 10;
            this.lblCartCount.Text = "#";
            this.lblCartCount.Visible = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.backToMainPageToolStripMenuItem,
            this.shoppingCartToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(173, 213);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(337, 29);
            this.mainMenuStrip.TabIndex = 11;
            // 
            // userIDToolStripMenuItem
            // 
            this.userIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.wishListsToolStripMenuItem,
            this.viewPurchaseHistoryToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.userIDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDToolStripMenuItem.Name = "userIDToolStripMenuItem";
            this.userIDToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.userIDToolStripMenuItem.Text = "UserID";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.editPaymentMethodsToolStripMenuItem,
            this.viewBillingInformationToolStripMenuItem,
            this.viewShippingInformationToolStripMenuItem});
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // editPaymentMethodsToolStripMenuItem
            // 
            this.editPaymentMethodsToolStripMenuItem.Name = "editPaymentMethodsToolStripMenuItem";
            this.editPaymentMethodsToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.editPaymentMethodsToolStripMenuItem.Text = "Edit Payment Methods";
            // 
            // viewBillingInformationToolStripMenuItem
            // 
            this.viewBillingInformationToolStripMenuItem.Name = "viewBillingInformationToolStripMenuItem";
            this.viewBillingInformationToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewBillingInformationToolStripMenuItem.Text = "View Billing Information";
            // 
            // viewShippingInformationToolStripMenuItem
            // 
            this.viewShippingInformationToolStripMenuItem.Name = "viewShippingInformationToolStripMenuItem";
            this.viewShippingInformationToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewShippingInformationToolStripMenuItem.Text = "View Shipping Information";
            // 
            // wishListsToolStripMenuItem
            // 
            this.wishListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxWishList,
            this.editWishListsToolStripMenuItem});
            this.wishListsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishListsToolStripMenuItem.Name = "wishListsToolStripMenuItem";
            this.wishListsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.wishListsToolStripMenuItem.Text = "Wish Lists";
            // 
            // toolStripComboBoxWishList
            // 
            this.toolStripComboBoxWishList.Name = "toolStripComboBoxWishList";
            this.toolStripComboBoxWishList.Size = new System.Drawing.Size(121, 23);
            // 
            // editWishListsToolStripMenuItem
            // 
            this.editWishListsToolStripMenuItem.Name = "editWishListsToolStripMenuItem";
            this.editWishListsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editWishListsToolStripMenuItem.Text = "Edit Wish Lists";
            // 
            // viewPurchaseHistoryToolStripMenuItem
            // 
            this.viewPurchaseHistoryToolStripMenuItem.Name = "viewPurchaseHistoryToolStripMenuItem";
            this.viewPurchaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewPurchaseHistoryToolStripMenuItem.Text = "View Purchase History";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // backToMainPageToolStripMenuItem
            // 
            this.backToMainPageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainPageToolStripMenuItem.Name = "backToMainPageToolStripMenuItem";
            this.backToMainPageToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.backToMainPageToolStripMenuItem.Text = "Back To Main Page";
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shoppingCartToolStripMenuItem.Image")));
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(28, 25);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(158, 0);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(253, 217);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ControlHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 458);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ControlHolder";
            this.Text = "ControlHolder";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem userIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPaymentMethodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShippingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWishList;
        private System.Windows.Forms.ToolStripMenuItem editWishListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}