namespace ProjectHotel_UAS_PAD
{
    partial class FormTransactionLogsStaff
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
            this.dgv_transactionlogsstaff = new System.Windows.Forms.DataGridView();
            this.textsearchcust = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionlogsstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transactionlogsstaff
            // 
            this.dgv_transactionlogsstaff.AllowUserToAddRows = false;
            this.dgv_transactionlogsstaff.AllowUserToDeleteRows = false;
            this.dgv_transactionlogsstaff.AllowUserToResizeColumns = false;
            this.dgv_transactionlogsstaff.AllowUserToResizeRows = false;
            this.dgv_transactionlogsstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transactionlogsstaff.Location = new System.Drawing.Point(12, 12);
            this.dgv_transactionlogsstaff.Name = "dgv_transactionlogsstaff";
            this.dgv_transactionlogsstaff.ReadOnly = true;
            this.dgv_transactionlogsstaff.RowHeadersVisible = false;
            this.dgv_transactionlogsstaff.RowHeadersWidth = 51;
            this.dgv_transactionlogsstaff.RowTemplate.Height = 24;
            this.dgv_transactionlogsstaff.Size = new System.Drawing.Size(803, 531);
            this.dgv_transactionlogsstaff.TabIndex = 0;
            // 
            // textsearchcust
            // 
            this.textsearchcust.Location = new System.Drawing.Point(836, 12);
            this.textsearchcust.Name = "textsearchcust";
            this.textsearchcust.Size = new System.Drawing.Size(209, 22);
            this.textsearchcust.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1051, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FormTransactionLogsStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 555);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textsearchcust);
            this.Controls.Add(this.dgv_transactionlogsstaff);
            this.Name = "FormTransactionLogsStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransactionLogsStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionlogsstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transactionlogsstaff;
        private System.Windows.Forms.TextBox textsearchcust;
        private System.Windows.Forms.Button Search;
    }
}