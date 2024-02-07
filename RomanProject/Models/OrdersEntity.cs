using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class OrdersEntity
    {
        public int id { get; set; }
        public int marka_id { get; set; }
        public int counterparty_id { get; set; }
        public int employee_id { get; set; }
        public DateTime? date_accept { get; set;}
        public DateTime? date_end { get; set; }
        public string breaking {  get; set; }
        public int status_id { get; set; }
        public double sum { get; set; }
    }
}
