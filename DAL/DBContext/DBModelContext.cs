using DAL.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class DBModelContext : DbContext
    {
        public DbSet<LoginDbModel> LoginDbModel { get; set; }
        public DbSet<CompanyDbModel> CompanyDbModel { get; set; }
        public DbSet<CountryDbModel> CountryDbModel { get; set; }
        public DbSet<AddressDbModel> AddressDbModel { get; set; }
        public DbSet<CityDbModel> CityDbModel { get; set; }


    }
}
