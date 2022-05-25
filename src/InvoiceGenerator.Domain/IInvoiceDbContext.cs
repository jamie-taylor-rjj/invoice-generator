using InvoiceGenerator.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Domain
{
    public interface IInvoiceDbContext
    {
        DbSet<Client> Clients { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess = true);
    }
}
