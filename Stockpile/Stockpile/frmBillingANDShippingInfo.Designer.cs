namespace Stockpile
{
    partial class frmBillingANDShippingInfo
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cboBillingOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewBilling = new System.Windows.Forms.Button();
            this.btnEditBilling = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboShippingOptions = new System.Windows.Forms.ComboBox();
            this.btnSaveBilling = new System.Windows.Forms.Button();
            this.btnSaveShipping = new System.Windows.Forms.Button();
            this.btnEditShipping = new System.Windows.Forms.Button();
            this.btnNewShipping = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboSecurityCard = new System.Windows.Forms.TextBox();
            this.tabControlBilling = new System.Windows.Forms.TabControl();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tboBillingZipcode = new System.Windows.Forms.MaskedTextBox();
            this.tboCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.tboExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.cboBillingStates = new System.Windows.Forms.ComboBox();
            this.tboCardType = new System.Windows.Forms.TextBox();
            this.tboBillingState = new System.Windows.Forms.TextBox();
            this.tboBillingCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboBillingAddrO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboBillingAddr = new System.Windows.Forms.TextBox();
            this.tabShipping = new System.Windows.Forms.TabPage();
            this.tboShippingZipcode = new System.Windows.Forms.MaskedTextBox();
            this.cboShippingStates = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tboStateShipping = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboCityShipping = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tboShippingAddrO = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tboShippingAdr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControlBilling.SuspendLayout();
            this.tabBilling.SuspendLayout();
            this.tabShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainPageToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(717, 9);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(157, 29);
            this.mainMenuStrip.TabIndex = 14;
            // 
            // backToMainPageToolStripMenuItem
            // 
            this.backToMainPageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainPageToolStripMenuItem.Name = "backToMainPageToolStripMenuItem";
            this.backToMainPageToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.backToMainPageToolStripMenuItem.Text = "Back To Main Page";
            this.backToMainPageToolStripMenuItem.Click += new System.EventHandler(this.backToMainPageToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(158, 0);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(797, 13);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // cboBillingOptions
            // 
            this.cboBillingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBillingOptions.FormattingEnabled = true;
            this.cboBillingOptions.Items.AddRange(new object[] {
            "Select a Billing Option to Edit..."});
            this.cboBillingOptions.Location = new System.Drawing.Point(221, 11);
            this.cboBillingOptions.Name = "cboBillingOptions";
            this.cboBillingOptions.Size = new System.Drawing.Size(341, 28);
            this.cboBillingOptions.TabIndex = 1;
            this.cboBillingOptions.Tag = "Billing Options";
            this.cboBillingOptions.SelectedIndexChanged += new System.EventHandler(this.cboBillingOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Saved Billing Options:";
            // 
            // btnNewBilling
            // 
            this.btnNewBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBilling.Location = new System.Drawing.Point(568, 11);
            this.btnNewBilling.Name = "btnNewBilling";
            this.btnNewBilling.Size = new System.Drawing.Size(75, 29);
            this.btnNewBilling.TabIndex = 2;
            this.btnNewBilling.Text = "&New";
            this.btnNewBilling.UseVisualStyleBackColor = true;
            this.btnNewBilling.Click += new System.EventHandler(this.btnNewBilling_Click);
            // 
            // btnEditBilling
            // 
            this.btnEditBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBilling.Location = new System.Drawing.Point(649, 11);
            this.btnEditBilling.Name = "btnEditBilling";
            this.btnEditBilling.Size = new System.Drawing.Size(75, 29);
            this.btnEditBilling.TabIndex = 3;
            this.btnEditBilling.Text = "&Edit";
            this.btnEditBilling.UseVisualStyleBackColor = true;
            this.btnEditBilling.Click += new System.EventHandler(this.btnEditBilling_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "&Saved Shipping Information:";
            // 
            // cboShippingOptions
            // 
            this.cboShippingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShippingOptions.FormattingEnabled = true;
            this.cboShippingOptions.Items.AddRange(new object[] {
            "Select a Shipping Option to Edit..."});
            this.cboShippingOptions.Location = new System.Drawing.Point(231, 23);
            this.cboShippingOptions.Name = "cboShippingOptions";
            this.cboShippingOptions.Size = new System.Drawing.Size(341, 28);
            this.cboShippingOptions.TabIndex = 1;
            this.cboShippingOptions.Tag = "Shipping Information";
            this.cboShippingOptions.SelectedIndexChanged += new System.EventHandler(this.cboShippingOptions_SelectedIndexChanged);
            // 
            // btnSaveBilling
            // 
            this.btnSaveBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBilling.Location = new System.Drawing.Point(730, 11);
            this.btnSaveBilling.Name = "btnSaveBilling";
            this.btnSaveBilling.Size = new System.Drawing.Size(75, 29);
            this.btnSaveBilling.TabIndex = 4;
            this.btnSaveBilling.Text = "&Save";
            this.btnSaveBilling.UseVisualStyleBackColor = true;
            this.btnSaveBilling.Visible = false;
            this.btnSaveBilling.Click += new System.EventHandler(this.btnSaveBilling_Click);
            // 
            // btnSaveShipping
            // 
            this.btnSaveShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveShipping.Location = new System.Drawing.Point(773, 23);
            this.btnSaveShipping.Name = "btnSaveShipping";
            this.btnSaveShipping.Size = new System.Drawing.Size(75, 29);
            this.btnSaveShipping.TabIndex = 4;
            this.btnSaveShipping.Text = "&Save";
            this.btnSaveShipping.UseVisualStyleBackColor = true;
            this.btnSaveShipping.Visible = false;
            this.btnSaveShipping.Click += new System.EventHandler(this.btnSaveShipping_Click);
            // 
            // btnEditShipping
            // 
            this.btnEditShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShipping.Location = new System.Drawing.Point(692, 23);
            this.btnEditShipping.Name = "btnEditShipping";
            this.btnEditShipping.Size = new System.Drawing.Size(75, 29);
            this.btnEditShipping.TabIndex = 3;
            this.btnEditShipping.Text = "&Edit";
            this.btnEditShipping.UseVisualStyleBackColor = true;
            this.btnEditShipping.Click += new System.EventHandler(this.btnEditShipping_Click);
            // 
            // btnNewShipping
            // 
            this.btnNewShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewShipping.Location = new System.Drawing.Point(611, 23);
            this.btnNewShipping.Name = "btnNewShipping";
            this.btnNewShipping.Size = new System.Drawing.Size(75, 29);
            this.btnNewShipping.TabIndex = 2;
            this.btnNewShipping.Text = "&New";
            this.btnNewShipping.UseVisualStyleBackColor = true;
            this.btnNewShipping.Click += new System.EventHandler(this.btnNewShipping_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Card &Type:";
            // 
            // cboCardType
            // 
            this.cboCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Location = new System.Drawing.Point(221, 45);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(163, 28);
            this.cboCardType.TabIndex = 5;
            this.cboCardType.Tag = "Card Type";
            this.cboCardType.Visible = false;
            this.cboCardType.SelectedIndexChanged += new System.EventHandler(this.cboCardType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Card &Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "E&xperation Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sec&urity Code:";
            // 
            // tboSecurityCard
            // 
            this.tboSecurityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSecurityCard.Location = new System.Drawing.Point(221, 143);
            this.tboSecurityCard.Name = "tboSecurityCard";
            this.tboSecurityCard.PasswordChar = '*';
            this.tboSecurityCard.ReadOnly = true;
            this.tboSecurityCard.Size = new System.Drawing.Size(84, 26);
            this.tboSecurityCard.TabIndex = 8;
            this.tboSecurityCard.TabStop = false;
            this.tboSecurityCard.Tag = "Security Code";
            // 
            // tabControlBilling
            // 
            this.tabControlBilling.Controls.Add(this.tabBilling);
            this.tabControlBilling.Controls.Add(this.tabShipping);
            this.tabControlBilling.HotTrack = true;
            this.tabControlBilling.Location = new System.Drawing.Point(-4, 178);
            this.tabControlBilling.Name = "tabControlBilling";
            this.tabControlBilling.SelectedIndex = 0;
            this.tabControlBilling.Size = new System.Drawing.Size(891, 421);
            this.tabControlBilling.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlBilling.TabIndex = 0;
            // 
            // tabBilling
            // 
            this.tabBilling.BackColor = System.Drawing.SystemColors.Control;
            this.tabBilling.Controls.Add(this.tboBillingZipcode);
            this.tabBilling.Controls.Add(this.tboCardNumber);
            this.tabBilling.Controls.Add(this.tboExpirationDate);
            this.tabBilling.Controls.Add(this.cboBillingStates);
            this.tabBilling.Controls.Add(this.tboCardType);
            this.tabBilling.Controls.Add(this.tboBillingState);
            this.tabBilling.Controls.Add(this.tboBillingCity);
            this.tabBilling.Controls.Add(this.label11);
            this.tabBilling.Controls.Add(this.label10);
            this.tabBilling.Controls.Add(this.label9);
            this.tabBilling.Controls.Add(this.label8);
            this.tabBilling.Controls.Add(this.tboBillingAddrO);
            this.tabBilling.Controls.Add(this.label7);
            this.tabBilling.Controls.Add(this.tboBillingAddr);
            this.tabBilling.Controls.Add(this.label1);
            this.tabBilling.Controls.Add(this.label6);
            this.tabBilling.Controls.Add(this.cboBillingOptions);
            this.tabBilling.Controls.Add(this.tboSecurityCard);
            this.tabBilling.Controls.Add(this.btnNewBilling);
            this.tabBilling.Controls.Add(this.label5);
            this.tabBilling.Controls.Add(this.btnEditBilling);
            this.tabBilling.Controls.Add(this.btnSaveBilling);
            this.tabBilling.Controls.Add(this.label4);
            this.tabBilling.Controls.Add(this.cboCardType);
            this.tabBilling.Controls.Add(this.label3);
            this.tabBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBilling.Location = new System.Drawing.Point(4, 22);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Padding = new System.Windows.Forms.Padding(3);
            this.tabBilling.Size = new System.Drawing.Size(883, 395);
            this.tabBilling.TabIndex = 0;
            this.tabBilling.Text = "Billing Information";
            // 
            // tboBillingZipcode
            // 
            this.tboBillingZipcode.Location = new System.Drawing.Point(221, 318);
            this.tboBillingZipcode.Mask = "00000";
            this.tboBillingZipcode.Name = "tboBillingZipcode";
            this.tboBillingZipcode.ReadOnly = true;
            this.tboBillingZipcode.Size = new System.Drawing.Size(84, 26);
            this.tboBillingZipcode.TabIndex = 13;
            this.tboBillingZipcode.Tag = "Zip-Code";
            // 
            // tboCardNumber
            // 
            this.tboCardNumber.Location = new System.Drawing.Point(221, 79);
            this.tboCardNumber.Mask = "0000-0000-0000-0000";
            this.tboCardNumber.Name = "tboCardNumber";
            this.tboCardNumber.ReadOnly = true;
            this.tboCardNumber.Size = new System.Drawing.Size(341, 26);
            this.tboCardNumber.TabIndex = 6;
            this.tboCardNumber.TabStop = false;
            this.tboCardNumber.Tag = "Card Number";
            this.tboCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboCardNumber_KeyDown);
            // 
            // tboExpirationDate
            // 
            this.tboExpirationDate.Location = new System.Drawing.Point(221, 111);
            this.tboExpirationDate.Mask = "00/00";
            this.tboExpirationDate.Name = "tboExpirationDate";
            this.tboExpirationDate.ReadOnly = true;
            this.tboExpirationDate.Size = new System.Drawing.Size(84, 26);
            this.tboExpirationDate.TabIndex = 7;
            this.tboExpirationDate.Tag = "Expiration Date";
            // 
            // cboBillingStates
            // 
            this.cboBillingStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboBillingStates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBillingStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBillingStates.FormattingEnabled = true;
            this.cboBillingStates.Location = new System.Drawing.Point(221, 289);
            this.cboBillingStates.Name = "cboBillingStates";
            this.cboBillingStates.Size = new System.Drawing.Size(185, 28);
            this.cboBillingStates.TabIndex = 12;
            this.cboBillingStates.Tag = "State";
            this.cboBillingStates.Visible = false;
            this.cboBillingStates.SelectedIndexChanged += new System.EventHandler(this.cboBillingStates_SelectedIndexChanged);
            // 
            // tboCardType
            // 
            this.tboCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboCardType.Location = new System.Drawing.Point(221, 46);
            this.tboCardType.Name = "tboCardType";
            this.tboCardType.ReadOnly = true;
            this.tboCardType.Size = new System.Drawing.Size(163, 26);
            this.tboCardType.TabIndex = 5;
            this.tboCardType.TabStop = false;
            // 
            // tboBillingState
            // 
            this.tboBillingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBillingState.Location = new System.Drawing.Point(221, 289);
            this.tboBillingState.Name = "tboBillingState";
            this.tboBillingState.ReadOnly = true;
            this.tboBillingState.Size = new System.Drawing.Size(185, 26);
            this.tboBillingState.TabIndex = 12;
            this.tboBillingState.TabStop = false;
            // 
            // tboBillingCity
            // 
            this.tboBillingCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBillingCity.Location = new System.Drawing.Point(221, 257);
            this.tboBillingCity.MaxLength = 25;
            this.tboBillingCity.Name = "tboBillingCity";
            this.tboBillingCity.ReadOnly = true;
            this.tboBillingCity.Size = new System.Drawing.Size(185, 26);
            this.tboBillingCity.TabIndex = 11;
            this.tboBillingCity.TabStop = false;
            this.tboBillingCity.Tag = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "&Zip-Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "S&tate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "&City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "&Billing Address 2 (Optional):";
            // 
            // tboBillingAddrO
            // 
            this.tboBillingAddrO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBillingAddrO.Location = new System.Drawing.Point(221, 224);
            this.tboBillingAddrO.MaxLength = 50;
            this.tboBillingAddrO.Name = "tboBillingAddrO";
            this.tboBillingAddrO.ReadOnly = true;
            this.tboBillingAddrO.Size = new System.Drawing.Size(341, 26);
            this.tboBillingAddrO.TabIndex = 10;
            this.tboBillingAddrO.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "&Billing Address 1:";
            // 
            // tboBillingAddr
            // 
            this.tboBillingAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBillingAddr.Location = new System.Drawing.Point(221, 193);
            this.tboBillingAddr.MaxLength = 50;
            this.tboBillingAddr.Name = "tboBillingAddr";
            this.tboBillingAddr.ReadOnly = true;
            this.tboBillingAddr.Size = new System.Drawing.Size(341, 26);
            this.tboBillingAddr.TabIndex = 9;
            this.tboBillingAddr.TabStop = false;
            this.tboBillingAddr.Tag = "Billing Address 1";
            // 
            // tabShipping
            // 
            this.tabShipping.BackColor = System.Drawing.SystemColors.Control;
            this.tabShipping.Controls.Add(this.tboShippingZipcode);
            this.tabShipping.Controls.Add(this.cboShippingStates);
            this.tabShipping.Controls.Add(this.label12);
            this.tabShipping.Controls.Add(this.label13);
            this.tabShipping.Controls.Add(this.tboStateShipping);
            this.tabShipping.Controls.Add(this.label14);
            this.tabShipping.Controls.Add(this.tboCityShipping);
            this.tabShipping.Controls.Add(this.label15);
            this.tabShipping.Controls.Add(this.tboShippingAddrO);
            this.tabShipping.Controls.Add(this.label16);
            this.tabShipping.Controls.Add(this.tboShippingAdr);
            this.tabShipping.Controls.Add(this.label2);
            this.tabShipping.Controls.Add(this.btnSaveShipping);
            this.tabShipping.Controls.Add(this.cboShippingOptions);
            this.tabShipping.Controls.Add(this.btnEditShipping);
            this.tabShipping.Controls.Add(this.btnNewShipping);
            this.tabShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShipping.Location = new System.Drawing.Point(4, 22);
            this.tabShipping.Name = "tabShipping";
            this.tabShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabShipping.Size = new System.Drawing.Size(883, 395);
            this.tabShipping.TabIndex = 1;
            this.tabShipping.Text = "Shipping Information";
            // 
            // tboShippingZipcode
            // 
            this.tboShippingZipcode.Location = new System.Drawing.Point(231, 187);
            this.tboShippingZipcode.Mask = "00000";
            this.tboShippingZipcode.Name = "tboShippingZipcode";
            this.tboShippingZipcode.ReadOnly = true;
            this.tboShippingZipcode.Size = new System.Drawing.Size(93, 26);
            this.tboShippingZipcode.TabIndex = 9;
            this.tboShippingZipcode.Tag = "Zip-Code";
            // 
            // cboShippingStates
            // 
            this.cboShippingStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboShippingStates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboShippingStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShippingStates.FormattingEnabled = true;
            this.cboShippingStates.ItemHeight = 20;
            this.cboShippingStates.Location = new System.Drawing.Point(231, 155);
            this.cboShippingStates.Name = "cboShippingStates";
            this.cboShippingStates.Size = new System.Drawing.Size(185, 28);
            this.cboShippingStates.TabIndex = 8;
            this.cboShippingStates.Tag = "State";
            this.cboShippingStates.Visible = false;
            this.cboShippingStates.SelectedIndexChanged += new System.EventHandler(this.cboShippingStates_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "&Zip-Code:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(173, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "S&tate:";
            // 
            // tboStateShipping
            // 
            this.tboStateShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboStateShipping.Location = new System.Drawing.Point(231, 155);
            this.tboStateShipping.Name = "tboStateShipping";
            this.tboStateShipping.ReadOnly = true;
            this.tboStateShipping.Size = new System.Drawing.Size(185, 26);
            this.tboStateShipping.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(186, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "&City:";
            // 
            // tboCityShipping
            // 
            this.tboCityShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboCityShipping.Location = new System.Drawing.Point(231, 123);
            this.tboCityShipping.Name = "tboCityShipping";
            this.tboCityShipping.ReadOnly = true;
            this.tboCityShipping.Size = new System.Drawing.Size(185, 26);
            this.tboCityShipping.TabIndex = 7;
            this.tboCityShipping.Tag = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "S&hipping Address 2 (Optional):";
            // 
            // tboShippingAddrO
            // 
            this.tboShippingAddrO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboShippingAddrO.Location = new System.Drawing.Point(231, 90);
            this.tboShippingAddrO.Name = "tboShippingAddrO";
            this.tboShippingAddrO.ReadOnly = true;
            this.tboShippingAddrO.Size = new System.Drawing.Size(341, 26);
            this.tboShippingAddrO.TabIndex = 6;
            this.tboShippingAddrO.Tag = "Shipping Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "S&hipping Address 1:";
            // 
            // tboShippingAdr
            // 
            this.tboShippingAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboShippingAdr.Location = new System.Drawing.Point(231, 59);
            this.tboShippingAdr.Name = "tboShippingAdr";
            this.tboShippingAdr.ReadOnly = true;
            this.tboShippingAdr.Size = new System.Drawing.Size(341, 26);
            this.tboShippingAdr.TabIndex = 5;
            this.tboShippingAdr.Tag = "Shipping Address 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(32, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(812, 103);
            this.label18.TabIndex = 38;
            this.label18.Text = "BILLING && SHIPPING INFORMATION";
            // 
            // frmBillingANDShippingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 599);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tabControlBilling);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmBillingANDShippingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBillingANDShippingInfo_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControlBilling.ResumeLayout(false);
            this.tabBilling.ResumeLayout(false);
            this.tabBilling.PerformLayout();
            this.tabShipping.ResumeLayout(false);
            this.tabShipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ComboBox cboBillingOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewBilling;
        private System.Windows.Forms.Button btnEditBilling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboShippingOptions;
        private System.Windows.Forms.Button btnSaveBilling;
        private System.Windows.Forms.Button btnSaveShipping;
        private System.Windows.Forms.Button btnEditShipping;
        private System.Windows.Forms.Button btnNewShipping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboSecurityCard;
        private System.Windows.Forms.TabControl tabControlBilling;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.TabPage tabShipping;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboBillingAddrO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboBillingAddr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboStateShipping;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tboCityShipping;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tboShippingAddrO;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tboShippingAdr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tboBillingState;
        private System.Windows.Forms.TextBox tboBillingCity;
        private System.Windows.Forms.TextBox tboCardType;
        private System.Windows.Forms.ComboBox cboBillingStates;
        private System.Windows.Forms.ComboBox cboShippingStates;
        private System.Windows.Forms.MaskedTextBox tboExpirationDate;
        private System.Windows.Forms.MaskedTextBox tboCardNumber;
        private System.Windows.Forms.MaskedTextBox tboBillingZipcode;
        private System.Windows.Forms.MaskedTextBox tboShippingZipcode;
    }
}