using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ProjectHotel_UAS_PAD
{
    class Staff
    {
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
    }
}
