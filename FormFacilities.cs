using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormFacilities : Form
    {
        DataProcessor dp = new DataProcessor();
        public FormFacilities()
        {
            InitializeComponent();
        }
        private void FormFacilities_Load(object sender, EventArgs e)
        {
            dgv_facilities.DataSource = dp.GetFacilities();
        }
        private void resetDGV()
        {
            label2.Text = "0";
            textName.Text = "";
            textPrice.Text = "";

            dgv_facilities.DataSource = dp.GetFacilities();
        }

        private void dgv_facilities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_facilities.Rows[e.RowIndex];
            string id = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string price = selectedRow.Cells["Price"].Value.ToString();

            label2.Text = id;
            textName.Text = name;
            textPrice.Text = price;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string price = textPrice.Text;

            dp.insertFacilities(name, price);
            resetDGV();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = label2.Text;
            string name = textName.Text;
            string price = textPrice.Text;

            dp.updateFacilities(id, name, price);
            resetDGV();
        }
    }
}
