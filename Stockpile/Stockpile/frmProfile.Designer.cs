namespace Stockpile
{
    partial class frmProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHomePhoneNumber = new System.Windows.Forms.Label();
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.tboHomePhone = new System.Windows.Forms.TextBox();
            this.tboFullName = new System.Windows.Forms.TextBox();
            this.tboUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboMobilePhone = new System.Windows.Forms.TextBox();
            this.lblMobilePhoneNumber = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 103);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROFILE";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainPageToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(293, 9);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(157, 29);
            this.mainMenuStrip.TabIndex = 5;
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
            this.toolStripContainer1.Location = new System.Drawing.Point(196, 13);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(158, 21);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(138, 314);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(138, 351);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblHomePhoneNumber
            // 
            this.lblHomePhoneNumber.AutoSize = true;
            this.lblHomePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePhoneNumber.Location = new System.Drawing.Point(27, 385);
            this.lblHomePhoneNumber.Name = "lblHomePhoneNumber";
            this.lblHomePhoneNumber.Size = new System.Drawing.Size(166, 20);
            this.lblHomePhoneNumber.TabIndex = 10;
            this.lblHomePhoneNumber.Text = "Home Phone Number:";
            // 
            // tboEmail
            // 
            this.tboEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEmail.Location = new System.Drawing.Point(199, 348);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.ReadOnly = true;
            this.tboEmail.Size = new System.Drawing.Size(249, 26);
            this.tboEmail.TabIndex = 2;
            this.tboEmail.TabStop = false;
            this.tboEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboHomePhone
            // 
            this.tboHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboHomePhone.Location = new System.Drawing.Point(199, 382);
            this.tboHomePhone.Name = "tboHomePhone";
            this.tboHomePhone.ReadOnly = true;
            this.tboHomePhone.Size = new System.Drawing.Size(249, 26);
            this.tboHomePhone.TabIndex = 3;
            this.tboHomePhone.TabStop = false;
            this.tboHomePhone.Tag = "Home Phone";
            this.tboHomePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboFullName
            // 
            this.tboFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboFullName.Location = new System.Drawing.Point(199, 311);
            this.tboFullName.Name = "tboFullName";
            this.tboFullName.ReadOnly = true;
            this.tboFullName.Size = new System.Drawing.Size(249, 26);
            this.tboFullName.TabIndex = 1;
            this.tboFullName.TabStop = false;
            this.tboFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboUserName
            // 
            this.tboUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboUserName.Location = new System.Drawing.Point(199, 279);
            this.tboUserName.Name = "tboUserName";
            this.tboUserName.ReadOnly = true;
            this.tboUserName.Size = new System.Drawing.Size(249, 26);
            this.tboUserName.TabIndex = 0;
            this.tboUserName.TabStop = false;
            this.tboUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "User Name:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(374, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 27);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(293, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboMobilePhone
            // 
            this.tboMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboMobilePhone.Location = new System.Drawing.Point(199, 414);
            this.tboMobilePhone.Name = "tboMobilePhone";
            this.tboMobilePhone.ReadOnly = true;
            this.tboMobilePhone.Size = new System.Drawing.Size(249, 26);
            this.tboMobilePhone.TabIndex = 4;
            this.tboMobilePhone.TabStop = false;
            this.tboMobilePhone.Tag = "Mobile Phone";
            this.tboMobilePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMobilePhoneNumber
            // 
            this.lblMobilePhoneNumber.AutoSize = true;
            this.lblMobilePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobilePhoneNumber.Location = new System.Drawing.Point(24, 414);
            this.lblMobilePhoneNumber.Name = "lblMobilePhoneNumber";
            this.lblMobilePhoneNumber.Size = new System.Drawing.Size(169, 20);
            this.lblMobilePhoneNumber.TabIndex = 20;
            this.lblMobilePhoneNumber.Text = "Mobile Phone Number:";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 482);
            this.ControlBox = false;
            this.Controls.Add(this.tboMobilePhone);
            this.Controls.Add(this.lblMobilePhoneNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tboUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboFullName);
            this.Controls.Add(this.tboHomePhone);
            this.Controls.Add(this.tboEmail);
            this.Controls.Add(this.lblHomePhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label1);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHomePhoneNumber;
        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.TextBox tboHomePhone;
        private System.Windows.Forms.TextBox tboFullName;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
        private System.Windows.Forms.TextBox tboUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboMobilePhone;
        private System.Windows.Forms.Label lblMobilePhoneNumber;
    }
}