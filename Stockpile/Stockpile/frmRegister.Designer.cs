namespace Stockpile
{
    partial class frmRegister
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
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.tboEmailConfirm = new System.Windows.Forms.TextBox();
            this.tboPassword = new System.Windows.Forms.TextBox();
            this.tboPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkTOS = new System.Windows.Forms.LinkLabel();
            this.chkTOS = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.tboUserID = new System.Windows.Forms.TextBox();
            this.tboFirstName = new System.Windows.Forms.TextBox();
            this.tboLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboEmail
            // 
            this.tboEmail.Location = new System.Drawing.Point(15, 118);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.Size = new System.Drawing.Size(227, 26);
            this.tboEmail.TabIndex = 4;
            this.tboEmail.Tag = "Email";
            // 
            // tboEmailConfirm
            // 
            this.tboEmailConfirm.Location = new System.Drawing.Point(15, 150);
            this.tboEmailConfirm.Name = "tboEmailConfirm";
            this.tboEmailConfirm.Size = new System.Drawing.Size(227, 26);
            this.tboEmailConfirm.TabIndex = 5;
            this.tboEmailConfirm.Tag = "Email Confirmation";
            // 
            // tboPassword
            // 
            this.tboPassword.Location = new System.Drawing.Point(15, 182);
            this.tboPassword.Name = "tboPassword";
            this.tboPassword.Size = new System.Drawing.Size(227, 26);
            this.tboPassword.TabIndex = 6;
            this.tboPassword.Tag = "Password";
            // 
            // tboPasswordConfirm
            // 
            this.tboPasswordConfirm.Location = new System.Drawing.Point(15, 214);
            this.tboPasswordConfirm.Name = "tboPasswordConfirm";
            this.tboPasswordConfirm.Size = new System.Drawing.Size(227, 26);
            this.tboPasswordConfirm.TabIndex = 7;
            this.tboPasswordConfirm.Tag = "Password Confirmation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email Confirmation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password Confirmation:";
            // 
            // linkTOS
            // 
            this.linkTOS.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkTOS.AutoSize = true;
            this.linkTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTOS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkTOS.Location = new System.Drawing.Point(239, 334);
            this.linkTOS.Name = "linkTOS";
            this.linkTOS.Size = new System.Drawing.Size(136, 20);
            this.linkTOS.TabIndex = 8;
            this.linkTOS.TabStop = true;
            this.linkTOS.Text = "Terms of Service?";
            this.linkTOS.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkTOS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTOS_LinkClicked);
            // 
            // chkTOS
            // 
            this.chkTOS.AutoSize = true;
            this.chkTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTOS.Location = new System.Drawing.Point(381, 338);
            this.chkTOS.Name = "chkTOS";
            this.chkTOS.Size = new System.Drawing.Size(15, 14);
            this.chkTOS.TabIndex = 9;
            this.chkTOS.Tag = "Terms of Service";
            this.chkTOS.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(156, 357);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 39);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(248, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Do you accept our";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.tboUserID);
            this.grpRegister.Controls.Add(this.tboEmail);
            this.grpRegister.Controls.Add(this.tboFirstName);
            this.grpRegister.Controls.Add(this.tboEmailConfirm);
            this.grpRegister.Controls.Add(this.tboPassword);
            this.grpRegister.Controls.Add(this.tboLastName);
            this.grpRegister.Controls.Add(this.tboPasswordConfirm);
            this.grpRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegister.Location = new System.Drawing.Point(203, 80);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(259, 251);
            this.grpRegister.TabIndex = 14;
            this.grpRegister.TabStop = false;
            // 
            // tboUserID
            // 
            this.tboUserID.Location = new System.Drawing.Point(15, 22);
            this.tboUserID.Name = "tboUserID";
            this.tboUserID.Size = new System.Drawing.Size(227, 26);
            this.tboUserID.TabIndex = 1;
            this.tboUserID.Tag = "User Name";
            // 
            // tboFirstName
            // 
            this.tboFirstName.Location = new System.Drawing.Point(15, 54);
            this.tboFirstName.Name = "tboFirstName";
            this.tboFirstName.Size = new System.Drawing.Size(227, 26);
            this.tboFirstName.TabIndex = 2;
            this.tboFirstName.Tag = "First Name";
            // 
            // tboLastName
            // 
            this.tboLastName.Location = new System.Drawing.Point(15, 86);
            this.tboLastName.Name = "tboLastName";
            this.tboLastName.Size = new System.Drawing.Size(227, 26);
            this.tboLastName.TabIndex = 3;
            this.tboLastName.Tag = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "User Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Last Name:";
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.chkTOS);
            this.Controls.Add(this.linkTOS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRegister);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.TextBox tboEmailConfirm;
        private System.Windows.Forms.TextBox tboPassword;
        private System.Windows.Forms.TextBox tboPasswordConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkTOS;
        private System.Windows.Forms.CheckBox chkTOS;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.TextBox tboUserID;
        private System.Windows.Forms.TextBox tboFirstName;
        private System.Windows.Forms.TextBox tboLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}