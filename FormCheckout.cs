using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        List<List<string>> room_inv = new List<List<string>>();
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
            dgv_addedFines.Rows.Clear();

            cbox_fines.DataSource = dp.GetFines("A0100");
            cbox_fines.DisplayMember = "AMOUNT";
            cbox_fines.ValueMember = "ID";
            tbox_roomId.Text = "";
            summary_billId.Text = "NOTA11072024115999";
            summary_custId.Text = "3578121212121212";
            summary_roomId.Text = "A0100";
            summary_oldBillTotal.Text = "0";
            summary_totalFines.Text = "0";
            summary_grandTotal.Text = "0";

            cbox_fines.Enabled = false;
            btn_addFine.Enabled = false;
            dgv_addedFines.Enabled = false;
            btn_removeFine.Enabled = false;
        }

        public void RefreshAllTotals()
        {
            totalFine = 0;
            foreach(Fine f in fine_list)
            {
                totalFine += f.fine;
            }

            Bill bill = new Bill();
            foreach(Bill b in bill_list)
            {
                if(b.id == dgv_bills.CurrentRow.Cells["ID"].Value.ToString())
                {
                    bill = b;
                    break;
                }
            }

            totalHotelPrice = bill.total;
            
            grandTotal = totalFine+totalHotelPrice;

            summary_oldBillTotal.Text = "Rp. " + totalHotelPrice.ToString("N0");
            summary_totalFines.Text = "Rp. " + totalFine.ToString("N0");
            summary_grandTotal.Text = "Rp. " + grandTotal.ToString("N0"); ;
        }

        public void RefreshFines()
        {
            dgv_addedFines.Rows.Clear();
            dgv_addedFines.Columns.Clear();
            dgv_addedFines.Columns.Add("ID", "ID");
            dgv_addedFines.Columns.Add("NAME", "NAME");
            dgv_addedFines.Columns.Add("AMOUNT", "AMOUNT");

            foreach (Fine f in fine_list)
            {
                dgv_addedFines.Rows.Add(f.id, f.name, "Rp. " + f.fine.ToString("N0"));
            }
        }
        
        public void PrintReport()
        {

        }

        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            summary_billId.Text = dgv_bills.CurrentRow.Cells["ID"].Value.ToString();
            summary_custId.Text = dgv_bills.CurrentRow.Cells["NIK"].Value.ToString();
            summary_roomId.Text = dgv_bills.CurrentRow.Cells["Room"].Value.ToString();
            cbox_fines.Enabled = true;

            cbox_fines.DataSource = dp.GetFines(dgv_bills.CurrentRow.Cells["Room"].Value.ToString());
            cbox_fines.DisplayMember = "AMOUNT";
            cbox_fines.ValueMember = "ID";

            btn_addFine.Enabled = true;
            btn_removeFine.Enabled = true;
            btn_checkout.Enabled = true;
            btn_extend.Enabled = true;

            RefreshAllTotals();
        }

        private void btn_addFine_Click(object sender, EventArgs e)
        {
            string fid = cbox_fines.SelectedValue.ToString();

            dp.GetFines(fine_list, fid);
            
            RefreshFines();

            RefreshAllTotals();

            dgv_addedFines.Enabled = true;
            //btn_removeFine.Enabled = true;
        }

        private void btn_removeFine_Click(object sender, EventArgs e)
        {
            string fid = dgv_addedFines.CurrentRow.Cells["ID"].Value.ToString();

            int index = 0;
            foreach(Fine f in fine_list)
            {
                if(f.id == fid)
                {
                    break;
                }
                index++;
            }

            fine_list.RemoveAt(index);

            RefreshFines();
            RefreshAllTotals();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            string bid = dgv_bills.CurrentRow.Cells["ID"].Value.ToString();

            bool checkedOut = dp.FinishTransaction(bid, fine_list);

            if (checkedOut)
            {
                MessageBox.Show("Checked Out successfully!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAll();
            }
            else MessageBox.Show("Transaction Failed!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void btn_extend_Click(object sender, EventArgs e)
        {
            string bid = dgv_bills.CurrentRow.Cells["ID"].Value.ToString();
            bool checkedOut = dp.FinishTransaction(bid, fine_list);

            if (checkedOut)
            {
                ResetAll();

                FormCheckIn f = new FormCheckIn(staff, bid);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Transaction Failed!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_cancelTrans_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btn_searchBill_Click(object sender, EventArgs e)
        {

            string rid = tbox_roomId.Text.TrimStart().TrimEnd();

            if (rid == "" || rid == " ")
            {
                tbox_roomId.Text = "";
                MessageBox.Show("There is no room with ID ''!");
            }
            else
            {
                dgv_bills.DataSource = dp.GetActiveTransactions(bill_list, rid);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
