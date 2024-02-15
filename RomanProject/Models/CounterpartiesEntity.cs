using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class CounterpartiesEntity
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string phone { get; set; }
        public int address_id { get; set; }
        public DateTime? date_delete { get; set;}
        public int type_id { get; set; }

        public AdressEntity Address {  get; set; }
        public CounterpartyTypeEntity CounterpartyType { get; set; }
    }
}
