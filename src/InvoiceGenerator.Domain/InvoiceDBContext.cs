using InvoiceGenerator.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Domain
{

    public class InvoiceDbContext : DbContext, IInvoiceDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:invoice-generator.database.windows.net,1433;Initial Catalog=invoice-generator;Persist Security Info=False;User ID=ef-user;Password=x3Dh0zfg2s1k;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess = true)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public DbSet<Client> Clients { get; set; }

    }
}
