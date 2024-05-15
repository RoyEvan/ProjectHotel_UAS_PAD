using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuStaff : Form
    {
        public FormMenuStaff()
        {
            InitializeComponent();
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckin form = new FormCheckin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
