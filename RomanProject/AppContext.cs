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
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbRoman.db");
        }
        public DbSet<RoleEntity> roles { get; set; }
        public DbSet<AdressEntity> adresses { get; set; }
        public DbSet<AreasEntity> areas { get; set; }
        public DbSet<CityEntity> cities { get; set; }
        public DbSet<CounterpartyTypeEntity> counterpartyTypes { get; set; }
        public DbSet<CounterpartiesEntity> counterparties { get; set; }
        public DbSet<CountriesEntity> countries { get; set; }
        public DbSet<MarksEntity> marks { get; set; }
        public DbSet<OrdersEntity> orders { get; set; }
        public DbSet<RegionsEntity> regions { get; set; }
        public DbSet<StatusEntity> status { get; set; }
        public DbSet<StreetsEntity> streets { get; set; }
        public DbSet<TypesCitiesEntity> typesCities { get; set; }
        public DbSet<UserEntity> users { get; set; }
    }
}
