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
        public FormTransactionLogsManager()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            CrystalReport_Transaction rep = new CrystalReport_Transaction();
            string selectedTransaction = comboBoxTransaction.SelectedItem.ToString();
            rep.SetDatabaseLogon("root", "");
            rep.SetParameterValue("paramTransaction", selectedTransaction);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
