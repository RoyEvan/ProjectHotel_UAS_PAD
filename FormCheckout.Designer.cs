namespace ProjectHotel_UAS_PAD
{
    partial class FormCheckout
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
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_roomId = new System.Windows.Forms.TextBox();
            this.btn_searchBill = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_addedFines = new System.Windows.Forms.DataGridView();
            this.btn_removeFine = new System.Windows.Forms.Button();
            this.btn_addFine = new System.Windows.Forms.Button();
            this.cbox_fines = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_extend = new System.Windows.Forms.Button();
            this.summary_grandTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.summary_oldBillTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.summary_totalFines = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.summary_roomId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.summary_custId = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.summary_billId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelTrans = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFines)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_bills);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbox_roomId);
            this.panel1.Controls.Add(this.btn_searchBill);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 299);
            this.panel1.TabIndex = 8;
            // 
            // dgv_bills
            // 
            this.dgv_bills.AllowUserToAddRows = false;
            this.dgv_bills.AllowUserToDeleteRows = false;
            this.dgv_bills.AllowUserToResizeRows = false;
            this.dgv_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_bills.Location = new System.Drawing.Point(3, 80);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.RowTemplate.Height = 24;
            this.dgv_bills.Size = new System.Drawing.Size(1008, 214);
            this.dgv_bills.TabIndex = 5;
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room ID";
            // 
            // tbox_roomId
            // 
            this.tbox_roomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_roomId.Location = new System.Drawing.Point(72, 52);
            this.tbox_roomId.Name = "tbox_roomId";
            this.tbox_roomId.Size = new System.Drawing.Size(166, 22);
            this.tbox_roomId.TabIndex = 0;
            // 
            // btn_searchBill
            // 
            this.btn_searchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchBill.Location = new System.Drawing.Point(244, 52);
            this.btn_searchBill.Name = "btn_searchBill";
            this.btn_searchBill.Size = new System.Drawing.Size(80, 24);
            this.btn_searchBill.TabIndex = 3;
            this.btn_searchBill.Text = "Search";
            this.btn_searchBill.UseVisualStyleBackColor = true;
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(6, 9);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(102, 32);
            this.lbl_staffName.TabIndex = 11;
            this.lbl_staffName.Text = "Hello, ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_addedFines);
            this.panel2.Controls.Add(this.btn_removeFine);
            this.panel2.Controls.Add(this.btn_addFine);
            this.panel2.Controls.Add(this.cbox_fines);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 263);
            this.panel2.TabIndex = 9;
            // 
            // dgv_addedFines
            // 
            this.dgv_addedFines.AllowUserToAddRows = false;
            this.dgv_addedFines.AllowUserToDeleteRows = false;
            this.dgv_addedFines.AllowUserToResizeRows = false;
            this.dgv_addedFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_addedFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addedFines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_addedFines.Enabled = false;
            this.dgv_addedFines.Location = new System.Drawing.Point(3, 82);
            this.dgv_addedFines.Name = "dgv_addedFines";
            this.dgv_addedFines.ReadOnly = true;
            this.dgv_addedFines.RowHeadersVisible = false;
            this.dgv_addedFines.RowHeadersWidth = 51;
            this.dgv_addedFines.RowTemplate.Height = 24;
            this.dgv_addedFines.Size = new System.Drawing.Size(619, 138);
            this.dgv_addedFines.TabIndex = 29;
            // 
            // btn_removeFine
            // 
            this.btn_removeFine.Enabled = false;
            this.btn_removeFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFine.Location = new System.Drawing.Point(500, 226);
            this.btn_removeFine.Name = "btn_removeFine";
            this.btn_removeFine.Size = new System.Drawing.Size(122, 32);
            this.btn_removeFine.TabIndex = 7;
            this.btn_removeFine.Text = "Remove Fine";
            this.btn_removeFine.UseVisualStyleBackColor = true;
            this.btn_removeFine.Click += new System.EventHandler(this.btn_removeFine_Click);
            // 
            // btn_addFine
            // 
            this.btn_addFine.Enabled = false;
            this.btn_addFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFine.Location = new System.Drawing.Point(479, 44);
            this.btn_addFine.Name = "btn_addFine";
            this.btn_addFine.Size = new System.Drawing.Size(115, 32);
            this.btn_addFine.TabIndex = 6;
            this.btn_addFine.Text = "Add Fine";
            this.btn_addFine.UseVisualStyleBackColor = true;
            this.btn_addFine.Click += new System.EventHandler(this.btn_addFine_Click);
            // 
            // cbox_fines
            // 
            this.cbox_fines.Enabled = false;
            this.cbox_fines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_fines.FormattingEnabled = true;
            this.cbox_fines.Location = new System.Drawing.Point(49, 48);
            this.cbox_fines.Name = "cbox_fines";
            this.cbox_fines.Size = new System.Drawing.Size(424, 26);
            this.cbox_fines.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fine";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_extend);
            this.panel3.Controls.Add(this.summary_grandTotal);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.summary_oldBillTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.summary_totalFines);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.summary_roomId);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.summary_custId);
            this.panel3.Controls.Add(this.btn_checkout);
            this.panel3.Controls.Add(this.summary_billId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(643, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 263);
            this.panel3.TabIndex = 12;
            // 
            // btn_extend
            // 
            this.btn_extend.Enabled = false;
            this.btn_extend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extend.Location = new System.Drawing.Point(3, 228);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(187, 32);
            this.btn_extend.TabIndex = 40;
            this.btn_extend.Text = "Extend";
            this.btn_extend.UseVisualStyleBackColor = true;
            this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
            // 
            // summary_grandTotal
            // 
            this.summary_grandTotal.AutoSize = true;
            this.summary_grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_grandTotal.Location = new System.Drawing.Point(263, 196);
            this.summary_grandTotal.Name = "summary_grandTotal";
            this.summary_grandTotal.Size = new System.Drawing.Size(16, 18);
            this.summary_grandTotal.TabIndex = 39;
            this.summary_grandTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = "Grand Total :";
            // 
            // summary_oldBillTotal
            // 
            this.summary_oldBillTotal.AutoSize = true;
            this.summary_oldBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_oldBillTotal.Location = new System.Drawing.Point(263, 139);
            this.summary_oldBillTotal.Name = "summary_oldBillTotal";
            this.summary_oldBillTotal.Size = new System.Drawing.Size(16, 18);
            this.summary_oldBillTotal.TabIndex = 37;
            this.summary_oldBillTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Old Bill Total :";
            // 
            // summary_totalFines
            // 
            this.summary_totalFines.AutoSize = true;
            this.summary_totalFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalFines.Location = new System.Drawing.Point(263, 168);
            this.summary_totalFines.Name = "summary_totalFines";
            this.summary_totalFines.Size = new System.Drawing.Size(16, 18);
            this.summary_totalFines.TabIndex = 35;
            this.summary_totalFines.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Fines :";
            // 
            // summary_roomId
            // 
            this.summary_roomId.AutoSize = true;
            this.summary_roomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomId.Location = new System.Drawing.Point(127, 106);
            this.summary_roomId.Name = "summary_roomId";
            this.summary_roomId.Size = new System.Drawing.Size(49, 18);
            this.summary_roomId.TabIndex = 33;
            this.summary_roomId.Text = "A0101";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "Room ID :";
            // 
            // summary_custId
            // 
            this.summary_custId.AutoSize = true;
            this.summary_custId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_custId.Location = new System.Drawing.Point(127, 78);
            this.summary_custId.Name = "summary_custId";
            this.summary_custId.Size = new System.Drawing.Size(136, 18);
            this.summary_custId.TabIndex = 31;
            this.summary_custId.Text = "3578111212120002";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Enabled = false;
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(193, 228);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(187, 32);
            this.btn_checkout.TabIndex = 30;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // summary_billId
            // 
            this.summary_billId.AutoSize = true;
            this.summary_billId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_billId.Location = new System.Drawing.Point(127, 52);
            this.summary_billId.Name = "summary_billId";
            this.summary_billId.Size = new System.Drawing.Size(179, 18);
            this.summary_billId.TabIndex = 4;
            this.summary_billId.Text = "NOTA11072024115900";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bill ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Summary";
            // 
            // btn_cancelTrans
            // 
            this.btn_cancelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelTrans.Location = new System.Drawing.Point(876, 12);
            this.btn_cancelTrans.Name = "btn_cancelTrans";
            this.btn_cancelTrans.Size = new System.Drawing.Size(150, 35);
            this.btn_cancelTrans.TabIndex = 15;
            this.btn_cancelTrans.Text = "Cancel";
            this.btn_cancelTrans.UseVisualStyleBackColor = true;
            this.btn_cancelTrans.Click += new System.EventHandler(this.btn_cancelTrans_Click);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 642);
            this.Controls.Add(this.btn_cancelTrans);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.panel1);
            this.Name = "FormCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFines)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_roomId;
        private System.Windows.Forms.Button btn_searchBill;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_fines;
        private System.Windows.Forms.Button btn_addFine;
        private System.Windows.Forms.Button btn_removeFine;
        private System.Windows.Forms.DataGridView dgv_addedFines;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label summary_custId;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label summary_billId;
        private System.Windows.Forms.Label summary_roomId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label summary_totalFines;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label summary_grandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label summary_oldBillTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_extend;
        private System.Windows.Forms.Button btn_cancelTrans;
    }
}