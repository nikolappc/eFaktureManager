using eFaktureModel.Model.Purchase;
using eFaktureModel.Model.Sales;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace eFaktureManagement.Data
{
    public class eFaktureContext : IdentityDbContext
    {
        public eFaktureContext(DbContextOptions<eFaktureContext> options) : base(options)
        {
        }


        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

        public DbSet<SalesInvoice> SalesInvoices { get; set; }

        public DbSet<PurchaseInvoiceChange> PurchaseInvoicesChange { get; set; }

        public DbSet<SalesInvoiceChange> SalesInvoicesChange { get; set; }
    }
}
