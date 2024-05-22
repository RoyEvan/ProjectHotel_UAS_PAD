using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace ProjectHotel_UAS_PAD
{
    public class Staff
    {
        public string id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public Staff(string id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public Staff()
        {
            this.id = null;
            this.name = null;
            this.email = null;
            this.phone = null;
        }
    }
}
