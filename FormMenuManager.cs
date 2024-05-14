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
