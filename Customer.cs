using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    public class Customer
    {
        public string id {
            get; set;
        }
        public string name
        {
            get; set;
        }

        public Customer(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
