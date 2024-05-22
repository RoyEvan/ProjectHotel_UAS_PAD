using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuManager : Form
    {
        private Staff staff;
        public FormMenuManager()
        {
            InitializeComponent();
        }

        public FormMenuManager(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            lbl_staffName.Text = this.staff.name;
            labelForm.Text = labelForm.Text += "Staff Master";
        }

        private void btn_formEditStaff_Click(object sender, EventArgs e)
        {
            FormEditStaff fes = new FormEditStaff();
            this.Hide();
            fes.ShowDialog();
            this.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_transLog_Click(object sender, EventArgs e)
        {
            FormTransactionLogsManager ftlm = new FormTransactionLogsManager();
            this.Hide();
            ftlm.ShowDialog();
            this.Show();
        }

        private void btn_editFacilities_Click(object sender, EventArgs e)
        {
            FormFacilities ffa = new FormFacilities();
            this.Hide();
            ffa.ShowDialog();
            this.Show();
        }

        private void btn_editVouchers_Click(object sender, EventArgs e)
        {
            FormVouchers fv = new FormVouchers();
            this.Hide();
            fv.ShowDialog();
            this.Show();
        }

        private void btn_editFines_Click(object sender, EventArgs e)
        {
            FormFines ffi = new FormFines();
            this.Hide();
            ffi.ShowDialog();
            this.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            FormRoom fr = new FormRoom();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
    }
}
