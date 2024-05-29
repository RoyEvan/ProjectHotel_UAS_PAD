namespace ProjectHotel_UAS_PAD
{
    partial class FormVouchers
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
            this.dgv_vouchers = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textVoucherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textFacilitiesID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vouchers
            // 
            this.dgv_vouchers.AllowUserToAddRows = false;
            this.dgv_vouchers.AllowUserToDeleteRows = false;
            this.dgv_vouchers.AllowUserToResizeColumns = false;
            this.dgv_vouchers.AllowUserToResizeRows = false;
            this.dgv_vouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vouchers.Location = new System.Drawing.Point(12, 12);
            this.dgv_vouchers.Name = "dgv_vouchers";
            this.dgv_vouchers.RowHeadersVisible = false;
            this.dgv_vouchers.RowHeadersWidth = 51;
            this.dgv_vouchers.RowTemplate.Height = 24;
            this.dgv_vouchers.Size = new System.Drawing.Size(806, 426);
            this.dgv_vouchers.TabIndex = 0;
            this.dgv_vouchers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vouchers_CellDoubleClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(950, 155);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(260, 33);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(950, 127);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(260, 22);
            this.textAmount.TabIndex = 14;
            // 
            // textVoucherName
            // 
            this.textVoucherName.Location = new System.Drawing.Point(950, 72);
            this.textVoucherName.Name = "textVoucherName";
            this.textVoucherName.Size = new System.Drawing.Size(260, 22);
            this.textVoucherName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(874, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(826, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voucher Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID :";
            // 
            // textFacilitiesID
            // 
            this.textFacilitiesID.Location = new System.Drawing.Point(950, 100);
            this.textFacilitiesID.Name = "textFacilitiesID";
            this.textFacilitiesID.Size = new System.Drawing.Size(260, 22);
            this.textFacilitiesID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Facilities ID :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(829, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1031, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // FormVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 453);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textFacilitiesID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textVoucherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_vouchers);
            this.Name = "FormVouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVouchers";
            this.Load += new System.EventHandler(this.FormVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vouchers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vouchers;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textVoucherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFacilitiesID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}