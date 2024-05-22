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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_formCheckin = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_transLog = new System.Windows.Forms.Button();
            this.btn_formCheckout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelForm);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 35);
            this.panel1.TabIndex = 6;
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.ForeColor = System.Drawing.Color.Black;
            this.labelForm.Location = new System.Drawing.Point(12, 9);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(83, 16);
            this.labelForm.TabIndex = 18;
            this.labelForm.Text = "Menu Staff ";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(671, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 16);
            this.labelClose.TabIndex = 17;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.BackgroundImage = global::ProjectHotel_UAS_PAD.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 415);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 415);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_formCheckin);
            this.panel3.Controls.Add(this.lbl_staffName);
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.btn_transLog);
            this.panel3.Controls.Add(this.btn_formCheckout);
            this.panel3.Location = new System.Drawing.Point(199, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 330);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome, ";
            // 
            // btn_formCheckin
            // 
            this.btn_formCheckin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_formCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_formCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formCheckin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formCheckin.ForeColor = System.Drawing.Color.White;
            this.btn_formCheckin.Image = global::ProjectHotel_UAS_PAD.Properties.Resources.group_add_20dp_FILL0_wght400_GRAD0_opsz20__2___1_;
            this.btn_formCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_formCheckin.Location = new System.Drawing.Point(39, 123);
            this.btn_formCheckin.Margin = new System.Windows.Forms.Padding(5);
            this.btn_formCheckin.Name = "btn_formCheckin";
            this.btn_formCheckin.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_formCheckin.Size = new System.Drawing.Size(200, 40);
            this.btn_formCheckin.TabIndex = 1;
            this.btn_formCheckin.Text = "    Check In";
            this.btn_formCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_formCheckin.UseVisualStyleBackColor = false;
            this.btn_formCheckin.Click += new System.EventHandler(this.btn_formCheckin_Click);
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_staffName.Location = new System.Drawing.Point(35, 72);
            this.lbl_staffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(61, 19);
            this.lbl_staffName.TabIndex = 4;
            this.lbl_staffName.Text = "Admin";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.SlateGray;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::ProjectHotel_UAS_PAD.Properties.Resources.logout_20dp_FILL0_wght400_GRAD0_opsz20__1_;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(39, 255);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(200, 40);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "     Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_transLog
            // 
            this.btn_transLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_transLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transLog.ForeColor = System.Drawing.Color.White;
            this.btn_transLog.Image = global::ProjectHotel_UAS_PAD.Properties.Resources.receipt_long_20dp_FILL0_wght400_GRAD0_opsz20__1_;
            this.btn_transLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transLog.Location = new System.Drawing.Point(39, 211);
            this.btn_transLog.Margin = new System.Windows.Forms.Padding(2);
            this.btn_transLog.Name = "btn_transLog";
            this.btn_transLog.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_transLog.Size = new System.Drawing.Size(200, 40);
            this.btn_transLog.TabIndex = 3;
            this.btn_transLog.Text = "    Transaction Logs";
            this.btn_transLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transLog.UseVisualStyleBackColor = false;
            this.btn_transLog.Click += new System.EventHandler(this.btn_transLog_Click);
            // 
            // btn_formCheckout
            // 
            this.btn_formCheckout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_formCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formCheckout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formCheckout.ForeColor = System.Drawing.Color.White;
            this.btn_formCheckout.Image = global::ProjectHotel_UAS_PAD.Properties.Resources.person_check_20dp_FILL0_wght400_GRAD0_opsz20__1_;
            this.btn_formCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_formCheckout.Location = new System.Drawing.Point(39, 167);
            this.btn_formCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_formCheckout.Name = "btn_formCheckout";
            this.btn_formCheckout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_formCheckout.Size = new System.Drawing.Size(200, 40);
            this.btn_formCheckout.TabIndex = 2;
            this.btn_formCheckout.Text = "    Check Out";
            this.btn_formCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_formCheckout.UseVisualStyleBackColor = false;
            this.btn_formCheckout.Click += new System.EventHandler(this.btn_formCheckout_Click);
            // 
            // FormMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuStaff";
            this.Load += new System.EventHandler(this.FormMenuStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_formCheckin;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_transLog;
        private System.Windows.Forms.Button btn_formCheckout;
    }
}