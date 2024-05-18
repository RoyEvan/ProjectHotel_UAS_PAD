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
    public partial class FormTransactionLogs : Form
    {
        private Staff staff;
        public FormTransactionLogs()
        {
            InitializeComponent();
        }
        
        public FormTransactionLogs(Staff staff)
        {
            InitializeComponent();

            this.staff = staff;
        }
    }
}
