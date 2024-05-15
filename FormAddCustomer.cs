using System;
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
