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
        public int room_inventory_id { get; set; }
        public Fine(string id, string name, double fine, int room_inventory_id = 0)
        {
            this.id = id;
            this.name = name;
            this.fine = fine;
            this.room_inventory_id = room_inventory_id;
        }

        public Fine()
        {
            this.id = null;
            this.name = null;
            this.fine = 0;
            this.room_inventory_id = 0;
        }
    }
}
