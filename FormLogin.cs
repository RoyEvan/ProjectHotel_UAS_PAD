using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            SetConnection();
        }

        public void SetConnection()
        {
            bool connected = koneksi.setConn();
            int choice = 0;

            while (!connected)
            {
                MessageBox.Show("Failed to establish a connection with MySQL Database!", "Database Error");
                choice = (int)MessageBox.Show("Do you want to reconnect?", "Reconnect Database", MessageBoxButtons.YesNo);

                if (choice == 6)
                    connected = koneksi.setConn();
                else if (choice == 7)
                    break;
                else
                    MessageBox.Show("Invalid choice!", "Invalid");
            }
        }

        public void CloseConnection()
        {
            koneksi.closeConn();
        }

        public void ResetAll() {
            textUsername.Text = "";
            textPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM staffs WHERE staff_username = @Username AND staff_password = @Password AND staff_is_active = 1;", koneksi.getConn());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();
                String staff_id = "";
                String staff_name = "";
                String staff_email = "";
                String staff_phone = "";
                bool isManager = false;
                bool exists = false;

                // initiate an object "staff"
                Staff staff = new Staff();

                if (reader.Read())
                {
                    // Collects all the data to be stored in an object "staff"
                    staff_id = reader.GetString("STAFF_ID");
                    staff_name = reader.GetString("STAFF_NAME");
                    staff_email = reader.GetString("STAFF_EMAIL");
                    staff_phone = reader.GetString("STAFF_PHONE");
                    isManager = reader.GetBoolean("staff_is_manager");

                    // Creates an object "staff" from the collected data above
                    staff = new Staff(staff_id, staff_name, staff_email, staff_phone);
                    exists = true;
                }
                reader.Close();

                if (!exists) MessageBox.Show("Username atau password salah.");
                else
                {
                    if (isManager)
                    {
                        FormMenuManager fmm = new FormMenuManager(staff);
                        this.Hide();
                        ResetAll();
                        fmm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        FormMenuStaff fms = new FormMenuStaff(staff);
                        this.Hide();
                        ResetAll();
                        fms.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }
    }
}
