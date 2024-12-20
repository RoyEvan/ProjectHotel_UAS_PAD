﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormCheckin : Form
    {
        DataProcessor dp = new DataProcessor();
        private Staff s;
        List<Room> room_list = new List<Room>();
        List<Facility> addedFacility_list = new List<Facility>();
        string nik = "";
        long roomPrice = 0;
        double grandTotal = 0;
        double discounts = 0;
        bool discounted = false;
        bool extendingRoomMode = false;


        public FormCheckin(Staff staff, string bill_id)
        {
            InitializeComponent();
            this.s = staff;
            extendingRoomMode = true;

            ResetAll();

            Bill bill = dp.GetActiveTransactions(bill_id);
            dp.GetFacilityByBillID(bill_id, addedFacility_list);


            dtp_checkout.Value = DateTime.Now.AddDays(1);

            summary_custNIK.Text = bill.nik;
            summary_custName.Text = bill.cust_name;
            summary_roomLocation.Text = "Lorong " + bill.room_id.Substring(0, 1) + " Lantai " + Convert.ToInt16(bill.room_id.Substring(1, 2));
            summary_roomNumber.Text = bill.room_id.Substring(3, 2);

            foreach (Room r in room_list)
            {
                if (r.id == bill.room_id)
                {
                    summary_roomCategory.Text = r.category;
                }
            }

            foreach (Room r in room_list)
            {
                if (r.id == bill.room_id) roomPrice = r.price_base;
            }

            dgv_addedFacilities.Rows.Clear();
            dgv_addedFacilities.Columns.Add("ID", "ID");
            dgv_addedFacilities.Columns.Add("Name", "Name");
            dgv_addedFacilities.Columns.Add("Price", "Price");
            dgv_addedFacilities.Columns.Add("Qty", "Qty");
            foreach (Facility f in addedFacility_list)
            {
                dgv_addedFacilities.Rows.Add(f.id, f.name, f.price, f.qty);
            }

            summary_days.Text = "1";
            summary_roomPrice.Text = "Rp. " + roomPrice.ToString("N0");

            panel_summary.Enabled = true;
            dgv_rooms.Enabled = true;
            dgv_facility.Enabled = true;
            dtp_checkout.Enabled = true;
            btn_addFacility.Enabled = true;
            btn_checkin.Enabled = true;

            if (addedFacility_list.Count > 0)
            {
                dgv_addedFacilities.Enabled = true;
                btn_removeAddedFac.Enabled = true;
                tbox_voucherId.Enabled = true;
                btn_checkVoucher.Enabled = true;
            }

            RefreshAllTotals();
        }

        public FormCheckin(Staff staff)
        {
            InitializeComponent();
            this.s = staff;

            ResetAll();
        }

        public void ResetAll()
        {
            // Reset All The Global Variables value
            dp = new DataProcessor();
            room_list = new List<Room>();
            addedFacility_list = new List<Facility>();
            nik = "";
            roomPrice = 0;
            grandTotal = 0;
            discounts = 0;
            discounted = false;
            lbl_staffName.Text = "Hello, " + s.name;

            // Fills all DataGridViews
            dgv_cust.DataSource = dp.GetCustomer();
            dgv_rooms.DataSource = dp.GetRooms(room_list);
            dgv_facility.DataSource = dp.GetAllFacilities();


            // Reset the Summary
            dtp_checkout.Value = (DateTime.Now.AddDays(1));
            
            summary_custNIK.Text = "1234561212120001";
            summary_custName.Text = "Unknown";
            summary_roomLocation.Text = "Lorong X Lantai Y";
            summary_roomNumber.Text = "Z";
            summary_roomCategory.Text = "AaBb CcDd";

            dgv_addedFacilities.Rows.Clear();

            summary_totalFacPrice.Text = "0";
            summary_roomPrice.Text = "0";
            summary_days.Text = "1";
            summary_roomFacTotalPrice.Text = "0";
            
            tbox_voucherId.Text = "";
            
            summary_voucherName.Text = "No Voucher";
            summary_totalDisc.Text = "0";
            summary_grandTotal.Text = "0";


            // Disables the Properties so that the user can't input randomly
            panel_summary.Enabled = false;
            dgv_rooms.Enabled = false;
            dgv_facility.Enabled = false;
            dtp_checkout.Enabled = false;
            btn_addFacility.Enabled = false;
            btn_checkin.Enabled = false;
            dgv_addedFacilities.Enabled = false;
            btn_removeAddedFac.Enabled = false;
            tbox_voucherId.Enabled = false;
            btn_checkVoucher.Enabled = false;
            btn_applyVoucher.Enabled = false;
        }

        public void RefreshAllTotals()
        {
            long totalFacPrice = 0;

            foreach (Facility f in addedFacility_list)
            {
                totalFacPrice += (f.price_base * f.qty);
            }

            short days = (short)Math.Ceiling(dtp_checkout.Value.Subtract(DateTime.Now).TotalDays);
            summary_totalFacPrice.Text = "Rp. " + totalFacPrice.ToString("N0");
            summary_roomFacTotalPrice.Text = "Rp. " + (totalFacPrice + (roomPrice * days)).ToString("N0");
            
            grandTotal = (totalFacPrice + (roomPrice * days));

            double afterDisc = 0;
            if (discounts > 0)
            {
                if (discounts <= 100) afterDisc = (grandTotal * 1.0 * ((100.0 - discounts) * 1.0 / 100.0));
                else afterDisc = grandTotal - discounts;
            }

            if(afterDisc != 0) grandTotal = afterDisc;

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
            fa.ShowDialog();
            this.Show();

            ResetAll();
        }

        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            dgv_cust.DataSource = dp.GetCustomerByPhone(tbox_custPhone.Text);
        }

        private void dtp_checkout_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_checkout.Value <= DateTime.Now) {
                MessageBox.Show("Check Out Date must be at least set to tomorrow!");
                dtp_checkout.Value = (DateTime.Now.AddDays(1));
            }
            else
            {
                short days = (short) Math.Ceiling(dtp_checkout.Value.Subtract(DateTime.Now).TotalDays);

                summary_days.Text = days.ToString();

                RefreshAllTotals();
            }
        }

        private void dgv_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nik = dgv_cust.Rows[e.RowIndex].Cells[0].Value.ToString();
                String name = dgv_cust.Rows[e.RowIndex].Cells[1].Value.ToString();

                summary_custNIK.Text = nik;
                summary_custName.Text = name;

                dgv_rooms.Enabled = true;
            }
        }

        private void dgv_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_rooms.Enabled)
            {
                if(Convert.ToBoolean(dgv_rooms.Rows[e.RowIndex].Cells[3].Value))
                {
                    string roomId = dgv_rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string category = dgv_rooms.Rows[e.RowIndex].Cells[1].Value.ToString();

                    summary_roomLocation.Text = "Lorong " + roomId.Substring(0, 1) + " Lantai " + Convert.ToInt16(roomId.Substring(1, 2));
                    summary_roomNumber.Text = roomId.Substring(3, 2);
                    summary_roomCategory.Text = category;

                    foreach(Room r in room_list)
                    {
                        if(r.id == roomId) roomPrice = r.price_base;
                    }


                    summary_roomPrice.Text = "Rp. " + roomPrice.ToString("N0");

                    panel_summary.Enabled = true;

                    dgv_facility.Enabled = true;
                    dtp_checkout.Enabled = true;
                    btn_addFacility.Enabled = true;
                    btn_checkin.Enabled = true;

                    RefreshAllTotals();
                }
                else
                {
                    MessageBox.Show("Room is in use!", "Room Availability");
                }
            }
        }

        private void btn_addFacility_Click(object sender, EventArgs e)
        {
            dgv_addedFacilities.Enabled = true;
            btn_removeAddedFac.Enabled = true;

            if(!discounted)
            {
                tbox_voucherId.Enabled = true;
                btn_checkVoucher.Enabled = true;
            }

            string fid = dgv_facility.CurrentRow.Cells[0].Value+"";

            DataTable dt = dp.GetFacility(fid);
            
            foreach(DataRow dr in dt.Rows)
            {
                if (addedFacility_list.Count == 0) addedFacility_list.Add(new Facility(dr["ID"] + "", dr["Name"] + "", Convert.ToInt64(dr["price_base"].ToString()), dr["Price"]+""));
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

                    if(!exists) addedFacility_list.Add(new Facility(dr["ID"] + "", dr["Name"] + "", Convert.ToInt64(dr["price_base"].ToString()), dr["price"]+""));
                }
            }

            RefreshAddedFacilities();

            RefreshAllTotals();
        }

        private void btn_removeAddedFac_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(dgv_addedFacilities.CurrentRow.Cells[0].Value);
            int index = dgv_addedFacilities.CurrentRow.Index;
            if(!discounted)
            {
                dgv_addedFacilities.Rows.RemoveAt(index);


                for(int i=0; i<addedFacility_list.Count; i++)
                {
                    Facility f = addedFacility_list[i];

                    if(f.id == fid.ToString()) index = i;
                }

                addedFacility_list.RemoveAt(index);

                RefreshAddedFacilities();
                RefreshAllTotals();
            }
            else
            {
                int listIndex = -1;
                bool removeable = true;
                string vid = tbox_voucherId.Text;
                DataRow dr = dp.GetVoucher(vid);
                Facility f = new Facility();

                for (int i = 0; i < addedFacility_list.Count; i++)
                {
                    Facility fac = addedFacility_list[i];

                    if (fid.ToString() == fac.id.ToString())
                    {
                        f = fac;
                        removeable = false;

                        listIndex = i;
                        break;
                    }
                }

                if(!removeable)
                {
                    // 6 = yes
                    // 7 = no
                    int choice = (int)MessageBox.Show("Your voucher will also be removed.\nDo you still want to remove this item?\nName : " + f.name + "\nPrice : " + f.price, "Item not removable", MessageBoxButtons.YesNo);
                    
                    if(choice == 6)
                    {
                        // Removes the discounts
                        discounted = false;
                        discounts = 0;

                        // Removes the selected item from the list
                        addedFacility_list.RemoveAt(listIndex);

                        RefreshAddedFacilities();
                        RefreshAllTotals();

                        // Re-Enables all vouchers inputs and buttons
                        tbox_voucherId.Text = "";
                        tbox_voucherId.Enabled = true;
                        btn_checkVoucher.Enabled = true;
                        btn_applyVoucher.Enabled = true;
                    }
                }
                else
                {
                    addedFacility_list.RemoveAt(index);

                    RefreshAddedFacilities();
                    RefreshAllTotals();
                }
            }
        }

        private void btn_applyVoucher_Click(object sender, EventArgs e)
        {
            string vid = tbox_voucherId.Text.TrimStart().TrimEnd();
            discounted = true;

            if (vid == "" || vid == " ")
            {
                MessageBox.Show("Please fill before applying!");
                btn_applyVoucher.Enabled = false;
            }
            else
            {

                if (discounted)
                {

                    discounts = dp.GetDiscount(vid, grandTotal);
                    DataRow dr = dp.GetVoucher(vid);
                    summary_voucherName.Text = dr["VOUCHER_NAME"].ToString();

                    if (discounts <= 100) summary_totalDisc.Text = discounts + "%";
                    else summary_totalDisc.Text = "Rp. " + discounts.ToString("N0");
                }
            }


            RefreshAllTotals();

            tbox_voucherId.Enabled = false;
            btn_checkVoucher.Enabled = false;
            btn_applyVoucher.Enabled = false;

            
        }

        private void btn_checkVoucher_Click(object sender, EventArgs e)
        {
            string vid = tbox_voucherId.Text.TrimStart().TrimEnd();

            if (vid == "" || vid == " ")
            {
                MessageBox.Show("Please fill before checking!");
            }
            else
            {
                DataRow dr = dp.GetVoucher(vid);
                bool canBeUsed = false;
                if(!(dr is null))
                {
                    foreach(Facility f in addedFacility_list)
                    {
                        if(dr["facility_id"].ToString() == f.id.ToString())
                        {
                            MessageBox.Show("Voucher is available!");
                            btn_applyVoucher.Enabled = true;
                            canBeUsed = true;
                        }
                    }
                }
                if (!canBeUsed) {
                    MessageBox.Show("Voucher unavailable or does not satisfy the requirements!");
                    tbox_voucherId.Text = "";
                }
            }
        }

        private void btn_cancelTrans_Click(object sender, EventArgs e)
        {
            ResetAll();

            if (extendingRoomMode) this.Close();
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            // Preparing the data for inputs
            string room_id = dgv_rooms.CurrentRow.Cells[0].Value.ToString();
            string voucher_id = null;

            if(voucher_id == "") voucher_id = tbox_voucherId.Text;

            string staff_id = this.s.id;
            string customer_id = nik;
            DateTime checkin_date = DateTime.Now;
            DateTime checkout_date = dtp_checkout.Value;
            double bill_total = grandTotal;
            double bill_grandTotal = 0;

            //MessageBox.Show(checkin_date + " - " + checkout_date);

            bool completed = dp.InsertTransaction(
                room_id, voucher_id, staff_id,
                customer_id, checkin_date, checkout_date,
                bill_total, bill_grandTotal, addedFacility_list
            );

            if (completed)
            {
                ResetAll();

                if (extendingRoomMode) this.Close();
            }
            else MessageBox.Show("Transaction Failed!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
    }
}
