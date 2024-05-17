using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormMenuStaff : Form
    {
        public FormMenuStaff()
        {
            InitializeComponent();
        }
        
        //public FormMenuStaff(DataTable staffData)
        //{
        //    InitializeComponent();
        //}

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckin form = new FormCheckin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnLogTransaction_Click(object sender, EventArgs e)
        {
            FormTransactionLogs form = new FormTransactionLogs();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
