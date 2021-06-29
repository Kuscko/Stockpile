namespace Stockpile
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShippingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAWishlistBellowToLoadItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxWishList = new System.Windows.Forms.ToolStripComboBox();
            this.editWishListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblShoppingList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxOrderAmount = new System.Windows.Forms.ListBox();
            this.lbxShoppingList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboSearch = new System.Windows.Forms.TextBox();
            this.priceRangeLabel = new System.Windows.Forms.Label();
            this.tboLowestDesired = new System.Windows.Forms.TextBox();
            this.tboHighestDesired = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.numUDItemAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddToWishList = new System.Windows.Forms.Button();
            this.tboDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBillingOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboShippingOptions = new System.Windows.Forms.ComboBox();
            this.chkSameAs = new System.Windows.Forms.CheckBox();
            this.lblSameAs = new System.Windows.Forms.Label();
            this.lbxProductLists = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.billingOptionsToolTip = new System.Windows.Forms.ToolTip(this.components);
            categoryLabel = new System.Windows.Forms.Label();
            this.toolStripContainer1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(6, 95);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(72, 18);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "C&ategory:";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(158, 0);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(1042, 9);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.shoppingCartToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(1014, 9);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(160, 29);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // userIDToolStripMenuItem
            // 
            this.userIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.wishListsToolStripMenuItem,
            this.viewOrderHistoryToolStripMenuItem,
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
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // viewBillingInformationToolStripMenuItem
            // 
            this.viewBillingInformationToolStripMenuItem.Name = "viewBillingInformationToolStripMenuItem";
            this.viewBillingInformationToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewBillingInformationToolStripMenuItem.Text = "View Billing Information";
            this.viewBillingInformationToolStripMenuItem.Click += new System.EventHandler(this.viewBillingInformationToolStripMenuItem_Click);
            // 
            // viewShippingInformationToolStripMenuItem
            // 
            this.viewShippingInformationToolStripMenuItem.Name = "viewShippingInformationToolStripMenuItem";
            this.viewShippingInformationToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewShippingInformationToolStripMenuItem.Text = "View Shipping Information";
            this.viewShippingInformationToolStripMenuItem.Click += new System.EventHandler(this.viewShippingInformationToolStripMenuItem_Click);
            // 
            // wishListsToolStripMenuItem
            // 
            this.wishListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAWishlistBellowToLoadItToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripComboBoxWishList,
            this.editWishListsToolStripMenuItem});
            this.wishListsToolStripMenuItem.Enabled = false;
            this.wishListsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishListsToolStripMenuItem.Name = "wishListsToolStripMenuItem";
            this.wishListsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.wishListsToolStripMenuItem.Text = "Wish Lists";
            this.wishListsToolStripMenuItem.Visible = false;
            // 
            // selectAWishlistBellowToLoadItToolStripMenuItem
            // 
            this.selectAWishlistBellowToLoadItToolStripMenuItem.Enabled = false;
            this.selectAWishlistBellowToLoadItToolStripMenuItem.Name = "selectAWishlistBellowToLoadItToolStripMenuItem";
            this.selectAWishlistBellowToLoadItToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.selectAWishlistBellowToLoadItToolStripMenuItem.Text = "Select A Wishlist Bellow to load it";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // toolStripComboBoxWishList
            // 
            this.toolStripComboBoxWishList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxWishList.Items.AddRange(new object[] {
            "Select Wishlist to Load"});
            this.toolStripComboBoxWishList.Name = "toolStripComboBoxWishList";
            this.toolStripComboBoxWishList.Size = new System.Drawing.Size(200, 29);
            // 
            // editWishListsToolStripMenuItem
            // 
            this.editWishListsToolStripMenuItem.Name = "editWishListsToolStripMenuItem";
            this.editWishListsToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.editWishListsToolStripMenuItem.Text = "Edit Wish Lists";
            // 
            // viewOrderHistoryToolStripMenuItem
            // 
            this.viewOrderHistoryToolStripMenuItem.Enabled = false;
            this.viewOrderHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderHistoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewOrderHistoryToolStripMenuItem.Name = "viewOrderHistoryToolStripMenuItem";
            this.viewOrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewOrderHistoryToolStripMenuItem.Text = "View Purchase History";
            this.viewOrderHistoryToolStripMenuItem.Visible = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shoppingCartToolStripMenuItem.Image")));
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(28, 25);
            this.shoppingCartToolStripMenuItem.Visible = false;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.Location = new System.Drawing.Point(1172, 25);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(16, 18);
            this.lblCartCount.TabIndex = 0;
            this.lblCartCount.Text = "#";
            this.lblCartCount.Visible = false;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.ErrorImage = null;
            this.picProduct.InitialImage = null;
            this.picProduct.Location = new System.Drawing.Point(894, 165);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(276, 231);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 1;
            this.picProduct.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 103);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCKPILE HOME PAGE";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(991, 816);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(95, 31);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Check &Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(991, 853);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save as &Wish List";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1092, 816);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblShoppingList
            // 
            this.lblShoppingList.AutoSize = true;
            this.lblShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingList.Location = new System.Drawing.Point(117, 9);
            this.lblShoppingList.Name = "lblShoppingList";
            this.lblShoppingList.Size = new System.Drawing.Size(143, 25);
            this.lblShoppingList.TabIndex = 7;
            this.lblShoppingList.Text = "Shopping &List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxOrderAmount);
            this.panel1.Controls.Add(this.lbxShoppingList);
            this.panel1.Controls.Add(this.lblShoppingList);
            this.panel1.Location = new System.Drawing.Point(848, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 333);
            this.panel1.TabIndex = 8;
            // 
            // lbxOrderAmount
            // 
            this.lbxOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOrderAmount.FormattingEnabled = true;
            this.lbxOrderAmount.ItemHeight = 20;
            this.lbxOrderAmount.Location = new System.Drawing.Point(-1, 270);
            this.lbxOrderAmount.Name = "lbxOrderAmount";
            this.lbxOrderAmount.Size = new System.Drawing.Size(374, 64);
            this.lbxOrderAmount.TabIndex = 65;
            // 
            // lbxShoppingList
            // 
            this.lbxShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxShoppingList.FormattingEnabled = true;
            this.lbxShoppingList.ItemHeight = 20;
            this.lbxShoppingList.Location = new System.Drawing.Point(0, 37);
            this.lbxShoppingList.Name = "lbxShoppingList";
            this.lbxShoppingList.Size = new System.Drawing.Size(373, 224);
            this.lbxShoppingList.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "&Search:";
            // 
            // tboSearch
            // 
            this.tboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSearch.Location = new System.Drawing.Point(84, 60);
            this.tboSearch.Name = "tboSearch";
            this.tboSearch.Size = new System.Drawing.Size(168, 26);
            this.tboSearch.TabIndex = 13;
            this.tboSearch.Tag = "Search";
            this.tboSearch.TextChanged += new System.EventHandler(this.tboSearch_TextChanged);
            // 
            // priceRangeLabel
            // 
            this.priceRangeLabel.AutoSize = true;
            this.priceRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeLabel.Location = new System.Drawing.Point(88, 127);
            this.priceRangeLabel.Name = "priceRangeLabel";
            this.priceRangeLabel.Size = new System.Drawing.Size(96, 20);
            this.priceRangeLabel.TabIndex = 0;
            this.priceRangeLabel.Text = "Price &Range";
            // 
            // tboLowestDesired
            // 
            this.tboLowestDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboLowestDesired.Location = new System.Drawing.Point(44, 153);
            this.tboLowestDesired.Name = "tboLowestDesired";
            this.tboLowestDesired.Size = new System.Drawing.Size(77, 26);
            this.tboLowestDesired.TabIndex = 15;
            this.tboLowestDesired.Tag = "Lower Range";
            this.tboLowestDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboHighestDesired
            // 
            this.tboHighestDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboHighestDesired.Location = new System.Drawing.Point(154, 153);
            this.tboHighestDesired.Name = "tboHighestDesired";
            this.tboHighestDesired.Size = new System.Drawing.Size(77, 26);
            this.tboHighestDesired.TabIndex = 16;
            this.tboHighestDesired.Tag = "Higher Range";
            this.tboHighestDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "to";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tboSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Controls.Add(this.tboHighestDesired);
            this.panel2.Controls.Add(categoryLabel);
            this.panel2.Controls.Add(this.tboLowestDesired);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.priceRangeLabel);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 228);
            this.panel2.TabIndex = 17;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(98, 190);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 29);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filter Products";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "None",
            "Aluminum",
            "Clay",
            "Concrete",
            "Fiberglass",
            "Glass",
            "Plaster"});
            this.cboCategory.Location = new System.Drawing.Point(84, 92);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(168, 26);
            this.cboCategory.TabIndex = 11;
            this.cboCategory.Tag = "Category";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // numUDItemAmount
            // 
            this.numUDItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDItemAmount.Location = new System.Drawing.Point(903, 421);
            this.numUDItemAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDItemAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDItemAmount.Name = "numUDItemAmount";
            this.numUDItemAmount.Size = new System.Drawing.Size(58, 26);
            this.numUDItemAmount.TabIndex = 19;
            this.numUDItemAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(982, 403);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(170, 29);
            this.btnAddToCart.TabIndex = 18;
            this.btnAddToCart.Text = "&Add to Shopping Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddToWishList
            // 
            this.btnAddToWishList.Enabled = false;
            this.btnAddToWishList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToWishList.Location = new System.Drawing.Point(982, 438);
            this.btnAddToWishList.Name = "btnAddToWishList";
            this.btnAddToWishList.Size = new System.Drawing.Size(170, 29);
            this.btnAddToWishList.TabIndex = 20;
            this.btnAddToWishList.Text = "Add to a Wish &List";
            this.btnAddToWishList.UseVisualStyleBackColor = true;
            this.btnAddToWishList.Visible = false;
            // 
            // tboDescription
            // 
            this.tboDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboDescription.Location = new System.Drawing.Point(12, 399);
            this.tboDescription.Multiline = true;
            this.tboDescription.Name = "tboDescription";
            this.tboDescription.ReadOnly = true;
            this.tboDescription.Size = new System.Drawing.Size(269, 409);
            this.tboDescription.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 822);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "&Billing Option:";
            // 
            // cboBillingOptions
            // 
            this.cboBillingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBillingOptions.FormattingEnabled = true;
            this.cboBillingOptions.Items.AddRange(new object[] {
            "Select Billing Option..."});
            this.cboBillingOptions.Location = new System.Drawing.Point(202, 819);
            this.cboBillingOptions.Name = "cboBillingOptions";
            this.cboBillingOptions.Size = new System.Drawing.Size(547, 28);
            this.cboBillingOptions.TabIndex = 22;
            this.billingOptionsToolTip.SetToolTip(this.cboBillingOptions, "You can edit your billing options under profile in the top right.");
            this.cboBillingOptions.SelectedIndexChanged += new System.EventHandler(this.cboBillingOptions_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 854);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "&Shipping Information:";
            // 
            // cboShippingOptions
            // 
            this.cboShippingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShippingOptions.FormattingEnabled = true;
            this.cboShippingOptions.Items.AddRange(new object[] {
            "Select Shipping Option..."});
            this.cboShippingOptions.Location = new System.Drawing.Point(202, 851);
            this.cboShippingOptions.Name = "cboShippingOptions";
            this.cboShippingOptions.Size = new System.Drawing.Size(547, 28);
            this.cboShippingOptions.TabIndex = 24;
            // 
            // chkSameAs
            // 
            this.chkSameAs.AutoSize = true;
            this.chkSameAs.Enabled = false;
            this.chkSameAs.Location = new System.Drawing.Point(967, 859);
            this.chkSameAs.Name = "chkSameAs";
            this.chkSameAs.Size = new System.Drawing.Size(15, 14);
            this.chkSameAs.TabIndex = 26;
            this.chkSameAs.UseVisualStyleBackColor = true;
            this.chkSameAs.Visible = false;
            // 
            // lblSameAs
            // 
            this.lblSameAs.AutoSize = true;
            this.lblSameAs.Enabled = false;
            this.lblSameAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSameAs.Location = new System.Drawing.Point(755, 854);
            this.lblSameAs.Name = "lblSameAs";
            this.lblSameAs.Size = new System.Drawing.Size(206, 20);
            this.lblSameAs.TabIndex = 59;
            this.lblSameAs.Text = "Sa&me as Billing Information:";
            this.lblSameAs.Visible = false;
            // 
            // lbxProductLists
            // 
            this.lbxProductLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductLists.FormattingEnabled = true;
            this.lbxProductLists.ItemHeight = 20;
            this.lbxProductLists.Location = new System.Drawing.Point(288, 164);
            this.lbxProductLists.Name = "lbxProductLists";
            this.lbxProductLists.Size = new System.Drawing.Size(554, 644);
            this.lbxProductLists.TabIndex = 18;
            this.lbxProductLists.SelectedIndexChanged += new System.EventHandler(this.lbxProductLists_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Product ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Type of Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(731, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Price";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 893);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSameAs);
            this.Controls.Add(this.chkSameAs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboShippingOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboBillingOptions);
            this.Controls.Add(this.tboDescription);
            this.Controls.Add(this.btnAddToWishList);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.numUDItemAmount);
            this.Controls.Add(this.lbxProductLists);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.billingOptionsToolTip.SetToolTip(this, "Select a billing option here.. ");
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDItemAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem userIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWishList;
        private System.Windows.Forms.ToolStripMenuItem editWishListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblShoppingList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboSearch;
        private System.Windows.Forms.Label priceRangeLabel;
        private System.Windows.Forms.TextBox tboLowestDesired;
        private System.Windows.Forms.TextBox tboHighestDesired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.NumericUpDown numUDItemAmount;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddToWishList;
        private System.Windows.Forms.ToolStripMenuItem viewBillingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShippingInformationToolStripMenuItem;
        private System.Windows.Forms.TextBox tboDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBillingOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboShippingOptions;
        private System.Windows.Forms.CheckBox chkSameAs;
        private System.Windows.Forms.Label lblSameAs;
        private System.Windows.Forms.ListBox lbxProductLists;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lbxShoppingList;
        private System.Windows.Forms.ListBox lbxOrderAmount;
        private System.Windows.Forms.ToolStripMenuItem selectAWishlistBellowToLoadItToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip billingOptionsToolTip;
    }
}