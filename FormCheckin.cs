using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormCheckin : Form
    {

        Customer c = new Customer();
        Room r = new Room();
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
            dgv_cust.DataSource = c.GetCustomer();
            dgv_rooms.DataSource = r.GetRooms();
            dgv_facility.DataSource = r.GetAllFcilities();
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

        private void dgv_rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                String NIK = dgv_cust.Rows[e.RowIndex].Cells[0].Value.ToString();
                String name = dgv_cust.Rows[e.RowIndex].Cells[1].Value.ToString();

                summary_custName.Text = name;
            }
        }

        private void dtp_checkout_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_checkout.Value <= DateTime.Now) {
                MessageBox.Show("Minus");
                dtp_checkout.Value = (DateTime.Now.AddDays(1));
            }
            else
            {
                int days = dtp_checkout.Value.Day - DateTime.Now.Day;

                summary_days.Text = days.ToString();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
