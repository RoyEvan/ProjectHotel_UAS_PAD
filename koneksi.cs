using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    class koneksi
    {
        static MySqlConnection conn;
        public static MySqlConnection getConn()
        {
            return conn;
        }
        public static bool setConn()
        {
            try
            {
                conn = new MySqlConnection(
                    $"server=localhost;user=root;database=db_project_pad;"
                    );
                conn.Open();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
