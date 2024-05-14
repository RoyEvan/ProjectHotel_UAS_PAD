﻿using System;
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
    public partial class FormPesanKamar : Form
    {

        Customer c = new Customer();
        Room r = new Room();
        public FormPesanKamar()
        {
            InitializeComponent();
            koneksi.setConn();


            dgv_cust.DataSource = c.GetCustomer();
            dgv_rooms.DataSource = r.GetRooms();
        }
        private void btn_addCust_Click(object sender, EventArgs e)
        {
            FormAddCustomer fa = new FormAddCustomer();
            this.Hide();
        }

        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            dgv_cust.DataSource = c.GetCustomerByPhone(tbox_custPhone.Text);
        }
    }
}
