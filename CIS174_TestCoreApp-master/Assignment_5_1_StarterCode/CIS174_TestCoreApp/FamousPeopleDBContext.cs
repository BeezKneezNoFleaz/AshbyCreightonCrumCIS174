using CIS174_TestCoreApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp
{
    public class FamousPeopleDBContext : DbContext
    {
        public FamousPeopleDBContext(DbContextOptions<FamousPeopleDBContext> options)
            :base (options)
        {

        }

        public DbSet<FamousPeople> FamousPeoples { get; set; }

        public DbSet<Accoplishment> Accoplishments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:acreighton1.database.windows.net,1433;Initial Catalog=CIS174DBWeek10Assignment;Persist Security Info=False;User ID=Acreighton1;Password=Balifun!1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
