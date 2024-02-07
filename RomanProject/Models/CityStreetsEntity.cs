using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class CityStreetsEntity
    {
        public int id { get; set; }
        public int city_id { get; set; }
        public int street_id { get; set;}
        public string index { get; set; }
    }
}
