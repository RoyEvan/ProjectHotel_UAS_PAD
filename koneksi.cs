using MySql.Data.MySqlClient;

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
