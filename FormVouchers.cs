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
    public partial class FormVouchers : Form
    {
        DataProcessor dp = new DataProcessor();
        public FormVouchers()
        {
            InitializeComponent();
        }

        private void FormVouchers_Load(object sender, EventArgs e)
        {
            dgv_vouchers.DataSource = dp.getVouchers();
        }
        private void resetDGV()
        {
            label2.Text = "0";
            textVoucherName.Text = "";
            textFacilitiesID.Text = "";
            textAmount.Text = "";

            dgv_vouchers.DataSource = dp.getVouchers();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            string day2 = dateTimePicker2.Value.Day.ToString();
            string month2 = dateTimePicker2.Value.Month.ToString();
            string year2 = dateTimePicker2.Value.Year.ToString();
            string v_name = textVoucherName.Text;
            string f_id = textFacilitiesID.Text;
            string amount = textAmount.Text;
            string tgl_start = day + "-" + month + "-" + year;
            string tgl_end = day2 + "-" + month2 + "-" + year2;

            dp.insertVouchers(f_id, v_name, amount, tgl_start, tgl_end);
            resetDGV();
        }

        private void dgv_vouchers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
