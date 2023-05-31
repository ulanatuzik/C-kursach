using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ROV_TL.Models;

namespace ROV_TL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Vio> Violations { get; set; } = null!;
        public DbSet<PayedVio> PayedVio { get; set; } = null!;
        public DbSet<Rule> Rules { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=kursachdatabase;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
