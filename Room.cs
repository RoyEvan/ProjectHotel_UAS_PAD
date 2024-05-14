using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    internal class Room
    {
        public DataTable GetRooms()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rooms;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertRoom()
        {

        }
    }
}
