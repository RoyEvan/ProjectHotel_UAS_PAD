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
    public partial class FormCheckoutReport : Form
    {
        public FormCheckoutReport(string bill_id)
        {
            InitializeComponent();

            CrystalReport_Update report = new CrystalReport_Update();
            report.SetDatabaseLogon("root", "");
            report.SetParameterValue("param_billId", bill_id);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
