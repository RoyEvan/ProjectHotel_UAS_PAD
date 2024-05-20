using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormEditStaff : Form
    {
        DataProcessor dp = new DataProcessor();
        public FormEditStaff()
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

                if (choice == 6) connected = koneksi.setConn();
                else if (choice == 7) break;
                else MessageBox.Show("Invalid choice!", "Invalid");
            }

            if (connected) resetDGV();
        }

        private void resetDGV()
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textName.Text = "";
            textEmail.Text = "";
            textPhone.Enabled = false;
            cbox_isManager.Checked = false;
            cbox_updStatus.Checked = false;

            dgv_staff.DataSource = dp.getStaff();
        }
        private void dgv_staff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_staff.Rows[e.RowIndex];
            string s_id = selectedRow.Cells["staff_id"].Value.ToString();
            string s_username = selectedRow.Cells["staff_username"].Value.ToString();
            string s_password = selectedRow.Cells["staff_password"].Value.ToString();
            string s_name = selectedRow.Cells["staff_name"].Value.ToString();
            string s_email = selectedRow.Cells["staff_email"].Value.ToString();
            string s_phone = selectedRow.Cells["staff_phone"].Value.ToString();
            bool s_is_active = (bool)selectedRow.Cells["staff_is_active"].Value;
            bool s_is_manager = (bool)selectedRow.Cells["staff_is_manager"].Value;

            lbl_staffId.Text = s_id;
            textUsername.Text = s_username;
            textUsername.Enabled = false;
            textPassword.Text = s_password;
            textName.Text = s_name;
            textEmail.Text = s_email;
            textPhone.Text = s_phone;
            cbox_isManager.Checked = s_is_manager;
            cbox_updStatus.Checked = s_is_active;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string s_username = textUsername.Text;
            string s_password = textPassword.Text;
            string s_name = textName.Text;
            string s_email = textEmail.Text;
            string s_phone = textPhone.Text;
            bool s_is_manager = cbox_isManager.Checked;
            bool s_is_active = cbox_isManager.Checked;

            dp.insertStaff(s_username, s_password, s_name, s_email, s_phone, s_is_manager, s_is_active);
            resetDGV();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string s_id = lbl_staffId.Text;
            string s_password = textPassword.Text;
            string s_name = textName.Text;
            string s_email = textEmail.Text;
            string s_phone = textPhone.Text;
            bool s_is_manager = cbox_isManager.Checked;
            bool s_is_active = cbox_updStatus.Checked;

            dp.updateStaff(s_id, s_password, s_name, s_email, s_phone, s_is_manager, s_is_active);
            resetDGV();
        }
    }
}
