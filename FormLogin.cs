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
            koneksi.setConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT staff_is_manager FROM staffs WHERE staff_username = @Username " +
                    "AND staff_password = @Password", koneksi.getConn());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool isManager = reader.GetBoolean("staff_is_manager");

                    if (isManager)
                    {
                        FormMenuManager fmm = new FormMenuManager();
                        fmm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormMenuStaff fms = new FormMenuStaff();
                        fms.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT staff_is_manager FROM staffs WHERE staff_username = @Username " +
                    "AND staff_password = @Password", koneksi.getConn());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool isManager = reader.GetBoolean("staff_is_manager");

                    if (isManager)
                    {
                        FormMenuManager fmm = new FormMenuManager();
                        fmm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormMenuStaff fms = new FormMenuStaff();
                        fms.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
