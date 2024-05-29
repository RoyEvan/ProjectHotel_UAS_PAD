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
        DataProcessor dp = new DataProcessor();
        public FormTransactionLogsManager(Staff staff)
        {
            InitializeComponent();

            this.staff = staff;

            lbl_staffName.Text += this.staff.name;

            dgv_receipts.DataSource = dp.GetTransactions();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(comboBoxTransaction.SelectedItem == "Facilities")
            {
                CrystalReport_Facilities facRep = new CrystalReport_Facilities();
                facRep.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
                crystalReportViewer1.ReportSource = facRep;
            }
            else if(comboBoxTransaction.SelectedItem == "Daily")
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
                CrystalReport_Yearly yearlyRep = new CrystalReport_Yearly();
                yearlyRep.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
                yearlyRep.SetParameterValue("requester", this.staff.name);
                crystalReportViewer1.ReportSource = yearlyRep;

            }
        }

        private void dgv_receipts_DoubleClick(object sender, EventArgs e)
        {
            string bill_id = dgv_receipts.CurrentRow.Cells[0].Value.ToString();

            CrystalReport_Checkout report = new CrystalReport_Checkout();
            report.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
            report.SetParameterValue("param_billId", bill_id);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
