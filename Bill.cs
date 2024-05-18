using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel_UAS_PAD
{
    public class Bill
    {
        public string id {  get; set; }
        public string room_id { get; set; }
        public string staff_id { get; set; }
        public string nik { get; set; }
        public string c_in { get; set; }
        public string c_out { get; set; }
        public double total_base { get; set; }
        public string total { get; set; }
        public double gtotal { get; set; }
        public string staff_name { get; set; }
        public string cust_name { get; set; }

        public Bill(
            string id, string room_id, string staff_id,
            string nik, string c_in, string c_out,
            double total_base, string total, double gtotal,
            string staff_name, string cust_name
        ) {
            this.id = id;
            this.room_id = room_id;
            this.staff_id = staff_id;
            this.nik = nik;
            this.c_in = c_in;
            this.c_out = c_out;
            this.total_base = total_base;
            this.total = total;
            this.gtotal = gtotal;
            this.staff_name = staff_name;
            this.cust_name = cust_name;
        }
    }
}
