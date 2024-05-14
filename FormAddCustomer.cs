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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string address = textAddress.Text;
            string phone = textPhone.Text;
            string customer_id = name.Substring(0, 4).ToUpper() + phone.Substring(phone.Length - 4);
            
            MySqlTransaction trans = koneksi.getConn().BeginTransaction();
            try
            {
                FormPesanKamar fpk = new FormPesanKamar();
                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM customers WHERE customer_name = @customer_name " +
                    "AND customer_phone = @customer_phone", koneksi.getConn());
                checkCmd.Parameters.AddWithValue("@customer_name", name);
                checkCmd.Parameters.AddWithValue("@customer_phone", phone);

                object result = checkCmd.ExecuteScalar();
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    MessageBox.Show("Customer sudah terdaftar.");
                    trans.Rollback();
                    fpk.Show();
                    this.Hide();
                }

                MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (customer_id, customer_name, customer_address, " +
                    "customer_phone) VALUES (@customer_id, @customer_name, @customer_address, @customer_phone)", koneksi.getConn());
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@customer_name", name);
                cmd.Parameters.AddWithValue("@customer_address", address);
                cmd.Parameters.AddWithValue("@customer_phone", phone);
                cmd.ExecuteNonQuery();
                trans.Commit();

                MessageBox.Show("Data customer berhasil ditambahkan.");
                fpk.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
        }
    }
}
