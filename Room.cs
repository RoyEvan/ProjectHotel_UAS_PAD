using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Contracts;

namespace ProjectHotel_UAS_PAD
{
    internal class Room
    {
        public DataTable GetRooms()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT " +
                "r.room_id AS ID, " +
                "c.category_name AS Category, " +
                "CONCAT(\"Rp. \", FORMAT(r.room_price, 0)) AS Price, " +
                "r.is_usable AS Available " +
            "FROM rooms r LEFT OUTER JOIN categories c ON r.category_id = c.category_id;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertRoom()
        {

        }

        public void UpdateRoom()
        {

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
            MySqlCommand cmd = new MySqlCommand("SELECT facility_id AS ID, facility_name AS Name, price AS Price FROM facilities;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        
    }
}
