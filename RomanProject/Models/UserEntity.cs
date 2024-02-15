using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject.Models
{
    internal class UserEntity
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime? date_delete { get; set; }
        public int id_role { get; set; }

        public CounterpartiesEntity Counterparties { get; set; }
        public RoleEntity Role { get; set; }
    }
}
