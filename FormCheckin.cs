﻿using System;
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

            // Refreshes DGV Added Facilities
            dgv_addedFacilities.Rows.Clear();
            dgv_addedFacilities.Columns.Clear();
            dgv_addedFacilities.Columns.Add("ID", "ID");
            dgv_addedFacilities.Columns.Add("Name", "Name");
            dgv_addedFacilities.Columns.Add("Price", "Price");
            dgv_addedFacilities.Columns.Add("Qty", "Qty");

            long totalFacPrice = 0;

            foreach(Facility f in addedFacility_list)
            {
                dgv_addedFacilities.Rows.Add(f.id, f.name, f.price, f.qty);

                totalFacPrice += (f.base_price * f.qty);
            }

            summary_totalFacPrice.Text = "Rp. " + totalFacPrice.ToString("N0");
        }

        private void btn_checkVoucher_Click(object sender, EventArgs e)
        {
            string vid = tbox_voucherId.Text;


        }
    }
}
