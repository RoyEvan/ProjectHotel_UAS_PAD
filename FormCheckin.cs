using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormCheckin : Form
    {

        DataProcessor dp = new DataProcessor();
        List<Room> room_list = new List<Room>();
        List<Facility> addedFacility_list = new List<Facility>();
        string nik = "";
        long roomPrice = 0;
        double grandTotal = 0;
        double discounts = 0;
        bool discounted = false;

        public FormCheckin()
        {
            InitializeComponent();
            koneksi.setConn();

            ResetAll();
        }

        public void ResetAll()
        {
            // Set dateTimePicker to Tomorrow!
            dtp_checkout.Value = (DateTime.Now.AddDays(1));

            // Fills all DataGridViews
            dgv_cust.DataSource = dp.GetCustomer();
            dgv_rooms.DataSource = dp.GetRooms(room_list);
            dgv_facility.DataSource = dp.GetAllFcilities();
        }

        public void RefreshAllTotals()
        {
            long totalFacPrice = 0;

            foreach (Facility f in addedFacility_list)
            {
                totalFacPrice += (f.base_price * f.qty);
            }

            int days = (dtp_checkout.Value.Day - DateTime.Now.Day);
            summary_totalFacPrice.Text = "Rp. " + totalFacPrice.ToString("N0");
            summary_roomFacTotalPrice.Text = "Rp. " + (totalFacPrice + (roomPrice * days)).ToString("N0");
            
            grandTotal = (totalFacPrice + (roomPrice * days)) - discounts;
            summary_grandTotal.Text = "Rp. " + grandTotal.ToString("N0");
        }

        public void RefreshAddedFacilities()
        {
            // Refreshes DGV Added Facilities
            dgv_addedFacilities.Rows.Clear();
            dgv_addedFacilities.Columns.Clear();
            dgv_addedFacilities.Columns.Add("ID", "ID");
            dgv_addedFacilities.Columns.Add("Name", "Name");
            dgv_addedFacilities.Columns.Add("Price", "Price");
            dgv_addedFacilities.Columns.Add("Qty", "Qty");

            foreach (Facility f in addedFacility_list)
            {
                dgv_addedFacilities.Rows.Add(f.id, f.name, f.price, f.qty);
            }
        }

        private void btn_addCust_Click(object sender, EventArgs e)
        {
            FormAddCustomer fa = new FormAddCustomer();
            this.Hide();
        }

        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            dgv_cust.DataSource = dp.GetCustomerByPhone(tbox_custPhone.Text);
        }

        private void dtp_checkout_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_checkout.Value <= DateTime.Now) {
                MessageBox.Show("Minus");
                dtp_checkout.Value = (DateTime.Now.AddDays(1));
            }
            else
            {
                short days =  (short)(dtp_checkout.Value.Day - DateTime.Now.Day);

                summary_days.Text = days.ToString();

                RefreshAllTotals();
            }
        }

        private void dgv_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String NIK = dgv_cust.Rows[e.RowIndex].Cells[0].Value.ToString();
                String name = dgv_cust.Rows[e.RowIndex].Cells[1].Value.ToString();

                summary_custNIK.Text = NIK;
                summary_custName.Text = name;
                nik = NIK;

                dgv_rooms.Enabled = true;
            }
        }

        private void dgv_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_rooms.Enabled)
            {
                string roomId = dgv_rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                string category = dgv_rooms.Rows[e.RowIndex].Cells[1].Value.ToString();

                summary_roomLocation.Text = "Lorong " + roomId.Substring(0, 1) + " Lantai " + Convert.ToInt16(roomId.Substring(1, 2));
                summary_roomNumber.Text = roomId.Substring(3, 2);
                summary_roomCategory.Text = category;

                foreach(Room r in room_list)
                {
                    if(r.id == roomId)
                    {
                        roomPrice = r.price_base;
                    }
                }

                summary_roomPrice.Text = "Rp. " + roomPrice.ToString("N0");

                panel_summary.Enabled = true;

                dgv_facility.Enabled = true;
                dtp_checkout.Enabled = true;
                btn_addFacility.Enabled = true;
                btn_checkin.Enabled = true;
            }
        }

        private void btn_addFacility_Click(object sender, EventArgs e)
        {
            btn_removeAddedFac.Enabled = true;
            tbox_voucherId.Enabled = true;
            btn_checkVoucher.Enabled = true;

            string fid = dgv_facility.CurrentRow.Cells[0].Value+"";

            DataTable dt = dp.GetFacility(fid);
            
            foreach(DataRow dr in dt.Rows)
            {
                if (addedFacility_list.Count == 0) addedFacility_list.Add(new Facility(dr["ID"] + "", dr["Name"] + "", Convert.ToInt64(dr["base_price"].ToString()), dr["Price"] + ""));
                else
                {
                    bool exists = false;
                    foreach (Facility f in addedFacility_list)
                    {
                        if (f.id == fid) {
                            f.qty++;
                            exists = true;
                            break;
                        }
                    }

                    if(!exists) addedFacility_list.Add(new Facility(dr["ID"] + "", dr["Name"] + "", Convert.ToInt64(dr["base_price"].ToString()), dr["Price"] + ""));
                }
            }

            RefreshAddedFacilities();

            RefreshAllTotals();
        }

        private void btn_removeAddedFac_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(dgv_addedFacilities.CurrentRow.Cells[0].Value);
            int index = dgv_addedFacilities.CurrentRow.Index;
            dgv_addedFacilities.Rows.RemoveAt(index);


            for(int i=0; i<addedFacility_list.Count; i++)
            {
                Facility f = addedFacility_list[i];

                if(f.id == fid.ToString())
                {
                    index = i;
                }
            }

            addedFacility_list.RemoveAt(index);

            RefreshAddedFacilities();
            RefreshAllTotals();
        }

        private void btn_applyVoucher_Click(object sender, EventArgs e)
        {
            if (!discounted)
            {
                string vid = tbox_voucherId.Text;

                double afterDisc = dp.GetVoucher(vid, grandTotal);
                discounts = grandTotal - afterDisc;
                MessageBox.Show(afterDisc + "");
                MessageBox.Show(grandTotal + "");

                RefreshAllTotals();

                discounted = true;
                tbox_voucherId.Enabled = false;
                btn_checkVoucher.Enabled = false;
                btn_applyVoucher.Enabled = false;
            }
            else
            {
                MessageBox.Show("You can only use 1 voucher code at a time!");
            }
        }

        private void btn_checkVoucher_Click(object sender, EventArgs e)
        {
            string vid = tbox_voucherId.Text.TrimStart().TrimEnd();
            tbox_voucherId.Text = vid;

            if (tbox_voucherId.Text.TrimStart().TrimEnd() == "" || tbox_voucherId.Text.TrimStart().TrimEnd() == " ")
            {
                MessageBox.Show("Please fill before checking!");
            }


            DataRow dr = dp.GetVoucher(vid);

            foreach(Facility f in addedFacility_list)
            {
                if (dr["facility_id"] == f.id)
                {
                    MessageBox.Show("Ketemu!");
                }
            }
        }

        //
    }
}
