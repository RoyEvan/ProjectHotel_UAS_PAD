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
            this.tbox_roomId = new System.Windows.Forms.TextBox();
            this.btn_searchBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_addedFines = new System.Windows.Forms.DataGridView();
            this.btn_removeFine = new System.Windows.Forms.Button();
            this.btn_addFine = new System.Windows.Forms.Button();
            this.cbox_fines = new System.Windows.Forms.ComboBox();
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
            this.btn_cancelTrans = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFines)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_bills);
            this.panel1.Controls.Add(this.tbox_roomId);
            this.panel1.Controls.Add(this.btn_searchBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 267);
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
            this.dgv_bills.Location = new System.Drawing.Point(18, 51);
            this.dgv_bills.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.RowTemplate.Height = 24;
            this.dgv_bills.Size = new System.Drawing.Size(1038, 196);
            this.dgv_bills.TabIndex = 5;
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick);
            // 
            // tbox_roomId
            // 
            this.tbox_roomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_roomId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_roomId.Location = new System.Drawing.Point(719, 21);
            this.tbox_roomId.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_roomId.Multiline = true;
            this.tbox_roomId.Name = "tbox_roomId";
            this.tbox_roomId.Size = new System.Drawing.Size(235, 22);
            this.tbox_roomId.TabIndex = 0;
            // 
            // btn_searchBill
            // 
            this.btn_searchBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_searchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchBill.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchBill.Location = new System.Drawing.Point(966, 21);
            this.btn_searchBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_searchBill.Name = "btn_searchBill";
            this.btn_searchBill.Size = new System.Drawing.Size(90, 22);
            this.btn_searchBill.TabIndex = 3;
            this.btn_searchBill.Text = "Search";
            this.btn_searchBill.UseVisualStyleBackColor = false;
            this.btn_searchBill.Click += new System.EventHandler(this.btn_searchBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Transactions";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_addedFines);
            this.panel2.Controls.Add(this.btn_removeFine);
            this.panel2.Controls.Add(this.btn_addFine);
            this.panel2.Controls.Add(this.cbox_fines);
            this.panel2.Location = new System.Drawing.Point(22, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 384);
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
            this.dgv_addedFines.Location = new System.Drawing.Point(18, 55);
            this.dgv_addedFines.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_addedFines.Name = "dgv_addedFines";
            this.dgv_addedFines.ReadOnly = true;
            this.dgv_addedFines.RowHeadersVisible = false;
            this.dgv_addedFines.RowHeadersWidth = 51;
            this.dgv_addedFines.RowTemplate.Height = 24;
            this.dgv_addedFines.Size = new System.Drawing.Size(657, 274);
            this.dgv_addedFines.TabIndex = 29;
            // 
            // btn_removeFine
            // 
            this.btn_removeFine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_removeFine.Enabled = false;
            this.btn_removeFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeFine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_removeFine.Location = new System.Drawing.Point(585, 334);
            this.btn_removeFine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeFine.Name = "btn_removeFine";
            this.btn_removeFine.Size = new System.Drawing.Size(90, 28);
            this.btn_removeFine.TabIndex = 7;
            this.btn_removeFine.Text = "Remove Fine";
            this.btn_removeFine.UseVisualStyleBackColor = false;
            this.btn_removeFine.Click += new System.EventHandler(this.btn_removeFine_Click);
            // 
            // btn_addFine
            // 
            this.btn_addFine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addFine.Enabled = false;
            this.btn_addFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFine.Location = new System.Drawing.Point(486, 334);
            this.btn_addFine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addFine.Name = "btn_addFine";
            this.btn_addFine.Size = new System.Drawing.Size(90, 28);
            this.btn_addFine.TabIndex = 6;
            this.btn_addFine.Text = "Add Fine";
            this.btn_addFine.UseVisualStyleBackColor = false;
            this.btn_addFine.Click += new System.EventHandler(this.btn_addFine_Click);
            // 
            // cbox_fines
            // 
            this.cbox_fines.Enabled = false;
            this.cbox_fines.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_fines.FormattingEnabled = true;
            this.cbox_fines.Location = new System.Drawing.Point(18, 22);
            this.cbox_fines.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_fines.Name = "cbox_fines";
            this.cbox_fines.Size = new System.Drawing.Size(657, 26);
            this.cbox_fines.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel3.Location = new System.Drawing.Point(742, 405);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 331);
            this.panel3.TabIndex = 12;
            // 
            // btn_extend
            // 
            this.btn_extend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_extend.Enabled = false;
            this.btn_extend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extend.Location = new System.Drawing.Point(22, 235);
            this.btn_extend.Margin = new System.Windows.Forms.Padding(2);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(314, 28);
            this.btn_extend.TabIndex = 40;
            this.btn_extend.Text = "Extend";
            this.btn_extend.UseVisualStyleBackColor = false;
            this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
            // 
            // summary_grandTotal
            // 
            this.summary_grandTotal.AutoSize = true;
            this.summary_grandTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_grandTotal.Location = new System.Drawing.Point(114, 176);
            this.summary_grandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_grandTotal.Name = "summary_grandTotal";
            this.summary_grandTotal.Size = new System.Drawing.Size(15, 16);
            this.summary_grandTotal.TabIndex = 39;
            this.summary_grandTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 176);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Grand Total :";
            // 
            // summary_oldBillTotal
            // 
            this.summary_oldBillTotal.AutoSize = true;
            this.summary_oldBillTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_oldBillTotal.Location = new System.Drawing.Point(114, 130);
            this.summary_oldBillTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_oldBillTotal.Name = "summary_oldBillTotal";
            this.summary_oldBillTotal.Size = new System.Drawing.Size(15, 16);
            this.summary_oldBillTotal.TabIndex = 37;
            this.summary_oldBillTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Old Bill Total :";
            // 
            // summary_totalFines
            // 
            this.summary_totalFines.AutoSize = true;
            this.summary_totalFines.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalFines.Location = new System.Drawing.Point(114, 153);
            this.summary_totalFines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_totalFines.Name = "summary_totalFines";
            this.summary_totalFines.Size = new System.Drawing.Size(15, 16);
            this.summary_totalFines.TabIndex = 35;
            this.summary_totalFines.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Fines :";
            // 
            // summary_roomId
            // 
            this.summary_roomId.AutoSize = true;
            this.summary_roomId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomId.Location = new System.Drawing.Point(114, 107);
            this.summary_roomId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_roomId.Name = "summary_roomId";
            this.summary_roomId.Size = new System.Drawing.Size(44, 16);
            this.summary_roomId.TabIndex = 33;
            this.summary_roomId.Text = "A0100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Room ID :";
            // 
            // summary_custId
            // 
            this.summary_custId.AutoSize = true;
            this.summary_custId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_custId.Location = new System.Drawing.Point(114, 84);
            this.summary_custId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_custId.Name = "summary_custId";
            this.summary_custId.Size = new System.Drawing.Size(120, 16);
            this.summary_custId.TabIndex = 31;
            this.summary_custId.Text = "3578121212121212";
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_checkout.Enabled = false;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(22, 281);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(314, 28);
            this.btn_checkout.TabIndex = 30;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // summary_billId
            // 
            this.summary_billId.AutoSize = true;
            this.summary_billId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_billId.Location = new System.Drawing.Point(114, 61);
            this.summary_billId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summary_billId.Name = "summary_billId";
            this.summary_billId.Size = new System.Drawing.Size(154, 16);
            this.summary_billId.TabIndex = 4;
            this.summary_billId.Text = "NOTA11072024115999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bill ID :";
            // 
            // btn_cancelTrans
            // 
            this.btn_cancelTrans.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelTrans.Location = new System.Drawing.Point(742, 352);
            this.btn_cancelTrans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelTrans.Name = "btn_cancelTrans";
            this.btn_cancelTrans.Size = new System.Drawing.Size(358, 28);
            this.btn_cancelTrans.TabIndex = 15;
            this.btn_cancelTrans.Text = "Cancel";
            this.btn_cancelTrans.UseVisualStyleBackColor = false;
            this.btn_cancelTrans.Click += new System.EventHandler(this.btn_cancelTrans_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.labelClose);
            this.panel4.Controls.Add(this.labelForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1125, 35);
            this.panel4.TabIndex = 16;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(1096, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 16);
            this.labelClose.TabIndex = 22;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.ForeColor = System.Drawing.Color.Black;
            this.labelForm.Location = new System.Drawing.Point(12, 9);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(159, 16);
            this.labelForm.TabIndex = 20;
            this.labelForm.Text = "Menu Staff | Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Summary";
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_cancelTrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFines)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbox_fines;
        private System.Windows.Forms.Button btn_addFine;
        private System.Windows.Forms.Button btn_removeFine;
        private System.Windows.Forms.DataGridView dgv_addedFines;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClose;
    }
}