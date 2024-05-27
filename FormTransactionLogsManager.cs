using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormTransactionLogsManager : Form
    {
        Staff staff;
        public FormTransactionLogsManager(Staff staff)
        {
            InitializeComponent();

            this.staff = staff;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(comboBoxTransaction.SelectedItem == "Daily")
            {
                CrystalReport_Daily dailyRep = new CrystalReport_Daily();
                dailyRep.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
                dailyRep.SetParameterValue("requester", this.staff.name);
                crystalReportViewer1.ReportSource = dailyRep;
            }
            else if(comboBoxTransaction.SelectedItem == "Monthly")
            {
                CrystalReport_Monthly monthlyRep = new CrystalReport_Monthly();
                monthlyRep.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
                monthlyRep.SetParameterValue("requester", this.staff.name);
                crystalReportViewer1.ReportSource = monthlyRep;
            }
            else if(comboBoxTransaction.SelectedItem == "Yearly")
            {

            }

            //CrystalReport_Transaction rep = new CrystalReport_Transaction();
            //string selectedTransaction = comboBoxTransaction.SelectedItem.ToString();
            //rep.SetDatabaseLogon("root", "");
            //rep.SetParameterValue("paramTransaction", selectedTransaction);
            //crystalReportViewer1.ReportSource = rep;
        }
    }
}
