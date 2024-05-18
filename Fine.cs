using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    public class Fine
    {

        public string id { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public double fine_base { get; set; }

        public Fine(string id, string name, double fine_base, string amount)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.fine_base = fine_base;
        }

        public Fine()
        {
            this.id = null;
            this.name = null;
            this.amount = null;
            this.fine_base = 0.0;
        }
    }
}
