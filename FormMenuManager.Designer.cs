namespace ProjectHotel_UAS_PAD
{
    partial class FormMenuManager
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_transLog = new System.Windows.Forms.Button();
            this.btn_formEditStaff = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.btn_editFacilities = new System.Windows.Forms.Button();
            this.btn_editVouchers = new System.Windows.Forms.Button();
            this.btn_editFines = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 501);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(505, 67);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_transLog
            // 
            this.btn_transLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transLog.Location = new System.Drawing.Point(12, 428);
            this.btn_transLog.Name = "btn_transLog";
            this.btn_transLog.Size = new System.Drawing.Size(505, 67);
            this.btn_transLog.TabIndex = 7;
            this.btn_transLog.Text = "Transaction Logs";
            this.btn_transLog.UseVisualStyleBackColor = true;
            this.btn_transLog.Click += new System.EventHandler(this.btn_transLog_Click);
            // 
            // btn_formEditStaff
            // 
            this.btn_formEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formEditStaff.Location = new System.Drawing.Point(12, 136);
            this.btn_formEditStaff.Name = "btn_formEditStaff";
            this.btn_formEditStaff.Size = new System.Drawing.Size(505, 67);
            this.btn_formEditStaff.TabIndex = 6;
            this.btn_formEditStaff.Text = "Staff Master";
            this.btn_formEditStaff.UseVisualStyleBackColor = true;
            this.btn_formEditStaff.Click += new System.EventHandler(this.btn_formEditStaff_Click);
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(12, 9);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(228, 32);
            this.lbl_staffName.TabIndex = 9;
            this.lbl_staffName.Text = "Welcome back, ";
            // 
            // btn_editFacilities
            // 
            this.btn_editFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editFacilities.Location = new System.Drawing.Point(12, 209);
            this.btn_editFacilities.Name = "btn_editFacilities";
            this.btn_editFacilities.Size = new System.Drawing.Size(505, 67);
            this.btn_editFacilities.TabIndex = 10;
            this.btn_editFacilities.Text = "Facilities Master";
            this.btn_editFacilities.UseVisualStyleBackColor = true;
            this.btn_editFacilities.Click += new System.EventHandler(this.btn_editFacilities_Click);
            // 
            // btn_editVouchers
            // 
            this.btn_editVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editVouchers.Location = new System.Drawing.Point(12, 282);
            this.btn_editVouchers.Name = "btn_editVouchers";
            this.btn_editVouchers.Size = new System.Drawing.Size(505, 67);
            this.btn_editVouchers.TabIndex = 11;
            this.btn_editVouchers.Text = "Vouchers Master";
            this.btn_editVouchers.UseVisualStyleBackColor = true;
            this.btn_editVouchers.Click += new System.EventHandler(this.btn_editVouchers_Click);
            // 
            // btn_editFines
            // 
            this.btn_editFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editFines.Location = new System.Drawing.Point(12, 355);
            this.btn_editFines.Name = "btn_editFines";
            this.btn_editFines.Size = new System.Drawing.Size(505, 67);
            this.btn_editFines.TabIndex = 12;
            this.btn_editFines.Text = "Fines Master";
            this.btn_editFines.UseVisualStyleBackColor = true;
            this.btn_editFines.Click += new System.EventHandler(this.btn_editFines_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 67);
            this.button1.TabIndex = 13;
            this.button1.Text = "Room Master";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_editFines);
            this.Controls.Add(this.btn_editVouchers);
            this.Controls.Add(this.btn_editFacilities);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_transLog);
            this.Controls.Add(this.btn_formEditStaff);
            this.Name = "FormMenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_transLog;
        private System.Windows.Forms.Button btn_formEditStaff;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Button btn_editFacilities;
        private System.Windows.Forms.Button btn_editVouchers;
        private System.Windows.Forms.Button btn_editFines;
        private System.Windows.Forms.Button button1;
    }
}