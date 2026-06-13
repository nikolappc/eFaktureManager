using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureCacheAPI.Services.Sync
{
    public class SalesSyncService : InvoiceSyncService<SimpleSalesInvoiceDto, SalesInvoiceStatusChangeDto>
    {

        private readonly ILogger<PurchaseSyncService> logger;
        private eFaktureContext _context;

        public SalesSyncService(IConfiguration configRoot, IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto> apiInvoiceService, ILogger<PurchaseSyncService> logger, eFaktureContext context) : base(configRoot, apiInvoiceService)
        {
            this.logger = logger;
            _context = context;
        }

        public override void ApplyChanges(List<SalesInvoiceStatusChangeDto> changes)
        {
            foreach (var change in changes)
            {
                if (change.SalesInvoiceId == 0)
                {

                }
                logger.LogWarning($"Sales invoice change has no id, eventId:{change.EventId}");
                var salesInvoiceChange = new SalesInvoiceChange
                {
                    SalesInvoiceId = change.SalesInvoiceId ?? 0,

                    CirAssignmentChange = change.CirAssignmentChange,
                    CirInvoiceId = change.CirInvoiceId,
                    Comment = change.Comment,
                    Date = change.Date,
                    EventId = change.EventId,
                    IsAutoAssigned = change.IsAutoAssigned,
                    IsSigned = change.IsSigned,
                    NewInvoiceStatus = change.NewInvoiceStatus,
                    StornoNumber = change.StornoNumber,
                    SubscriptionKey = change.SubscriptionKey,
                };

                _context.SalesInvoicesChange.Add(salesInvoiceChange);

            };
            _context.SaveChanges();
        }
    }
}
