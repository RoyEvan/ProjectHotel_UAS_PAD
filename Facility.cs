using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    internal class Facility
    {
        public string id { get; set; }
        public string name { get; set; }
        public long base_price { get; set; }
        public string price { get; set; }

        public int qty { get; set; }

        public Facility(string id, string name, long base_price, string price)
        {
            this.id = id;
            this.name = name;
            this.base_price = base_price;
            this.price = price;
            this.qty = 1;
        }

        public Facility()
        {

        }
    }
}
