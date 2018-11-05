namespace HotelApp
{
    partial class frmGuestProfile
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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.txtRoomTitle = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdUpdateeBooking = new System.Windows.Forms.Button();
            this.cmdDeleteBooking = new System.Windows.Forms.Button();
            this.cmdPayBooking = new System.Windows.Forms.Button();
            this.cmdDeleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(72, 255);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(115, 23);
            this.cmdUpdate.TabIndex = 44;
            this.cmdUpdate.Text = "Update guest info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Guest ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 213);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(209, 20);
            this.txtPhone.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 37;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(109, 136);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(209, 20);
            this.txtGuestID.TabIndex = 36;
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(233, 81);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(64, 21);
            this.cmdRegister.TabIndex = 35;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click_1);
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.Location = new System.Drawing.Point(144, 81);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(64, 21);
            this.cmdLogIn.TabIndex = 34;
            this.cmdLogIn.Text = "Log in";
            this.cmdLogIn.UseVisualStyleBackColor = true;
            this.cmdLogIn.Click += new System.EventHandler(this.cmdLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Guest email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 32;
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.Location = new System.Drawing.Point(37, 330);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(171, 212);
            this.lstBookings.TabIndex = 45;
            this.lstBookings.SelectedIndexChanged += new System.EventHandler(this.lstBookings_SelectedIndexChanged);
            // 
            // txtRoomTitle
            // 
            this.txtRoomTitle.Location = new System.Drawing.Point(286, 341);
            this.txtRoomTitle.Name = "txtRoomTitle";
            this.txtRoomTitle.Size = new System.Drawing.Size(124, 20);
            this.txtRoomTitle.TabIndex = 46;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(286, 367);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(124, 20);
            this.txtStartDate.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(286, 419);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 48;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(286, 393);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(124, 20);
            this.txtEndDate.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Start date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "End date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Price";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(321, 449);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(89, 20);
            this.txtInvoiceID.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Invoice ID";
            // 
            // cmdUpdateeBooking
            // 
            this.cmdUpdateeBooking.Location = new System.Drawing.Point(233, 490);
            this.cmdUpdateeBooking.Name = "cmdUpdateeBooking";
            this.cmdUpdateeBooking.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateeBooking.TabIndex = 56;
            this.cmdUpdateeBooking.Text = "Update";
            this.cmdUpdateeBooking.UseVisualStyleBackColor = true;
            this.cmdUpdateeBooking.Click += new System.EventHandler(this.cmdUpdateeBooking_Click);
            // 
            // cmdDeleteBooking
            // 
            this.cmdDeleteBooking.Location = new System.Drawing.Point(321, 490);
            this.cmdDeleteBooking.Name = "cmdDeleteBooking";
            this.cmdDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteBooking.TabIndex = 57;
            this.cmdDeleteBooking.Text = "Delete";
            this.cmdDeleteBooking.UseVisualStyleBackColor = true;
            this.cmdDeleteBooking.Click += new System.EventHandler(this.cmdDeleteBooking_Click);
            // 
            // cmdPayBooking
            // 
            this.cmdPayBooking.Location = new System.Drawing.Point(275, 519);
            this.cmdPayBooking.Name = "cmdPayBooking";
            this.cmdPayBooking.Size = new System.Drawing.Size(75, 23);
            this.cmdPayBooking.TabIndex = 58;
            this.cmdPayBooking.Text = "Pay";
            this.cmdPayBooking.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteAccount
            // 
            this.cmdDeleteAccount.Location = new System.Drawing.Point(193, 255);
            this.cmdDeleteAccount.Name = "cmdDeleteAccount";
            this.cmdDeleteAccount.Size = new System.Drawing.Size(115, 23);
            this.cmdDeleteAccount.TabIndex = 59;
            this.cmdDeleteAccount.Text = "Delete account";
            this.cmdDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // frmGuestProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 572);
            this.Controls.Add(this.cmdDeleteAccount);
            this.Controls.Add(this.cmdPayBooking);
            this.Controls.Add(this.cmdDeleteBooking);
            this.Controls.Add(this.cmdUpdateeBooking);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtRoomTitle);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmGuestProfile";
            this.Text = "frmGuestProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Button cmdLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.TextBox txtRoomTitle;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdUpdateeBooking;
        private System.Windows.Forms.Button cmdDeleteBooking;
        private System.Windows.Forms.Button cmdPayBooking;
        private System.Windows.Forms.Button cmdDeleteAccount;
    }
}