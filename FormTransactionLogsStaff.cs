using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormTransactionLogsStaff : Form
    {
        DataProcessor dp = new DataProcessor();
        private Staff staff;
        public FormTransactionLogsStaff()
        {
            InitializeComponent();
        }
        
        public FormTransactionLogsStaff(Staff staff)
        {
            InitializeComponent();
            dgv_transactionlogsstaff.DataSource = dp.getTransactionsStaff();
            this.staff = staff;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string customerName = textsearchcust.Text.Trim();
            if (!string.IsNullOrEmpty(customerName))
            {
                dgv_transactionlogsstaff.DataSource = dp.getTransactionsByCustomerName(customerName);
            }
            else
            {
                MessageBox.Show("Please enter customer name to search.");
            }
        }
    }
}
