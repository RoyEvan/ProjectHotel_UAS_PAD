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

        DataProcessor dp = new DataProcessor();

        private void btn_submit_Click(object sender, EventArgs e)
        {
            dp.InsertCustomer(textNIK.Text, textName.Text, textAddress.Text, textPhone.Text);
            MessageBox.Show("Success Add Customer");
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
