using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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


        public void insertRoom(string category, long price, bool available)
        {
            MySqlCommand getlastId = new MySqlCommand("SELECT room_id FROM rooms ORDER BY room_id DESC LIMIT 1", koneksi.getConn());
            string lastStaffId = (string)getlastId.ExecuteScalar();

            int lastId = int.Parse(lastStaffId.Substring(1));
            string nextStaffId = "A" + (lastId + 1).ToString("D4");

            MySqlCommand getCateoryId = new MySqlCommand("SELECT CATEGORY_ID FROM categories WHERE CATEGORY_NAME = @available", koneksi.getConn());
            getCateoryId.Parameters.AddWithValue("@available", category);
            object result = getCateoryId.ExecuteScalar();
            string r_category = result.ToString();

            MySqlCommand cmd = new MySqlCommand(
                $"insert into rooms (room_id, category_id, room_price, is_usable) values(@r_id, @r_category, @r_price, @r_usable)"
                , koneksi.getConn());

            cmd.Parameters.AddWithValue("@r_id", nextStaffId);
            cmd.Parameters.AddWithValue("@r_category",r_category);
            cmd.Parameters.AddWithValue("@r_price", price);
            cmd.Parameters.AddWithValue("@r_usable", available);
            cmd.ExecuteNonQuery();
        }

        public void updateRoom(string id, string category, long price, bool available)
        {
            MySqlCommand getCateoryId = new MySqlCommand("SELECT CATEGORY_ID FROM categories WHERE CATEGORY_NAME = @available", koneksi.getConn());
            getCateoryId.Parameters.AddWithValue("@available", category);
            object result = getCateoryId.ExecuteScalar();
            string r_category = result.ToString();

            MySqlCommand cmd = new MySqlCommand(
                $"UPDATE rooms SET room_id = @r_id, category_id = @r_category, room_price = @r_price, is_usable = @r_usable  WHERE room_id = @r_id", koneksi.getConn());

            cmd.Parameters.AddWithValue("@r_id", id);
            cmd.Parameters.AddWithValue("@r_category", r_category);
            cmd.Parameters.AddWithValue("@r_price", price);
            cmd.Parameters.AddWithValue("@r_usable", available);
            cmd.ExecuteNonQuery();
        }

        // ============================================================


        // ======================== FACILITIES ========================
        public DataTable GetAllFacilities()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "facility_id AS ID, " +
                    "facility_name AS Name, " +
                    "price AS price_base, " +
                    "CONCAT('Rp. ', FORMAT(price, 0)) AS Price " +
                "FROM facilities;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable GetFacilities()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "facility_id AS ID, " +
                    "facility_name AS Name, " +
                    "price AS Price " +
                "FROM facilities", koneksi.getConn());
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
                "price AS price_base, " +
                "CONCAT('Rp. ', FORMAT(price, 0)) AS Price " +
            "FROM facilities WHERE facility_id = @facility_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("facility_id", facility_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public DataTable GetFacilityByBillID(string bill_id, List<Facility> facility_list)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "f.facility_id AS ID, " +
                    "f.facility_name AS NAME, " +
                    "f.price AS price_base, " +
                    "CONCAT(\"Rp. \", FORMAT(f.price, 0)) AS Price," +
                    "d.qty AS Qty " +
                "FROM d_bills d LEFT OUTER JOIN facilities f ON d.facility_id = f.facility_id " +
                "WHERE bill_id = @bill_id; ", koneksi.getConn());
            cmd.Parameters.AddWithValue("bill_id", bill_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                facility_list.Add(new Facility(dr["ID"] + "", dr["Name"] + "", Convert.ToInt64(dr["price_base"].ToString()), dr["Price"] + "", Convert.ToInt32(dr["Qty"])));
            }

            dt.Columns.Remove("price_base");

            return dt;
        }

        public void insertFacilities(string name, string price)
        {
            MySqlCommand cmd = new MySqlCommand(
                $"insert into facilities (facility_name, price) values(@name, @price)"
                , koneksi.getConn());

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();
        }

        public void updateFacilities(string id, string name, string price)
        {
            MySqlCommand cmd = new MySqlCommand(
                $"UPDATE facilities SET facility_name = @name, price = @price WHERE facility_id = @id", koneksi.getConn());

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();
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
        public DataTable getTransactionsStaff()
        {
            MySqlDataAdapter da =
                new MySqlDataAdapter("select b.room_id as ID, s.staff_name as Staff, c.customer_name as Customer, b.checkin_date, b.checkout_date, " +
                "b.bill_status from bills b join staffs s on b.staff_id = s.staff_id " +
                "join customers c on b.customer_id = c.customer_id", koneksi.getConn());
            DataTable dt = new DataTable("transactionlogs");
            da.Fill(dt);
            return dt;
        }
        public DataTable getTransactionsByCustomerName(string customerName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT b.room_id AS ID, s.staff_name AS Staff, c.customer_name AS Customer, " +
                "b.checkin_date, b.checkout_date, b.bill_status FROM bills b " +
                "JOIN staffs s ON b.staff_id = s.staff_id " +
                "JOIN customers c ON b.customer_id = c.customer_id " +
                "WHERE c.customer_name LIKE @customerName", koneksi.getConn());
            cmd.Parameters.AddWithValue("@customerName", "%" + customerName + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
                    
            return dt;
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
                    Convert.ToDouble(dr["Grand Total"]),
                    dr["Staff"]+"",
                    dr["Customer"]+""
                ));
            }

            dt.Columns.Remove("SID");
            dt.Columns.Remove("total_base");
            dt.Columns.Remove("Grand Total");

            return dt;
        }

        public DataTable GetActiveTransactions(List<Bill> bills, string room_id)
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
                "WHERE b.bill_status = 1 AND b.room_id LIKE @room_id;",
                koneksi.getConn()
            );
            cmd.Parameters.AddWithValue("room_id", "%" + room_id + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                bills.Add(new Bill(
                    dr["ID"] + "",
                    dr["Room"] + "",
                    dr["SID"] + "",
                    dr["NIK"] + "",
                    dr["Check In"] + "",
                    dr["Check Out"] + "",
                    Convert.ToDouble(dr["total_base"]),
                    Convert.ToDouble(dr["Grand Total"]),
                    dr["Staff"] + "",
                    dr["Customer"] + ""
                ));
            }

            dt.Columns.Remove("SID");
            dt.Columns.Remove("total_base");
            dt.Columns.Remove("Grand Total");

            return dt;
        }

        public Bill GetActiveTransactions(string bill_id)
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
                "WHERE b.bill_status = 1 AND b.bill_id = @bill_id;",
                koneksi.getConn()
            );
            cmd.Parameters.AddWithValue("bill_id", bill_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            Bill bill = new Bill();
            
            foreach(DataRow dr in dt.Rows)
            {
                bill = new Bill(
                    dr["ID"] + "",
                    dr["Room"] + "",
                    dr["SID"] + "",
                    dr["NIK"] + "",
                    dr["Check In"] + "",
                    dr["Check Out"] + "",
                    Convert.ToDouble(dr["total_base"]),
                    Convert.ToDouble(dr["Grand Total"]),
                    dr["Staff"] + "",
                    dr["Customer"] + ""
                );
            }

            return bill;
        }
        public bool FinishTransaction(string bill_id, List<Fine> fines)
        {
            MySqlTransaction trans = koneksi.getConn().BeginTransaction();
            try
            {
                MySqlCommand cmd;

                double totalFine = 0;
                if(fines.Count > 0)
                {
                    foreach(Fine f in fines)
                    {
                        totalFine += f.fine;

                        cmd = new MySqlCommand("INSERT INTO d_fines(FINE_ID, BILL_ID) VALUES (@fine_id, @bill_id);", koneksi.getConn());
                        cmd.Parameters.AddWithValue("fine_id", f.id);
                        cmd.Parameters.AddWithValue("bill_id", bill_id);

                        cmd.ExecuteNonQuery();
                    }
                }

                
                cmd = new MySqlCommand("UPDATE bills SET CHECKOUT_DATE = NOW(), BILL_GRANDTOTAL = (BILL_TOTAL + @grand_total), BILL_STATUS = 0 WHERE BILL_ID = @bill_id;", koneksi.getConn());
                cmd.Parameters.AddWithValue("grand_total", totalFine);
                cmd.Parameters.AddWithValue("bill_id", bill_id);

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch(Exception ex)
            {
                trans.Rollback();

                MessageBox.Show(ex.Message.ToString());

                return false;
            }

            // If no exceptions caught then return true,
            // True means the checkout transaction is successfully completed
            return true;
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
        public DataTable GetFines(string room_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                    "f.fine_id AS ID, " +
                    "CONCAT(" +
                        "CONCAT(" +
                            "CONCAT(\"Rp. \", FORMAT(f.fine, 0)), " +
                            "\" - \"" +
                        "), " +
                        "CONCAT(" +
                            "CONCAT(f.FINE_NAME, \" - \"), " +
                            "ri.room_inventory_name" +
                        ")" +
                    ") AS AMOUNT " +
                "FROM fines f INNER JOIN room_inventory ri ON f.fine_id = ri.fine_id " +
                "WHERE ri.room_id = @room_id;",
                koneksi.getConn()
            );
            cmd.Parameters.AddWithValue("room_id", room_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void GetFines(List<Fine> addedFines, string fine_id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT FINE_ID AS ID, FINE_NAME AS NAME, FINE FROM fines WHERE fine_id = @fine_id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("fine_id", fine_id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                addedFines.Add(new Fine(dr["ID"]+"", dr["NAME"]+"", Convert.ToDouble(dr["FINE"])));
            }
        }

        public DataTable GetAllFines()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT fine_id AS ID, fine_name AS NAME,fine FROM fines", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void insertFines(string name, string fine)
        {
            MySqlCommand getLastId = new MySqlCommand("SELECT MAX(fine_id) FROM fines", koneksi.getConn());
            object lastIdObj = getLastId.ExecuteScalar();
            int lastId = 0;

            if (lastIdObj != null && lastIdObj != DBNull.Value)
            {
                int.TryParse(lastIdObj.ToString().Substring(4), out lastId); // Mengambil angka setelah "FINE"
            }

            string nextFinesId = "FINE" + (lastId + 1).ToString("D4");


            MySqlCommand cmd = new MySqlCommand(
                $"insert into fines (fine_id, fine_name, fine) values(@id, @name, @fine)"
                , koneksi.getConn());

            cmd.Parameters.AddWithValue("@id", nextFinesId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fine", fine);
            cmd.ExecuteNonQuery();
        }

        public void updateFines(string id, string name, string fine)
        {
            MySqlCommand cmd = new MySqlCommand(
                $"UPDATE fines SET fine_name = @name, fine = @fine WHERE fine_id = @id", koneksi.getConn());

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fine", fine);
            cmd.ExecuteNonQuery();
        }
        // =======================================================


        // ======================== Master Rooms ========================

        


        // ========================================================
    }
}
