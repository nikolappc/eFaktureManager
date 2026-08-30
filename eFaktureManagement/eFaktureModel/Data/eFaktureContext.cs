using eFaktureModel.Model.Company;
using eFaktureModel.Model.Purchase;
using eFaktureModel.Model.Reference;
using eFaktureModel.Model.Sales;
using eFaktureModel.Model.Sync;
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

        public DbSet<PublicPurchaseContractorRecordChange> PublicPurchaseContractorRecordChanges { get; set; }
        public DbSet<PurchaseInvoiceRecordChange> PurchaseInvoiceRecordChanges { get; set; }
        public DbSet<SalesInvoiceRecordChange> SalesInvoiceRecordChanges { get; set; }
        public DbSet<RegisteredCompany> RegisteredCompanies { get; set; }

        public DbSet<UserInvoice> UserInvoices { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

        public DbSet<SalesInvoice> SalesInvoices { get; set; }

        public DbSet<PurchaseInvoiceChange> PurchaseInvoicesChange { get; set; }

        public DbSet<SalesInvoiceChange> SalesInvoicesChange { get; set; }

        public DbSet<PurchaseInvoiceAttachment> PurchaseInvoiceAttachments { get; set; }

        public DbSet<SalesInvoiceAttachment> SalesInvoiceAttachments { get; set; }  
    }
}
