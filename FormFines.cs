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
    public partial class FormFines : Form
    {
        DataProcessor dp = new DataProcessor();
        public FormFines()
        {
            InitializeComponent();
        }

        private void FormFines_Load(object sender, EventArgs e)
        {
            dgv_fines.DataSource = dp.GetFines();
        }
        private void resetDGV()
        {
            label2.Text = "0";
            textName.Text = "";
            textFine.Text = "";

            dgv_fines.DataSource = dp.GetFines();
        }

        private void dgv_fines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_fines.Rows[e.RowIndex];
            string id = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string fine = selectedRow.Cells["fine"].Value.ToString();

            label2.Text = id;
            textName.Text = name;
            textFine.Text = fine;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string fine = textFine.Text;

            dp.insertFines(name, fine);
            resetDGV();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = label2.Text;
            string name = textName.Text;
            string fine = textFine.Text;

            dp.updateFines(id, name, fine);
            resetDGV();
        }
    }
}
