using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuManager : Form
    {
        public FormMenuManager()
        {
            InitializeComponent();
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
    }
}
