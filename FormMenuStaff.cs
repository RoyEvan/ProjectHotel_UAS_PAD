using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuStaff : Form
    {
        public FormMenuStaff()
        {
            InitializeComponent();
        }
        
        //public FormMenuStaff(DataTable staffData)
        //{
        //    InitializeComponent();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            FormCheckin form = new FormCheckin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTransactionLogs form = new FormTransactionLogs();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
