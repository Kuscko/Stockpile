namespace Stockpile
{
    partial class frmShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoppingCart));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(48, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Description:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(272, 319);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(390, 187);
            this.textBox2.TabIndex = 23;
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(272, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(390, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Name:";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(16, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(646, 126);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 103);
            this.label1.TabIndex = 19;
            this.label1.Text = "SHOPPING CART";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(272, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(601, 536);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 26);
            this.numericUpDown1.TabIndex = 29;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(353, 534);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 29);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.Location = new System.Drawing.Point(640, 23);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(16, 18);
            this.lblCartCount.TabIndex = 31;
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
            this.mainMenuStrip.Location = new System.Drawing.Point(331, 9);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(337, 29);
            this.mainMenuStrip.TabIndex = 32;
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
            this.toolStripContainer1.Location = new System.Drawing.Point(411, 13);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 33;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 583);
            this.ControlBox = false;
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "frmShoppingCart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnRemove;
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