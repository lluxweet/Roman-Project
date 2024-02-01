using Microsoft.EntityFrameworkCore;
using RomanProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanProject
{
    
    internal class AppContext: DbContext
    {
        public DbSet<RoleEntity> roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbRoman.db");
        }
    }
}
