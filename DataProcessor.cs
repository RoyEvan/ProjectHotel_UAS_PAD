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
    internal class DataProcessor
    {
        // ======================== CUSTOMERS ========================
        public DataTable GetCustomer()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                "customer_id AS NIK, " +
                "customer_name AS Name, " +
                "customer_address AS Address, " +
                "customer_phone AS Phone " +
            "FROM customers;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetCustomerByPhone(string customer_phone = "8")
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "customer_id AS NIK, " +
                    "customer_name AS Name, " +
                    "customer_address AS Address, " +
                    "customer_phone AS Phone " +
                "FROM customers " +
                "WHERE customer_phone LIKE @customer_phone;", koneksi.getConn());
            cmd.Parameters.AddWithValue("customer_phone", "%" + customer_phone + "%");
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

        // ===========================================================



        // ======================== ROOMS ========================
        public DataTable GetRooms(List<Room> rooms)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                "r.room_id AS ID, " +
                "c.category_id AS CID, " +
                "c.category_name AS Category, " +
                "r.room_price AS price_base, " +
                "CONCAT(\"Rp. \", FORMAT(r.room_price, 0)) AS Price, " +
                "r.is_usable AS Available " +
            "FROM rooms r LEFT OUTER JOIN categories c ON r.category_id = c.category_id;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rooms.Add(new Room(dr["ID"]+"", dr["CID"] + "", dr["Category"] + "", dr["price_base"] + "", dr["price"] + "", Convert.ToBoolean(dr["Available"])));
            }

            dt.Columns.Remove("CID");
            dt.Columns.Remove("price_base");

            return dt;
        }

        public DataTable GetRoomFacilities(string room_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM room_inventory ri LEFT OUTER JOIN room r ON ri.room_id = r.room_id LEFT OUTER JOIN facilities f ON f.facility_id = ri.facility_id WHERE r.room_id = @room_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("room_id", room_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllFcilities()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "facility_id AS ID, " +
                    "facility_name AS Name, " +
                    "price AS price " +
                "FROM facilities;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetFacility(string facility_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "facility_id AS ID, " +
                    "facility_name AS Name, " +
                    "CONCAT(\"Rp. \", FORMAT(price, 0)) AS Price" + 
                    "price AS base_price, " +
                "FROM facilities" +
                "WHERE facility_id = @facility_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("facility_id", facility_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        // =======================================================
    }
}
