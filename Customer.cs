using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    internal class Customer
    {
        public DataTable GetCustomerByPhone(string customer_phone)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE customer_phone = @customer_phone;", koneksi.getConn());
            cmd.Parameters.AddWithValue("phone_number", customer_phone);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetCustomer() 
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                "customer_id AS NIK, " +
                "customer_name AS Name, " +
                "customer_address AS Address, " +
                "customer_address AS Phone " +
            "FROM customers;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertCustomer(string customer_id, string name, string address, string phone)
        {
            MySqlTransaction trans = koneksi.getConn().BeginTransaction();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (customer_id, customer_name, customer_address, " +
                        "customer_phone) VALUES (@customer_id, @customer_name, @customer_address, @customer_phone)", koneksi.getConn());
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@customer_name", name);
                cmd.Parameters.AddWithValue("@customer_address", address);
                cmd.Parameters.AddWithValue("@customer_phone", phone);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Data customer berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        
    }
}
