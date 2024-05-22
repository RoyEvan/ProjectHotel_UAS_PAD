namespace ProjectHotel_UAS_PAD
{
    partial class FormRoom
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
            this.dgv_rooms = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rb_UpdateFalse = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.rb_UpdateTrue = new System.Windows.Forms.RadioButton();
            this.lbl_RoomIdUpdate = new System.Windows.Forms.Label();
            this.comboBox_update = new System.Windows.Forms.ComboBox();
            this.textBox_update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_InsertFalse = new System.Windows.Forms.RadioButton();
            this.rb_InsertTrue = new System.Windows.Forms.RadioButton();
            this.comboBox_insert = new System.Windows.Forms.ComboBox();
            this.textBox_insert = new System.Windows.Forms.TextBox();
            this.lbl_RoomIdInsert = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AllowUserToResizeColumns = false;
            this.dgv_rooms.AllowUserToResizeRows = false;
            this.dgv_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_rooms.Location = new System.Drawing.Point(18, 22);
            this.dgv_rooms.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.RowHeadersWidth = 51;
            this.dgv_rooms.RowTemplate.Height = 24;
            this.dgv_rooms.Size = new System.Drawing.Size(1046, 270);
            this.dgv_rooms.TabIndex = 0;
            this.dgv_rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rooms_CellClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(929, 302);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Insert";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(998, 302);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Update";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panelUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelInsert);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.dgv_rooms);
            this.panel1.Location = new System.Drawing.Point(20, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 608);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Update Room";
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.panelUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdate.Controls.Add(this.label13);
            this.panelUpdate.Controls.Add(this.btn_Update);
            this.panelUpdate.Controls.Add(this.label14);
            this.panelUpdate.Controls.Add(this.label21);
            this.panelUpdate.Controls.Add(this.label15);
            this.panelUpdate.Controls.Add(this.label20);
            this.panelUpdate.Controls.Add(this.label16);
            this.panelUpdate.Controls.Add(this.label19);
            this.panelUpdate.Controls.Add(this.rb_UpdateFalse);
            this.panelUpdate.Controls.Add(this.label18);
            this.panelUpdate.Controls.Add(this.rb_UpdateTrue);
            this.panelUpdate.Controls.Add(this.lbl_RoomIdUpdate);
            this.panelUpdate.Controls.Add(this.comboBox_update);
            this.panelUpdate.Controls.Add(this.textBox_update);
            this.panelUpdate.Location = new System.Drawing.Point(568, 333);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(496, 253);
            this.panelUpdate.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = ":";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(17, 204);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(460, 28);
            this.btn_Update.TabIndex = 41;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(120, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 61;
            this.label14.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 58);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 16);
            this.label21.TabIndex = 50;
            this.label21.Text = "Room ID ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(120, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 60;
            this.label15.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 83);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 16);
            this.label20.TabIndex = 51;
            this.label20.Text = "Category Room";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(120, 58);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 59;
            this.label16.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 109);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 16);
            this.label19.TabIndex = 52;
            this.label19.Text = "Price";
            // 
            // rb_UpdateFalse
            // 
            this.rb_UpdateFalse.AutoSize = true;
            this.rb_UpdateFalse.Location = new System.Drawing.Point(203, 136);
            this.rb_UpdateFalse.Name = "rb_UpdateFalse";
            this.rb_UpdateFalse.Size = new System.Drawing.Size(58, 17);
            this.rb_UpdateFalse.TabIndex = 58;
            this.rb_UpdateFalse.TabStop = true;
            this.rb_UpdateFalse.Text = "FALSE";
            this.rb_UpdateFalse.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 136);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "Available";
            // 
            // rb_UpdateTrue
            // 
            this.rb_UpdateTrue.AutoSize = true;
            this.rb_UpdateTrue.Location = new System.Drawing.Point(140, 136);
            this.rb_UpdateTrue.Name = "rb_UpdateTrue";
            this.rb_UpdateTrue.Size = new System.Drawing.Size(55, 17);
            this.rb_UpdateTrue.TabIndex = 57;
            this.rb_UpdateTrue.TabStop = true;
            this.rb_UpdateTrue.Text = "TRUE";
            this.rb_UpdateTrue.UseVisualStyleBackColor = true;
            // 
            // lbl_RoomIdUpdate
            // 
            this.lbl_RoomIdUpdate.AutoSize = true;
            this.lbl_RoomIdUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomIdUpdate.Location = new System.Drawing.Point(137, 58);
            this.lbl_RoomIdUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomIdUpdate.Name = "lbl_RoomIdUpdate";
            this.lbl_RoomIdUpdate.Size = new System.Drawing.Size(44, 16);
            this.lbl_RoomIdUpdate.TabIndex = 54;
            this.lbl_RoomIdUpdate.Text = "A1007";
            // 
            // comboBox_update
            // 
            this.comboBox_update.FormatString = "N2";
            this.comboBox_update.FormattingEnabled = true;
            this.comboBox_update.Location = new System.Drawing.Point(140, 83);
            this.comboBox_update.Name = "comboBox_update";
            this.comboBox_update.Size = new System.Drawing.Size(121, 21);
            this.comboBox_update.TabIndex = 56;
            // 
            // textBox_update
            // 
            this.textBox_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_update.Location = new System.Drawing.Point(140, 108);
            this.textBox_update.Name = "textBox_update";
            this.textBox_update.Size = new System.Drawing.Size(235, 20);
            this.textBox_update.TabIndex = 55;
            this.textBox_update.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Insert Room";
            // 
            // panelInsert
            // 
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Controls.Add(this.label12);
            this.panelInsert.Controls.Add(this.label11);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.rb_InsertFalse);
            this.panelInsert.Controls.Add(this.rb_InsertTrue);
            this.panelInsert.Controls.Add(this.comboBox_insert);
            this.panelInsert.Controls.Add(this.textBox_insert);
            this.panelInsert.Controls.Add(this.lbl_RoomIdInsert);
            this.panelInsert.Controls.Add(this.btn_Insert);
            this.panelInsert.Controls.Add(this.label6);
            this.panelInsert.Controls.Add(this.label5);
            this.panelInsert.Controls.Add(this.label4);
            this.panelInsert.Controls.Add(this.label3);
            this.panelInsert.Location = new System.Drawing.Point(18, 333);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(526, 253);
            this.panelInsert.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(122, 136);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(122, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = ":";
            // 
            // rb_InsertFalse
            // 
            this.rb_InsertFalse.AutoSize = true;
            this.rb_InsertFalse.Location = new System.Drawing.Point(205, 136);
            this.rb_InsertFalse.Name = "rb_InsertFalse";
            this.rb_InsertFalse.Size = new System.Drawing.Size(58, 17);
            this.rb_InsertFalse.TabIndex = 45;
            this.rb_InsertFalse.Text = "FALSE";
            this.rb_InsertFalse.UseVisualStyleBackColor = true;
            // 
            // rb_InsertTrue
            // 
            this.rb_InsertTrue.AutoSize = true;
            this.rb_InsertTrue.Checked = true;
            this.rb_InsertTrue.Location = new System.Drawing.Point(142, 136);
            this.rb_InsertTrue.Name = "rb_InsertTrue";
            this.rb_InsertTrue.Size = new System.Drawing.Size(55, 17);
            this.rb_InsertTrue.TabIndex = 44;
            this.rb_InsertTrue.TabStop = true;
            this.rb_InsertTrue.Text = "TRUE";
            this.rb_InsertTrue.UseVisualStyleBackColor = true;
            // 
            // comboBox_insert
            // 
            this.comboBox_insert.FormatString = "C2";
            this.comboBox_insert.FormattingEnabled = true;
            this.comboBox_insert.Location = new System.Drawing.Point(142, 83);
            this.comboBox_insert.Name = "comboBox_insert";
            this.comboBox_insert.Size = new System.Drawing.Size(121, 21);
            this.comboBox_insert.TabIndex = 43;
            // 
            // textBox_insert
            // 
            this.textBox_insert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_insert.Location = new System.Drawing.Point(142, 108);
            this.textBox_insert.Name = "textBox_insert";
            this.textBox_insert.Size = new System.Drawing.Size(235, 20);
            this.textBox_insert.TabIndex = 42;
            this.textBox_insert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // lbl_RoomIdInsert
            // 
            this.lbl_RoomIdInsert.AutoSize = true;
            this.lbl_RoomIdInsert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomIdInsert.Location = new System.Drawing.Point(139, 58);
            this.lbl_RoomIdInsert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomIdInsert.Name = "lbl_RoomIdInsert";
            this.lbl_RoomIdInsert.Size = new System.Drawing.Size(44, 16);
            this.lbl_RoomIdInsert.TabIndex = 41;
            this.lbl_RoomIdInsert.Text = "A1007";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Location = new System.Drawing.Point(19, 204);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(486, 28);
            this.btn_Insert.TabIndex = 40;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Category Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Room ID ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.labelForm);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 35);
            this.panel2.TabIndex = 7;
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.Location = new System.Drawing.Point(17, 9);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(205, 16);
            this.labelForm.TabIndex = 19;
            this.labelForm.Text = "Menu Manager | Master Room";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(1096, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 16);
            this.labelClose.TabIndex = 18;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Master Room";
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRoom";
            this.Text = "MasterKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rooms;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.RadioButton rb_InsertFalse;
        private System.Windows.Forms.RadioButton rb_InsertTrue;
        private System.Windows.Forms.ComboBox comboBox_insert;
        private System.Windows.Forms.TextBox textBox_insert;
        private System.Windows.Forms.Label lbl_RoomIdInsert;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rb_UpdateFalse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rb_UpdateTrue;
        private System.Windows.Forms.Label lbl_RoomIdUpdate;
        private System.Windows.Forms.ComboBox comboBox_update;
        private System.Windows.Forms.TextBox textBox_update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelForm;
    }
}