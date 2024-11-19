
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using TreinamentoDotNet.Models.Company;

namespace TreinamentoDotNet.Database
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("DbConnection")
        {
        }

        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}