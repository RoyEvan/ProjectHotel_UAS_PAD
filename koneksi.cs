using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    class koneksi
    {
        static MySqlConnection conn;
        public static MySqlConnection getConn()
        {
            return conn;
        }
        public static void setConn()
        {
            conn = new MySqlConnection(
                $"server=localhost;user=root;database=db_project_pad;"
                );
            conn.Open();
        }
    }
}
