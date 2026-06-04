using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Purchase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public class PurchaseSyncService : InvoiceSyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto>
    {
        private eFaktureContext _context;

        private readonly ILogger<PurchaseSyncService> logger;

        public PurchaseSyncService(eFaktureContext context, IConfiguration configRoot, IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> apiInvoiceService, ILogger<PurchaseSyncService> logger) : base(configRoot, apiInvoiceService)
        {
            this._context = context;
            this.logger = logger;
        }

        public override async void ApplyChanges(List<PurchaseInvoiceStatusChangeDto>? changes)
        {

            if (changes == null)
            {
                return;
            }
            Dictionary<long, List<PurchaseInvoiceStatusChangeDto>> keyValuePairs = changes.GroupBy(change => change.PurchaseInvoiceId ?? 0)
                         .ToDictionary(group => group.Key, group => group.OrderBy(e => e.Date).ToList());


            keyValuePairs = keyValuePairs.Where((k) => k.Key != 0).ToDictionary();

            foreach (var pair in keyValuePairs)
            {
                var invoice = _context.PurchaseInvoices.FirstOrDefault(i => i.InvoiceId == pair.Key);

                var fullInvoice = await apiInvoiceService.GetInvoiceAsync(pair.Key);

                if (fullInvoice != null)
                {

                    if (invoice == null)
                    {
                        invoice = new PurchaseInvoice
                        {
                            InvoiceId = fullInvoice.InvoiceId ?? 0,
                            CirInvoiceId = fullInvoice.CirInvoiceId,
                            CancelComment = fullInvoice.CancelComment,
                            CirSettledAmount = fullInvoice.CirSettledAmount,
                            CirStatus = fullInvoice.CirStatus,
                            Comment = fullInvoice.Comment,
                            FactoringContractNumber = fullInvoice.FactoringContractNumber,
                            GlobUniqId = Guid.Parse(fullInvoice.GlobUniqId),
                            LastModifiedUtc = fullInvoice.LastModifiedUtc,
                            Status = fullInvoice.Status,
                            StornoComment = fullInvoice.StornoComment,
                            VatNumberFactoringCompany = fullInvoice.VatNumberFactoringCompany,

                        };
                        _context.PurchaseInvoices.Add(invoice);
                        _context.SaveChanges();


                        invoice = _context.PurchaseInvoices.FirstOrDefault(i => i.InvoiceId == pair.Key);

                    }
                    else
                    {
                        invoice.CirInvoiceId = fullInvoice.CirInvoiceId;
                        invoice.CancelComment = fullInvoice.CancelComment;
                        invoice.CirSettledAmount = fullInvoice.CirSettledAmount;
                        invoice.CirStatus = fullInvoice.CirStatus;
                        invoice.Comment = fullInvoice.Comment;
                        invoice.FactoringContractNumber = fullInvoice.FactoringContractNumber;
                        invoice.GlobUniqId = Guid.Parse(fullInvoice.GlobUniqId);
                        invoice.LastModifiedUtc = fullInvoice.LastModifiedUtc;
                        invoice.Status = fullInvoice.Status;
                        invoice.StornoComment = fullInvoice.StornoComment;
                        invoice.VatNumberFactoringCompany = fullInvoice.VatNumberFactoringCompany;

                        _context.PurchaseInvoices.Update(invoice);
                        _context.SaveChanges();

                    }


                }
                else
                {
                    logger.LogError("Invoice not found for id: " + pair.Key + " in eFaktureSyncService");
                    continue;
                }


                var xml_bytes = await apiInvoiceService.GetXmlAsync(pair.Key);



                var items = pair.Value;
                foreach (var change in items)
                {

                    logger.LogWarning($"Invoice change has no id, eventId:{change.EventId}");
                    var purchaseInvoiceChange = new PurchaseInvoiceChange
                    {
                        PurchaseInvoiceId = change.PurchaseInvoiceId ?? 0,

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

                    _context.PurchaseInvoicesChange.Add(purchaseInvoiceChange);

                }

                _context.SaveChanges(); 
               
            }



        }
    }
}
