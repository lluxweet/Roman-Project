using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class RegionsEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
    }
}
