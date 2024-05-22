using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    public class Facility
    {
        public string id { get; set; }
        public string name { get; set; }
        public long price_base { get; set; }
        public string price { get; set; }
        public int qty { get; set; }

        public Facility(string id, string name, long price_base, string price, int qty = 1)
        {
            this.id = id;
            this.name = name;
            this.price_base = price_base;
            this.price = price;
            this.qty = qty;
        }

        public Facility()
        {

        }
    }
}
