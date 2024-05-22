using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            lbl_staffName.Text = this.staff.name;
        }

        private void FormMenuStaff_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void btn_formCheckin_Click(object sender, EventArgs e)
        {
            FormCheckIn form = new FormCheckIn(staff);
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
            FormTransactionLogsStaff form = new FormTransactionLogsStaff(staff);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
