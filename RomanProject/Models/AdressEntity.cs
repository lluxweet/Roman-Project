using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class AdressEntity
    {
        public int id {  get; set; }
        public int city_street_id { get; set; }
        public string house_number { get; set; }
        public string entrance { get; set; }
        public string corpus { get; set;}
        public string apartment { get; set; }
    }
}
