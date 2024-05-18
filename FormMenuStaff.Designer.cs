namespace ProjectHotel_UAS_PAD
{
    partial class FormMenuStaff
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
            this.btn_formCheckin = new System.Windows.Forms.Button();
            this.btn_formCheckout = new System.Windows.Forms.Button();
            this.btn_transLog = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_formCheckin
            // 
            this.btn_formCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formCheckin.Location = new System.Drawing.Point(12, 123);
            this.btn_formCheckin.Name = "btn_formCheckin";
            this.btn_formCheckin.Size = new System.Drawing.Size(505, 67);
            this.btn_formCheckin.TabIndex = 1;
            this.btn_formCheckin.Text = "Check In";
            this.btn_formCheckin.UseVisualStyleBackColor = true;
            this.btn_formCheckin.Click += new System.EventHandler(this.btn_formCheckin_Click);
            // 
            // btn_formCheckout
            // 
            this.btn_formCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formCheckout.Location = new System.Drawing.Point(12, 196);
            this.btn_formCheckout.Name = "btn_formCheckout";
            this.btn_formCheckout.Size = new System.Drawing.Size(505, 67);
            this.btn_formCheckout.TabIndex = 2;
            this.btn_formCheckout.Text = "Check Out";
            this.btn_formCheckout.UseVisualStyleBackColor = true;
            this.btn_formCheckout.Click += new System.EventHandler(this.btn_formCheckout_Click);
            // 
            // btn_transLog
            // 
            this.btn_transLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transLog.Location = new System.Drawing.Point(12, 269);
            this.btn_transLog.Name = "btn_transLog";
            this.btn_transLog.Size = new System.Drawing.Size(505, 67);
            this.btn_transLog.TabIndex = 3;
            this.btn_transLog.Text = "Transaction Logs";
            this.btn_transLog.UseVisualStyleBackColor = true;
            this.btn_transLog.Click += new System.EventHandler(this.btn_transLog_Click);
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(13, 13);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(228, 32);
            this.lbl_staffName.TabIndex = 4;
            this.lbl_staffName.Text = "Welcome back, ";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 342);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(505, 67);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // FormMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 421);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.btn_transLog);
            this.Controls.Add(this.btn_formCheckout);
            this.Controls.Add(this.btn_formCheckin);
            this.Name = "FormMenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_formCheckin;
        private System.Windows.Forms.Button btn_formCheckout;
        private System.Windows.Forms.Button btn_transLog;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Button btn_logout;
    }
}