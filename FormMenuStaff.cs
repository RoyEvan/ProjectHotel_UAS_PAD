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
