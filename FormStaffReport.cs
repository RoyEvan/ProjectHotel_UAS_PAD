using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public partial class FormStaffReport : Form
    {
        public FormStaffReport(string staff_id)
        {
            InitializeComponent();

            CrystalReport_Staff report = new CrystalReport_Staff();
            report.SetDatabaseLogon("root", "", "localhost", "db_project_pad");
            report.SetParameterValue("param_staffid", staff_id);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
