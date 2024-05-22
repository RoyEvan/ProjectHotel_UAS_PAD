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
        public double fine { get; set; }

        public Fine(string id, string name, double fine)
        {
            this.id = id;
            this.name = name;
            this.fine = fine;
        }

        public Fine()
        {
            this.id = null;
            this.name = null;
            this.fine = 0;
        }
    }
}
