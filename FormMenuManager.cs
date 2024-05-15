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

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditStaff fes = new FormEditStaff();
            this.Hide();
            fes.ShowDialog();
            this.Show();
        }
    }
}
