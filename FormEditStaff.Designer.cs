namespace ProjectHotel_UAS_PAD
{
    partial class FormEditStaff
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
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.cbox_isManager = new System.Windows.Forms.CheckBox();
            this.cbox_updStatus = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.AllowUserToResizeColumns = false;
            this.dgv_staff.AllowUserToResizeRows = false;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.EnableHeadersVisualStyles = false;
            this.dgv_staff.Location = new System.Drawing.Point(12, 12);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(1167, 265);
            this.dgv_staff.TabIndex = 0;
            this.dgv_staff.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentDoubleClick);
            // 
            // cbox_isManager
            // 
            this.cbox_isManager.AutoSize = true;
            this.cbox_isManager.Location = new System.Drawing.Point(258, 459);
            this.cbox_isManager.Name = "cbox_isManager";
            this.cbox_isManager.Size = new System.Drawing.Size(96, 20);
            this.cbox_isManager.TabIndex = 16;
            this.cbox_isManager.Text = "Is Manager";
            this.cbox_isManager.UseVisualStyleBackColor = true;
            // 
            // cbox_updStatus
            // 
            this.cbox_updStatus.AutoSize = true;
            this.cbox_updStatus.Location = new System.Drawing.Point(131, 459);
            this.cbox_updStatus.Name = "cbox_updStatus";
            this.cbox_updStatus.Size = new System.Drawing.Size(79, 20);
            this.cbox_updStatus.TabIndex = 15;
            this.cbox_updStatus.Text = "Is Active";
            this.cbox_updStatus.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(131, 485);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(142, 27);
            this.Submit.TabIndex = 31;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(115, 434);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = ":";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(131, 431);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(288, 22);
            this.textPhone.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 434);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(115, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = ":";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(131, 403);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(288, 22);
            this.textEmail.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = ":";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(131, 375);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(288, 22);
            this.textName.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = ":";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(131, 347);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(288, 22);
            this.textPassword.TabIndex = 20;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(131, 319);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(288, 22);
            this.textUsername.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(279, 485);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(140, 27);
            this.Update.TabIndex = 32;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "label1";
            // 
            // FormEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbox_isManager);
            this.Controls.Add(this.cbox_updStatus);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label16);
            this.Name = "FormEditStaff";
            this.Text = "FormEditStaff";
            this.Load += new System.EventHandler(this.FormEditStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbox_isManager;
        private System.Windows.Forms.CheckBox cbox_updStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
    }
}