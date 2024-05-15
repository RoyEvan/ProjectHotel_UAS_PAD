using MySql.Data.MySqlClient;
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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
            koneksi.setConn();
        }

        Customer c = new Customer();

        private void btn_submit_Click(object sender, EventArgs e)
        {
            c.InsertCustomer(textNIK.Text, textName.Text, textAddress.Text, textPhone.Text);
        }
    }
}
