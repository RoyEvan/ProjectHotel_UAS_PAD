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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_rooms = new System.Windows.Forms.DataGridView();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.dgv_cust.Size = new System.Drawing.Size(764, 228);
            this.dgv_cust.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_cust);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_addCust);
            this.panel1.Controls.Add(this.tbox_custPhone);
            this.panel1.Controls.Add(this.btn_searchCust);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 311);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_rooms);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 312);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Check Out Date";
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_rooms.Location = new System.Drawing.Point(3, 80);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.RowHeadersWidth = 51;
            this.dgv_rooms.RowTemplate.Height = 24;
            this.dgv_rooms.Size = new System.Drawing.Size(764, 228);
            this.dgv_rooms.TabIndex = 3;
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Location = new System.Drawing.Point(132, 53);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(213, 22);
            this.dtp_checkout.TabIndex = 11;
            this.dtp_checkout.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check-In Informations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Room";
            // 
            // btn_checkin
            // 
            this.btn_checkin.Location = new System.Drawing.Point(3, 908);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(668, 35);
            this.btn_checkin.TabIndex = 9;
            this.btn_checkin.Text = "Check In";
            this.btn_checkin.UseVisualStyleBackColor = true;
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(12, 13);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(102, 32);
            this.lbl_staffName.TabIndex = 10;
            this.lbl_staffName.Text = "Hello, ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 311);
            this.panel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btn_checkin);
            this.panel4.Controls.Add(this.dtp_checkout);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(788, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 946);
            this.panel4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Additional Facilities";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Facility";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPesanKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1474, 1023);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormPesanKamar";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_rooms;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.DateTimePicker dtp_checkout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}