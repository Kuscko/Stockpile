namespace Stockpile
{
    partial class frmEditWishlists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditWishlists));
            this.lblCartCount = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaymentMethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShippingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWishlists = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvWishlist = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.Location = new System.Drawing.Point(669, 23);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(16, 18);
            this.lblCartCount.TabIndex = 13;
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
            this.mainMenuStrip.Location = new System.Drawing.Point(360, 9);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(337, 29);
            this.mainMenuStrip.TabIndex = 14;
            // 
            // userIDToolStripMenuItem
            // 
            this.userIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
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
            this.toolStripContainer1.Location = new System.Drawing.Point(440, 13);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(156, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(419, 103);
            this.label18.TabIndex = 39;
            this.label18.Text = "EDIT WISHLISTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Wishlists:";
            // 
            // cboWishlists
            // 
            this.cboWishlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWishlists.FormattingEnabled = true;
            this.cboWishlists.Location = new System.Drawing.Point(93, 173);
            this.cboWishlists.Name = "cboWishlists";
            this.cboWishlists.Size = new System.Drawing.Size(341, 28);
            this.cboWishlists.TabIndex = 47;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(440, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(521, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // lvWishlist
            // 
            this.lvWishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWishlist.Location = new System.Drawing.Point(16, 207);
            this.lvWishlist.Name = "lvWishlist";
            this.lvWishlist.Size = new System.Drawing.Size(543, 238);
            this.lvWishlist.TabIndex = 62;
            this.lvWishlist.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(602, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(565, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 29);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "&Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(565, 274);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(112, 29);
            this.btnRemoveItem.TabIndex = 65;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Visible = false;
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(618, 242);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(59, 26);
            this.numQuantity.TabIndex = 66;
            // 
            // frmEditWishlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.ControlBox = false;
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvWishlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboWishlists);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmEditWishlists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWishlists;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvWishlist;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}