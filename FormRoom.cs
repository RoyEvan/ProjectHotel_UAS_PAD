using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Numerics;
using MySql.Data.MySqlClient;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormRoom : Form
    {

        DataProcessor dp = new DataProcessor();
        List<Room> room_list = new List<Room>();

        public FormRoom()
        {
            InitializeComponent();
            FillComboBoxesWithCategories();
            ResetAll();
        }

        private void FillComboBoxesWithCategories()
        {
            HashSet<string> categories = new HashSet<string>();

            foreach (var room in room_list)
            {
                categories.Add(room.category);
            }

            comboBox_insert.Items.AddRange(categories.ToArray());
            comboBox_update.Items.AddRange(categories.ToArray());
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panelInsert.Enabled = true;
                panelUpdate.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                panelInsert.Enabled = false;
                panelUpdate.Enabled = true;
            }
        }

        public void cekId()
        {
            MySqlCommand getlastId = new MySqlCommand("SELECT room_id FROM rooms ORDER BY room_id DESC LIMIT 1", koneksi.getConn());
            string lastStaffId = (string)getlastId.ExecuteScalar();
            int lastId = int.Parse(lastStaffId.Substring(1));
            string nextStaffId = "A" + (lastId + 1).ToString("D4");

            lbl_RoomIdInsert.Text = nextStaffId;
        }

        public void ResetAll()
        {
            // Fills all DataGridViews
            dgv_rooms.DataSource = dp.GetRooms(room_list);
            panelInsert.Enabled = true;
            panelUpdate.Enabled = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            FillComboBoxesWithCategories();
            cekId();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string roomId = dgv_rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
            string category = dgv_rooms.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (Convert.ToBoolean(dgv_rooms.Rows[e.RowIndex].Cells[3].Value))
            {
                rb_UpdateTrue.Checked = true;
                rb_UpdateFalse.Checked = false;
            }
            else 
            {
                rb_UpdateTrue.Checked = false;
                rb_UpdateFalse.Checked = true;
            }

            lbl_RoomIdUpdate.Text = roomId;
            comboBox_update.SelectedItem = category;
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string category = comboBox_insert.SelectedItem.ToString();
            long price = long.Parse(textBox_insert.Text);
            bool available = true;

            if (rb_InsertTrue.Checked)
            {
                available = true;
            }
            else if (rb_InsertFalse.Checked)
            {
                available = false;
            }

            dp.insertRoom(category, price, available);
            MessageBox.Show("Success Insert");
            ResetAll();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = lbl_RoomIdUpdate.Text;
            string category = comboBox_update.SelectedItem.ToString();
            long price = long.Parse(textBox_update.Text);
            bool available = true;

            if (rb_UpdateTrue.Checked)
            {
                available = true;
            }
            else if (rb_UpdateFalse.Checked)
            {
                available = false;
            }

            dp.updateRoom(id, category, price, available);
            MessageBox.Show("Success Update");
            ResetAll();
        }
    }
}
