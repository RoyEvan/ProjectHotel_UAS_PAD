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
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 251);
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
            this.btn_transLog.Location = new System.Drawing.Point(12, 178);
            this.btn_transLog.Name = "btn_transLog";
            this.btn_transLog.Size = new System.Drawing.Size(505, 67);
            this.btn_transLog.TabIndex = 7;
            this.btn_transLog.Text = "Transaction Logs";
            this.btn_transLog.UseVisualStyleBackColor = true;
            // 
            // btn_formEditStaff
            // 
            this.btn_formEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formEditStaff.Location = new System.Drawing.Point(12, 105);
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
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 330);
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
    }
}