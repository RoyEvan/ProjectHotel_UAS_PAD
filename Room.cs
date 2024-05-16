using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    internal class Room
    {
        public string id {
            get; set;
        }
        public string cid {
            get; set;
        }
        public string category {
            get; set;
        }
        public long price_base {
            get; set;
        }
        public string price {
            get; set;
        }
        public bool available {
            get; set;
        }

        public Room(string id, string cid, string category, long price_base, string price, bool available)
        {
            this.id = id;
            this.cid = cid;
            this.category = category;
            this.price_base = price_base;
            this.price = price;
            this.available = available;
        }
    }
}
