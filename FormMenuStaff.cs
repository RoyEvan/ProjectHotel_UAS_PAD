using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuStaff : Form
    {
        private Staff staff;
        public FormMenuStaff()
        {
            InitializeComponent();
        }

        public FormMenuStaff(Staff staff)
        {
            InitializeComponent();

            this.staff = staff;

            lbl_staffName.Text += this.staff.name;
        }

        private void btn_formCheckin_Click(object sender, EventArgs e)
        {
            FormCheckin form = new FormCheckin(staff);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_formCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout(staff);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_transLog_Click(object sender, EventArgs e)
        {
            FormTransactionLogs form = new FormTransactionLogs(staff);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
