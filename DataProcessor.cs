using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                rooms.Add(new Room(dr["ID"]+"", dr["CID"] + "", dr["Category"] + "", Convert.ToInt64(dr["price_base"]), dr["price"] + "", Convert.ToBoolean(dr["Available"])));
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

        // =======================================================


        // ======================== FACILITIES ========================
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
            MySqlCommand cmd = new MySqlCommand("SELECT facility_id AS ID, facility_name AS Name, CONCAT('Rp. ', FORMAT(price, 0)) AS Price, price AS base_price FROM facilities WHERE facility_id = @facility_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("facility_id", facility_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        // ============================================================


        // ======================== VOUCHERS ========================
        public DataRow GetVoucher(string facility_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vouchers WHERE voucher_id = @voucher_id AND date_start <= NOW() AND date_end >= NOW();", koneksi.getConn());
            cmd.Parameters.AddWithValue("voucher_id", facility_id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count <= 0)
            {
                return null;
            }

            return dt.Rows[0];
        }

        public double GetDiscount(string voucher_id, double currentTotal)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vouchers WHERE voucher_id = @voucher_id AND date_start <= @now AND date_end >= @now;", koneksi.getConn());
            cmd.Parameters.AddWithValue("voucher_id", voucher_id);
            cmd.Parameters.AddWithValue("now", DateTime.Now);
            MySqlDataReader dr = cmd.ExecuteReader();
            long discValue = 0;
            while (dr.Read()) {
                discValue = dr.GetInt64("VOUCHER");
            }
            dr.Close();

            
            return discValue;
        }
        // ==========================================================

        // ======================== TRANSACTIONS ========================
        public bool InsertTransaction(
            string room_id,
            string voucher_id,
            string staff_id,
            string customer_id,
            DateTime checkin_date,
            DateTime checkout_date,
            double bill_total,
            double bill_grandTotal,
            List<Facility> addedFacilities
        ) {
            MySqlTransaction trans = koneksi.getConn().BeginTransaction();
            try
            {
                // Gets all the current date and time
                string day, month, year, hour, minute, second, ampm;
                day = (DateTime.Now.Day.ToString()).PadLeft(2, '0');
                month = (DateTime.Now.Month.ToString()).PadLeft(2, '0');
                year = (DateTime.Now.Year.ToString()).PadLeft(4, '0');
                hour = (DateTime.Now.Hour.ToString()).PadLeft(2, '0');
                minute = (DateTime.Now.Minute.ToString()).PadLeft(2, '0');
                second = (DateTime.Now.Second.ToString()).PadLeft(2, '0');


                // Gets all the checkout date and time
                string dayo, montho, yearo, houro, minuteo, secondo;
                dayo = (checkout_date.Day.ToString()).PadLeft(2, '0');
                montho = (checkout_date.Month.ToString()).PadLeft(2, '0');
                yearo = (checkout_date.Year.ToString()).PadLeft(4, '0');
                houro = (checkout_date.Hour.ToString()).PadLeft(2, '0');
                minuteo = (checkout_date.Minute.ToString()).PadLeft(2, '0');
                secondo = (checkout_date.Second.ToString()).PadLeft(2, '0');

                // Prepares the date
                string checkin_date_s = day + '/' + month + '/' + year + ' ' + hour + ':' + minute + ":" + second;
                string checkout_date_s = dayo + '/' + montho + '/' + yearo + ' ' + houro + ':' + minuteo + ":" + secondo;

                // Prepares the Bill ID
                string bill_id = "NOTA" + day + month + year + hour + minute + second;

                MessageBox.Show(checkin_date_s + " - " + checkout_date_s);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO bills(" +
                        "BILL_ID, ROOM_ID, VOUCHER_ID, STAFF_ID, " +
                        "CUSTOMER_ID, CHECKIN_DATE, CHECKOUT_DATE, " +
                        "BILL_TOTAL, BILL_GRANDTOTAL, BILL_STATUS) " +
                    "VALUES (@BILL_ID, @ROOM_ID, @VOUCHER_ID, @STAFF_ID, " +
                        "@CUSTOMER_ID, STR_TO_DATE(@CHECKIN_DATE, @DATE_FORMAT), " +
                        "STR_TO_DATE(@CHECKOUT_DATE, @DATE_FORMAT), @BILL_TOTAL, " +
                        "@BILL_GRANDTOTAL, 1);", 
                    koneksi.getConn()
                );

                cmd.Parameters.AddWithValue("BILL_ID", bill_id);
                cmd.Parameters.AddWithValue("ROOM_ID", room_id);
                cmd.Parameters.AddWithValue("VOUCHER_ID", voucher_id);
                cmd.Parameters.AddWithValue("STAFF_ID", staff_id);
                cmd.Parameters.AddWithValue("CUSTOMER_ID", customer_id);
                cmd.Parameters.AddWithValue("CHECKIN_DATE", checkin_date_s);
                cmd.Parameters.AddWithValue("CHECKOUT_DATE", checkout_date_s);
                cmd.Parameters.AddWithValue("DATE_FORMAT", "%d/%m/%Y %H:%i:%s");
                cmd.Parameters.AddWithValue("BILL_TOTAL", bill_total);
                cmd.Parameters.AddWithValue("BILL_GRANDTOTAL", 0);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < addedFacilities.Count; i++)
                {
                    cmd = new MySqlCommand("INSERT INTO d_bills(FACILITY_ID, BILL_ID, QTY) VALUES (@facility_id, @bill_id, @qty)", koneksi.getConn());
                    cmd.Parameters.AddWithValue("facility_id", addedFacilities[i].id);
                    cmd.Parameters.AddWithValue("bill_id", bill_id);
                    cmd.Parameters.AddWithValue("qty", addedFacilities[i].qty);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message.ToString());

                // return false because insertion was 
                return false;
            }

            // If no exceptions caught then return true,
            // True means the transaction (Data Insertion) is successfully completed
            return true;
        }
        
        public DataTable GetActiveTransactions(List<Bill> bills)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "b.bill_id AS ID, " +
                    "b.room_id AS Room, " +
                    "b.staff_id AS SID, " +
                    "b.customer_id AS NIK, " +
                    "b.checkin_date AS \"Check In\", " +
                    "b.checkout_date AS \"Check Out\", " +
                    "b.bill_total AS total_base, " +
                    "CONCAT(\"Rp. \", FORMAT(b.bill_total, 0)) AS Total, " +
                    "b.bill_grandtotal AS \"Grand Total\", " +
                    "s.staff_name AS Staff, " +
                    "c.customer_name AS Customer " +
                "FROM bills b LEFT OUTER JOIN staffs s ON b.staff_id = s.staff_id LEFT OUTER JOIN customers c ON b.customer_id = c.customer_id " +
                "WHERE b.bill_status = 1;",
                koneksi.getConn()
            );
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                bills.Add(new Bill(
                    dr["ID"]+"",
                    dr["Room"]+"",
                    dr["SID"]+"",
                    dr["NIK"]+"",
                    dr["Check In"]+"",
                    dr["Check Out"]+"",
                    Convert.ToDouble(dr["total_base"]),
                    dr["Total"]+"",
                    Convert.ToDouble(dr["Grand Total"]),
                    dr["Staff"]+"",
                    dr["Customer"]+""
                ));
            }

            dt.Columns.Remove("SID");
            dt.Columns.Remove("Grand Total");

            return dt;
        }

        public bool FinishTransaction(string bill_id)
        {
            
            return true;
        }

        public DataTable GetBills(List<Room> rooms)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM bills WHERE bill_status = 1;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rooms.Add(new Room(dr["ID"] + "", dr["CID"] + "", dr["Category"] + "", Convert.ToInt64(dr["price_base"]), dr["price"] + "", Convert.ToBoolean(dr["Available"])));
            }

            dt.Columns.Remove("CID");
            dt.Columns.Remove("price_base");

            return dt;
        }
        // ==============================================================

        // ======================== STAFFS ========================

        //INSERT INTO staffs(STAFF_ID, STAFF_NAME, STAFF_EMAIL, STAFF_PHONE, STAFF_IS_ACTIVE, STAFF_IS_MANAGER, STAFF_USERNAME, STAFF_PASSWORD) VALUES('', '', '', '', '', '', '', '');
        public DataTable getStaff()
        {
            MySqlDataAdapter da =
                new MySqlDataAdapter("select staff_id, staff_username, staff_password, staff_name, staff_email, staff_phone, " +
                "staff_is_manager, staff_is_active from staffs ", koneksi.getConn());
            DataTable dt = new DataTable("staff");
            da.Fill(dt);
            return dt;
        }

        public void updateStaff(string s_id, string s_password, string s_name, string s_email, string s_phone, bool s_is_manager, bool s_is_active)
        {
            MySqlCommand cmd = new MySqlCommand(
                $"UPDATE staffs SET staff_password = @s_password, staff_name = @s_name, staff_email = @s_email, " +
                $"staff_phone = @s_phone, staff_is_active = @s_is_active, staff_is_manager = @s_is_manager WHERE staff_id = @s_id",
                koneksi.getConn());

            cmd.Parameters.AddWithValue("@s_id", s_id);
            cmd.Parameters.AddWithValue("@s_password", s_password);
            cmd.Parameters.AddWithValue("@s_name", s_name);
            cmd.Parameters.AddWithValue("@s_email", s_email);
            cmd.Parameters.AddWithValue("@s_phone", s_phone);
            cmd.Parameters.AddWithValue("@s_is_manager", s_is_manager);
            cmd.Parameters.AddWithValue("@s_is_active", s_is_active);
            cmd.ExecuteNonQuery();
        }

        public void insertStaff(string s_username, string s_password, string s_name, string s_email, string s_phone, bool s_is_manager, bool s_is_active)
        {
            MySqlCommand getlastId = new MySqlCommand("SELECT staff_id FROM staffs ORDER BY staff_id DESC LIMIT 1", koneksi.getConn());
            string lastStaffId = (string)getlastId.ExecuteScalar();

            int lastId = int.Parse(lastStaffId.Substring(1));
            string nextStaffId = "S" + (lastId + 1).ToString("D3");

            MySqlCommand cmd = new MySqlCommand(
                $"insert into staffs (staff_id, staff_name, staff_email, staff_phone, staff_is_active, staff_is_manager, " +
                $"staff_username, staff_password) values(@s_id, @s_name, @s_email, @s_phone, @s_is_active, @s_is_manager, @s_username, @s_password)"
                , koneksi.getConn());

            cmd.Parameters.AddWithValue("@s_id", nextStaffId);
            cmd.Parameters.AddWithValue("@s_name", s_name);
            cmd.Parameters.AddWithValue("@s_email", s_email);
            cmd.Parameters.AddWithValue("@s_phone", s_phone);
            cmd.Parameters.AddWithValue("@s_is_active", s_is_active);
            cmd.Parameters.AddWithValue("@s_is_manager", s_is_manager);
            cmd.Parameters.AddWithValue("@s_username", s_username);
            cmd.Parameters.AddWithValue("@s_password", s_password);
            cmd.ExecuteNonQuery();
        }
        // ========================================================

        // ======================== FINES ========================
        public DataTable GetFines()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT FINE_ID AS ID, CONCAT(CONCAT(FINE_NAME,\" - \"), CONCAT(\"Rp. \", FORMAT(fine, 0))) AS AMOUNT FROM fines;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void GetFines(List<Fine> addedFines, string fine_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT FINE_ID AS ID, FINE_NAME AS NAME, FINE AS FINE_BASE, CONCAT(\"Rp. \", FORMAT(fine, 0)) AS AMOUNT FROM fines WHERE fine_id = @fine_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("fine_id", fine_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                addedFines.Add(new Fine(dr["ID"]+"", dr["NAME"]+"", Convert.ToDouble(dr["FINE_BASE"]), dr["AMOUNT"]+""));
            }
        }
        // =======================================================

    }
}
