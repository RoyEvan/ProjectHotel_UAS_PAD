namespace ProjectHotel_UAS_PAD
{
    partial class FormCheckin
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
            this.tbox_custPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_searchCust = new System.Windows.Forms.Button();
            this.btn_addCust = new System.Windows.Forms.Button();
            this.dgv_cust = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_rooms = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_addFacility = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_facility = new System.Windows.Forms.DataGridView();
            this.panel_summary = new System.Windows.Forms.Panel();
            this.btn_checkVoucher = new System.Windows.Forms.Button();
            this.summary_voucherName = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.summary_totalDisc = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.summary_grandTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbox_voucherId = new System.Windows.Forms.TextBox();
            this.btn_applyVoucher = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.summary_roomFacTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_removeAddedFac = new System.Windows.Forms.Button();
            this.summary_roomPrice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.summary_roomNumber = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.summary_totalFacPrice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_addedFacilities = new System.Windows.Forms.DataGridView();
            this.summary_roomCategory = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.summary_roomLocation = new System.Windows.Forms.Label();
            this.summary_custNIK = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.summary_days = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.summary_custName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancelTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facility)).BeginInit();
            this.panel_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFacilities)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_custPhone
            // 
            this.tbox_custPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_custPhone.Location = new System.Drawing.Point(55, 52);
            this.tbox_custPhone.Name = "tbox_custPhone";
            this.tbox_custPhone.Size = new System.Drawing.Size(141, 22);
            this.tbox_custPhone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer\'s Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // btn_searchCust
            // 
            this.btn_searchCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCust.Location = new System.Drawing.Point(202, 51);
            this.btn_searchCust.Name = "btn_searchCust";
            this.btn_searchCust.Size = new System.Drawing.Size(80, 24);
            this.btn_searchCust.TabIndex = 3;
            this.btn_searchCust.Text = "Search";
            this.btn_searchCust.UseVisualStyleBackColor = true;
            this.btn_searchCust.Click += new System.EventHandler(this.btn_searchCust_Click);
            // 
            // btn_addCust
            // 
            this.btn_addCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCust.Location = new System.Drawing.Point(288, 52);
            this.btn_addCust.Name = "btn_addCust";
            this.btn_addCust.Size = new System.Drawing.Size(151, 23);
            this.btn_addCust.TabIndex = 4;
            this.btn_addCust.Text = "Add New Customer";
            this.btn_addCust.UseVisualStyleBackColor = true;
            this.btn_addCust.Click += new System.EventHandler(this.btn_addCust_Click);
            // 
            // dgv_cust
            // 
            this.dgv_cust.AllowUserToAddRows = false;
            this.dgv_cust.AllowUserToDeleteRows = false;
            this.dgv_cust.AllowUserToResizeRows = false;
            this.dgv_cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cust.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_cust.Location = new System.Drawing.Point(3, 80);
            this.dgv_cust.Name = "dgv_cust";
            this.dgv_cust.RowHeadersVisible = false;
            this.dgv_cust.RowHeadersWidth = 51;
            this.dgv_cust.RowTemplate.Height = 24;
            this.dgv_cust.Size = new System.Drawing.Size(761, 214);
            this.dgv_cust.TabIndex = 5;
            this.dgv_cust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cust_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_cust);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_addCust);
            this.panel1.Controls.Add(this.tbox_custPhone);
            this.panel1.Controls.Add(this.btn_searchCust);
            this.panel1.Location = new System.Drawing.Point(9, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 299);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_rooms);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 293);
            this.panel2.TabIndex = 8;
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AllowUserToResizeRows = false;
            this.dgv_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_rooms.Enabled = false;
            this.dgv_rooms.Location = new System.Drawing.Point(3, 55);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.RowHeadersWidth = 51;
            this.dgv_rooms.RowTemplate.Height = 24;
            this.dgv_rooms.Size = new System.Drawing.Size(761, 234);
            this.dgv_rooms.TabIndex = 3;
            this.dgv_rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rooms_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Check Out Date";
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Enabled = false;
            this.dtp_checkout.Location = new System.Drawing.Point(154, 53);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(213, 22);
            this.dtp_checkout.TabIndex = 11;
            this.dtp_checkout.Value = new System.DateTime(2024, 5, 15, 22, 53, 11, 0);
            this.dtp_checkout.ValueChanged += new System.EventHandler(this.dtp_checkout_ValueChanged);
            // 
            // btn_checkin
            // 
            this.btn_checkin.Enabled = false;
            this.btn_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkin.Location = new System.Drawing.Point(2, 796);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(531, 35);
            this.btn_checkin.TabIndex = 9;
            this.btn_checkin.Text = "Check In";
            this.btn_checkin.UseVisualStyleBackColor = true;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(12, 12);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(102, 32);
            this.lbl_staffName.TabIndex = 10;
            this.lbl_staffName.Text = "Hello, ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_addFacility);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dgv_facility);
            this.panel3.Location = new System.Drawing.Point(9, 655);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 312);
            this.panel3.TabIndex = 11;
            // 
            // btn_addFacility
            // 
            this.btn_addFacility.Enabled = false;
            this.btn_addFacility.Location = new System.Drawing.Point(618, 273);
            this.btn_addFacility.Name = "btn_addFacility";
            this.btn_addFacility.Size = new System.Drawing.Size(146, 35);
            this.btn_addFacility.TabIndex = 15;
            this.btn_addFacility.Text = "Add Facility";
            this.btn_addFacility.UseVisualStyleBackColor = true;
            this.btn_addFacility.Click += new System.EventHandler(this.btn_addFacility_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Facilities";
            // 
            // dgv_facility
            // 
            this.dgv_facility.AllowUserToAddRows = false;
            this.dgv_facility.AllowUserToDeleteRows = false;
            this.dgv_facility.AllowUserToResizeRows = false;
            this.dgv_facility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_facility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facility.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_facility.Enabled = false;
            this.dgv_facility.Location = new System.Drawing.Point(3, 53);
            this.dgv_facility.Name = "dgv_facility";
            this.dgv_facility.ReadOnly = true;
            this.dgv_facility.RowHeadersVisible = false;
            this.dgv_facility.RowHeadersWidth = 51;
            this.dgv_facility.RowTemplate.Height = 24;
            this.dgv_facility.Size = new System.Drawing.Size(761, 214);
            this.dgv_facility.TabIndex = 0;
            // 
            // panel_summary
            // 
            this.panel_summary.BackColor = System.Drawing.Color.White;
            this.panel_summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_summary.Controls.Add(this.btn_checkVoucher);
            this.panel_summary.Controls.Add(this.summary_voucherName);
            this.panel_summary.Controls.Add(this.label22);
            this.panel_summary.Controls.Add(this.summary_totalDisc);
            this.panel_summary.Controls.Add(this.label20);
            this.panel_summary.Controls.Add(this.btn_checkin);
            this.panel_summary.Controls.Add(this.summary_grandTotal);
            this.panel_summary.Controls.Add(this.label19);
            this.panel_summary.Controls.Add(this.tbox_voucherId);
            this.panel_summary.Controls.Add(this.btn_applyVoucher);
            this.panel_summary.Controls.Add(this.label10);
            this.panel_summary.Controls.Add(this.summary_roomFacTotalPrice);
            this.panel_summary.Controls.Add(this.label4);
            this.panel_summary.Controls.Add(this.btn_removeAddedFac);
            this.panel_summary.Controls.Add(this.summary_roomPrice);
            this.panel_summary.Controls.Add(this.label15);
            this.panel_summary.Controls.Add(this.summary_roomNumber);
            this.panel_summary.Controls.Add(this.label18);
            this.panel_summary.Controls.Add(this.summary_totalFacPrice);
            this.panel_summary.Controls.Add(this.label16);
            this.panel_summary.Controls.Add(this.label13);
            this.panel_summary.Controls.Add(this.dgv_addedFacilities);
            this.panel_summary.Controls.Add(this.summary_roomCategory);
            this.panel_summary.Controls.Add(this.label12);
            this.panel_summary.Controls.Add(this.label14);
            this.panel_summary.Controls.Add(this.summary_roomLocation);
            this.panel_summary.Controls.Add(this.summary_custNIK);
            this.panel_summary.Controls.Add(this.label11);
            this.panel_summary.Controls.Add(this.summary_days);
            this.panel_summary.Controls.Add(this.label9);
            this.panel_summary.Controls.Add(this.summary_custName);
            this.panel_summary.Controls.Add(this.label8);
            this.panel_summary.Controls.Add(this.label6);
            this.panel_summary.Controls.Add(this.dtp_checkout);
            this.panel_summary.Controls.Add(this.label5);
            this.panel_summary.Enabled = false;
            this.panel_summary.Location = new System.Drawing.Point(782, 131);
            this.panel_summary.Name = "panel_summary";
            this.panel_summary.Size = new System.Drawing.Size(537, 836);
            this.panel_summary.TabIndex = 13;
            // 
            // btn_checkVoucher
            // 
            this.btn_checkVoucher.Enabled = false;
            this.btn_checkVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkVoucher.Location = new System.Drawing.Point(318, 654);
            this.btn_checkVoucher.Name = "btn_checkVoucher";
            this.btn_checkVoucher.Size = new System.Drawing.Size(81, 32);
            this.btn_checkVoucher.TabIndex = 51;
            this.btn_checkVoucher.Text = "Check";
            this.btn_checkVoucher.UseVisualStyleBackColor = true;
            this.btn_checkVoucher.Click += new System.EventHandler(this.btn_checkVoucher_Click);
            // 
            // summary_voucherName
            // 
            this.summary_voucherName.AutoSize = true;
            this.summary_voucherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_voucherName.Location = new System.Drawing.Point(151, 693);
            this.summary_voucherName.Name = "summary_voucherName";
            this.summary_voucherName.Size = new System.Drawing.Size(87, 18);
            this.summary_voucherName.TabIndex = 50;
            this.summary_voucherName.Text = "No Voucher";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 693);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 18);
            this.label22.TabIndex = 49;
            this.label22.Text = "Voucher Name :";
            // 
            // summary_totalDisc
            // 
            this.summary_totalDisc.AutoSize = true;
            this.summary_totalDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalDisc.Location = new System.Drawing.Point(151, 739);
            this.summary_totalDisc.Name = "summary_totalDisc";
            this.summary_totalDisc.Size = new System.Drawing.Size(16, 18);
            this.summary_totalDisc.TabIndex = 48;
            this.summary_totalDisc.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 739);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 18);
            this.label20.TabIndex = 47;
            this.label20.Text = "Total Discounts :";
            // 
            // summary_grandTotal
            // 
            this.summary_grandTotal.AutoSize = true;
            this.summary_grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_grandTotal.Location = new System.Drawing.Point(151, 765);
            this.summary_grandTotal.Name = "summary_grandTotal";
            this.summary_grandTotal.Size = new System.Drawing.Size(16, 18);
            this.summary_grandTotal.TabIndex = 46;
            this.summary_grandTotal.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(51, 765);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 18);
            this.label19.TabIndex = 45;
            this.label19.Text = "Grand Total :";
            // 
            // tbox_voucherId
            // 
            this.tbox_voucherId.Enabled = false;
            this.tbox_voucherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_voucherId.Location = new System.Drawing.Point(154, 658);
            this.tbox_voucherId.Name = "tbox_voucherId";
            this.tbox_voucherId.Size = new System.Drawing.Size(158, 24);
            this.tbox_voucherId.TabIndex = 43;
            // 
            // btn_applyVoucher
            // 
            this.btn_applyVoucher.Enabled = false;
            this.btn_applyVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_applyVoucher.Location = new System.Drawing.Point(405, 654);
            this.btn_applyVoucher.Name = "btn_applyVoucher";
            this.btn_applyVoucher.Size = new System.Drawing.Size(81, 32);
            this.btn_applyVoucher.TabIndex = 42;
            this.btn_applyVoucher.Text = "Apply";
            this.btn_applyVoucher.UseVisualStyleBackColor = true;
            this.btn_applyVoucher.Click += new System.EventHandler(this.btn_applyVoucher_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 661);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Vouchers ID";
            // 
            // summary_roomFacTotalPrice
            // 
            this.summary_roomFacTotalPrice.AutoSize = true;
            this.summary_roomFacTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomFacTotalPrice.Location = new System.Drawing.Point(151, 620);
            this.summary_roomFacTotalPrice.Name = "summary_roomFacTotalPrice";
            this.summary_roomFacTotalPrice.Size = new System.Drawing.Size(16, 18);
            this.summary_roomFacTotalPrice.TabIndex = 39;
            this.summary_roomFacTotalPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total :";
            // 
            // btn_removeAddedFac
            // 
            this.btn_removeAddedFac.Enabled = false;
            this.btn_removeAddedFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeAddedFac.Location = new System.Drawing.Point(386, 519);
            this.btn_removeAddedFac.Name = "btn_removeAddedFac";
            this.btn_removeAddedFac.Size = new System.Drawing.Size(146, 35);
            this.btn_removeAddedFac.TabIndex = 16;
            this.btn_removeAddedFac.Text = "Remove Facility";
            this.btn_removeAddedFac.UseVisualStyleBackColor = true;
            this.btn_removeAddedFac.Click += new System.EventHandler(this.btn_removeAddedFac_Click);
            // 
            // summary_roomPrice
            // 
            this.summary_roomPrice.AutoSize = true;
            this.summary_roomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomPrice.Location = new System.Drawing.Point(151, 564);
            this.summary_roomPrice.Name = "summary_roomPrice";
            this.summary_roomPrice.Size = new System.Drawing.Size(16, 18);
            this.summary_roomPrice.TabIndex = 37;
            this.summary_roomPrice.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 564);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 18);
            this.label15.TabIndex = 36;
            this.label15.Text = "Room Price :";
            // 
            // summary_roomNumber
            // 
            this.summary_roomNumber.AutoSize = true;
            this.summary_roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomNumber.Location = new System.Drawing.Point(151, 204);
            this.summary_roomNumber.Name = "summary_roomNumber";
            this.summary_roomNumber.Size = new System.Drawing.Size(17, 18);
            this.summary_roomNumber.TabIndex = 35;
            this.summary_roomNumber.Text = "Z";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "Room Number :";
            // 
            // summary_totalFacPrice
            // 
            this.summary_totalFacPrice.AutoSize = true;
            this.summary_totalFacPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalFacPrice.Location = new System.Drawing.Point(151, 536);
            this.summary_totalFacPrice.Name = "summary_totalFacPrice";
            this.summary_totalFacPrice.Size = new System.Drawing.Size(16, 18);
            this.summary_totalFacPrice.TabIndex = 31;
            this.summary_totalFacPrice.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 536);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Facilities Total :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 32);
            this.label13.TabIndex = 29;
            this.label13.Text = "Added Facilities";
            // 
            // dgv_addedFacilities
            // 
            this.dgv_addedFacilities.AllowUserToAddRows = false;
            this.dgv_addedFacilities.AllowUserToDeleteRows = false;
            this.dgv_addedFacilities.AllowUserToResizeRows = false;
            this.dgv_addedFacilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_addedFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addedFacilities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_addedFacilities.Enabled = false;
            this.dgv_addedFacilities.Location = new System.Drawing.Point(3, 320);
            this.dgv_addedFacilities.Name = "dgv_addedFacilities";
            this.dgv_addedFacilities.ReadOnly = true;
            this.dgv_addedFacilities.RowHeadersVisible = false;
            this.dgv_addedFacilities.RowHeadersWidth = 51;
            this.dgv_addedFacilities.RowTemplate.Height = 24;
            this.dgv_addedFacilities.Size = new System.Drawing.Size(529, 193);
            this.dgv_addedFacilities.TabIndex = 28;
            // 
            // summary_roomCategory
            // 
            this.summary_roomCategory.AutoSize = true;
            this.summary_roomCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomCategory.Location = new System.Drawing.Point(151, 237);
            this.summary_roomCategory.Name = "summary_roomCategory";
            this.summary_roomCategory.Size = new System.Drawing.Size(85, 18);
            this.summary_roomCategory.TabIndex = 27;
            this.summary_roomCategory.Text = "AaBb CcDd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Room Category :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Room Location :";
            // 
            // summary_roomLocation
            // 
            this.summary_roomLocation.AutoSize = true;
            this.summary_roomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_roomLocation.Location = new System.Drawing.Point(151, 174);
            this.summary_roomLocation.Name = "summary_roomLocation";
            this.summary_roomLocation.Size = new System.Drawing.Size(125, 18);
            this.summary_roomLocation.TabIndex = 24;
            this.summary_roomLocation.Text = "Lorong X Lantai Y";
            // 
            // summary_custNIK
            // 
            this.summary_custNIK.AutoSize = true;
            this.summary_custNIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_custNIK.Location = new System.Drawing.Point(151, 97);
            this.summary_custNIK.Name = "summary_custNIK";
            this.summary_custNIK.Size = new System.Drawing.Size(136, 18);
            this.summary_custNIK.TabIndex = 21;
            this.summary_custNIK.Text = "1234561212120001";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Customer ID :";
            // 
            // summary_days
            // 
            this.summary_days.AutoSize = true;
            this.summary_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_days.Location = new System.Drawing.Point(151, 592);
            this.summary_days.Name = "summary_days";
            this.summary_days.Size = new System.Drawing.Size(16, 18);
            this.summary_days.TabIndex = 19;
            this.summary_days.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 592);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Days of Stay :";
            // 
            // summary_custName
            // 
            this.summary_custName.AutoSize = true;
            this.summary_custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_custName.Location = new System.Drawing.Point(151, 125);
            this.summary_custName.Name = "summary_custName";
            this.summary_custName.Size = new System.Drawing.Size(71, 18);
            this.summary_custName.TabIndex = 17;
            this.summary_custName.Text = "Unknown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Customer Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Summary";
            // 
            // btn_cancelTrans
            // 
            this.btn_cancelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelTrans.Location = new System.Drawing.Point(1169, 12);
            this.btn_cancelTrans.Name = "btn_cancelTrans";
            this.btn_cancelTrans.Size = new System.Drawing.Size(150, 35);
            this.btn_cancelTrans.TabIndex = 14;
            this.btn_cancelTrans.Text = "Cancel";
            this.btn_cancelTrans.UseVisualStyleBackColor = true;
            this.btn_cancelTrans.Click += new System.EventHandler(this.btn_cancelTrans_Click);
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1328, 975);
            this.Controls.Add(this.btn_cancelTrans);
            this.Controls.Add(this.panel_summary);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPesanKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facility)).EndInit();
            this.panel_summary.ResumeLayout(false);
            this.panel_summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addedFacilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_custPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_searchCust;
        private System.Windows.Forms.Button btn_addCust;
        private System.Windows.Forms.DataGridView dgv_cust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_rooms;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.DateTimePicker dtp_checkout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_facility;
        private System.Windows.Forms.Panel panel_summary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addFacility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label summary_custName;
        private System.Windows.Forms.Label summary_days;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label summary_custNIK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label summary_roomCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label summary_roomLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_addedFacilities;
        private System.Windows.Forms.Label summary_totalFacPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label summary_roomNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label summary_roomPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_removeAddedFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label summary_roomFacTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_voucherId;
        private System.Windows.Forms.Button btn_applyVoucher;
        private System.Windows.Forms.Label summary_totalDisc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label summary_grandTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label summary_voucherName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_checkVoucher;
        private System.Windows.Forms.Button btn_cancelTrans;
    }
}