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
            dgv_fines.DataSource = dp.GetAllFines();
        }
        private void resetDGV()
        {
            label2.Text = "0";
            textName.Text = "";
            textFine.Text = "";

            dgv_fines.DataSource = dp.GetAllFines();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {

        }

        private void labelForm_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFine_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_fines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
