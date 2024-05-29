namespace ProjectHotel_UAS_PAD
{
    partial class FormTransactionLogsManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTransaction = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgv_receipts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Type of Reports :";
            // 
            // comboBoxTransaction
            // 
            this.comboBoxTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTransaction.FormattingEnabled = true;
            this.comboBoxTransaction.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly",
            "Facilities"});
            this.comboBoxTransaction.Location = new System.Drawing.Point(253, 66);
            this.comboBoxTransaction.Name = "comboBoxTransaction";
            this.comboBoxTransaction.Size = new System.Drawing.Size(189, 33);
            this.comboBoxTransaction.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(459, 63);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(133, 37);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(17, 106);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1304, 401);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // dgv_receipts
            // 
            this.dgv_receipts.AllowUserToAddRows = false;
            this.dgv_receipts.AllowUserToDeleteRows = false;
            this.dgv_receipts.AllowUserToResizeRows = false;
            this.dgv_receipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_receipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receipts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_receipts.Location = new System.Drawing.Point(3, 69);
            this.dgv_receipts.Name = "dgv_receipts";
            this.dgv_receipts.RowHeadersWidth = 51;
            this.dgv_receipts.RowTemplate.Height = 24;
            this.dgv_receipts.Size = new System.Drawing.Size(572, 295);
            this.dgv_receipts.TabIndex = 4;
            this.dgv_receipts.DoubleClick += new System.EventHandler(this.dgv_receipts_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_receipts);
            this.panel1.Location = new System.Drawing.Point(17, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 369);
            this.panel1.TabIndex = 5;
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.Location = new System.Drawing.Point(12, 9);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(228, 32);
            this.lbl_staffName.TabIndex = 10;
            this.lbl_staffName.Text = "Welcome back, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Double Click the Selected Row to View Transaction";
            // 
            // FormTransactionLogsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1333, 899);
            this.Controls.Add(this.lbl_staffName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.comboBoxTransaction);
            this.Controls.Add(this.label1);
            this.Name = "FormTransactionLogsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransactionLogsManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransaction;
        private System.Windows.Forms.Button Submit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dgv_receipts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Label label2;
    }
}