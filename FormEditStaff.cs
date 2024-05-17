using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormEditStaff : Form
    {
        public FormEditStaff()
        {
            InitializeComponent();
        }
        Staff s = new Staff();
        private void FormEditStaff_Load(object sender, EventArgs e)
        {
            koneksi.setConn();
            dgv_staff.DataSource = s.getStaff();
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
            dgv_staff.DataSource = s.getStaff();
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
            label1.Text = s_id;
            textUsername.Text = s_username;
            textUsername.Enabled = false;
            textPassword.Text = s_password;
            textName.Text = s_name;
            textEmail.Text = s_email;
            textPhone.Text = s_phone;
            cbox_isManager.Checked = s_is_manager;
            cbox_updStatus.Checked = s_is_active;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string s_id = label1.Text;
            string s_username = textUsername.Text;
            string s_password = textPassword.Text;
            string s_name = textName.Text;
            string s_email = textEmail.Text;
            string s_phone = textPhone.Text;
            bool s_is_manager = cbox_isManager.Checked;
            bool s_is_active = cbox_updStatus.Checked;
            s.updateStaff(s_id, s_password, s_name, s_email, s_phone, s_is_manager, s_is_active);
            resetDGV();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string s_username = textUsername.Text;
            string s_password = textPassword.Text;
            string s_name = textName.Text;
            string s_email = textEmail.Text;
            string s_phone = textPhone.Text;
            bool s_is_manager = cbox_isManager.Checked;
            bool s_is_active = cbox_isManager.Checked;
            s.insertStaff(s_username, s_password, s_name, s_email, s_phone, s_is_manager, s_is_active);
            resetDGV();
        }
    }
}
