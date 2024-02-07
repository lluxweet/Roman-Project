using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class CityEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int area_id { get; set; }
        public int type_id { get; set;}
    }
}
