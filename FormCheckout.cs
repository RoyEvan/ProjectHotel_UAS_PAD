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
    public partial class FormCheckout : Form
    {
        private Staff staff;
        DataProcessor dp = new DataProcessor();
        List<Fine> fine_list = new List<Fine>();
        List<Bill> bill_list = new List<Bill>();
        double totalFine = 0;
        double totalHotelPrice = 0;
        double grandTotal = 0;

        public FormCheckout()
        {
            InitializeComponent();
        }
        
        public FormCheckout(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;

            ResetAll();
        }

        public void ResetAll()
        {
            dgv_bills.DataSource = dp.GetActiveTransactions(bill_list);
            cbox_fines.DataSource = dp.GetFines();
            cbox_fines.DisplayMember = "AMOUNT";
            cbox_fines.ValueMember = "ID";


        }

        public void RefreshAllTotals()
        {
            totalFine = 0;
            foreach(Fine f in fine_list)
            {
                totalFine += f.fine_base;
            }

            totalHotelPrice = Convert.ToDouble(dgv_bills.CurrentRow.Cells["Total"].Value);
            
            grandTotal = totalFine+totalHotelPrice;

            summary_grandTotal.Text = grandTotal+"";
        }

        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbox_fines.Enabled = true;
            btn_addFine.Enabled = true;
            btn_removeFine.Enabled = true;

        }

        private void btn_addFine_Click(object sender, EventArgs e)
        {
            string fid = cbox_fines.SelectedValue.ToString();

            dp.GetFines(fine_list, fid);

            dgv_addedFines.Rows.Clear();
            dgv_addedFines.Columns.Clear();
            dgv_addedFines.Columns.Add("ID", "ID");
            dgv_addedFines.Columns.Add("NAME", "NAME");
            dgv_addedFines.Columns.Add("AMOUNT", "AMOUNT");

            foreach (Fine f in fine_list)
            {
                dgv_addedFines.Rows.Add(f.id, f.name, f.amount);
            }

            RefreshAllTotals();
        }

        private void btn_removeFine_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }
    }
}
