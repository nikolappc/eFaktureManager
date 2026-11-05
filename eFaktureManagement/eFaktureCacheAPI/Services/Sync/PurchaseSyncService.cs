using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Enums.Purchase;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Purchase;
using eFaktureModel.Model.Sync;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureCacheAPI.Services.Sync
{
    public class PurchaseSyncService : InvoiceSyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto>
    {
        private eFaktureContext _context;

        private readonly ILogger<PurchaseSyncService> logger;

        public PurchaseSyncService(eFaktureContext context, IConfiguration configRoot, IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> apiInvoiceService, ILogger<PurchaseSyncService> logger) : base(configRoot, apiInvoiceService)
        {
            _context = context;
            this.logger = logger;
        }

        //public override async Task<ApplyResult> ApplyChanges(List<PurchaseInvoiceStatusChangeDto>? changes)
        //{

        //    if (changes == null)
        //    {
        //        return new ApplyResult{ Success=false, Message="No changes found."};
        //    }
        //    Dictionary<long, List<PurchaseInvoiceStatusChangeDto>> keyValuePairs = changes.GroupBy(change => change.PurchaseInvoiceId ?? 0)
        //                 .ToDictionary(group => group.Key, group => group.OrderBy(e => e.Date).ToList());


        //    keyValuePairs = keyValuePairs.Where((k) => k.Key != 0).ToDictionary();

        //    foreach (var pair in keyValuePairs)
        //    {
        //        var invoice = _context.PurchaseInvoices.FirstOrDefault(i => i.InvoiceId == pair.Key);

        //        var fullInvoice = await apiInvoiceService.GetInvoiceAsync(pair.Key);

        //        if (fullInvoice != null)
        //        {

        //            if (invoice == null)
        //            {
        //                invoice = new PurchaseInvoice
        //                {
        //                    InvoiceId = fullInvoice.InvoiceId ?? 0,
        //                    CirInvoiceId = fullInvoice.CirInvoiceId,
        //                    CancelComment = fullInvoice.CancelComment,
        //                    CirSettledAmount = fullInvoice.CirSettledAmount,
        //                    CirStatus = fullInvoice.CirStatus,
        //                    Comment = fullInvoice.Comment,
        //                    FactoringContractNumber = fullInvoice.FactoringContractNumber,
        //                    GlobUniqId = Guid.Parse(fullInvoice.GlobUniqId),
        //                    LastModifiedUtc = fullInvoice.LastModifiedUtc,
        //                    Status = fullInvoice.Status,
        //                    StornoComment = fullInvoice.StornoComment,
        //                    VatNumberFactoringCompany = fullInvoice.VatNumberFactoringCompany,

        //                };
        //                _context.PurchaseInvoices.Add(invoice);
        //                _context.SaveChanges();


        //                invoice = _context.PurchaseInvoices.FirstOrDefault(i => i.InvoiceId == pair.Key);

        //            }
        //            else
        //            {
        //                invoice.CirInvoiceId = fullInvoice.CirInvoiceId;
        //                invoice.CancelComment = fullInvoice.CancelComment;
        //                invoice.CirSettledAmount = fullInvoice.CirSettledAmount;
        //                invoice.CirStatus = fullInvoice.CirStatus;
        //                invoice.Comment = fullInvoice.Comment;
        //                invoice.FactoringContractNumber = fullInvoice.FactoringContractNumber;
        //                invoice.GlobUniqId = Guid.Parse(fullInvoice.GlobUniqId);
        //                invoice.LastModifiedUtc = fullInvoice.LastModifiedUtc;
        //                invoice.Status = fullInvoice.Status;
        //                invoice.StornoComment = fullInvoice.StornoComment;
        //                invoice.VatNumberFactoringCompany = fullInvoice.VatNumberFactoringCompany;

        //                _context.PurchaseInvoices.Update(invoice);
        //                _context.SaveChanges();

        //            }


        //        }
        //        else
        //        {
        //            logger.LogError("Invoice not found for id: " + pair.Key + " in eFaktureSyncService");
        //            continue;
        //        }


        //        var xml_bytes = await apiInvoiceService.GetXmlAsync(pair.Key);



        //        var items = pair.Value;
        //        foreach (var change in items)
        //        {

        //            logger.LogWarning($"Invoice change has no id, eventId:{change.EventId}");
        //            var purchaseInvoiceChange = new PurchaseInvoiceChange
        //            {
        //                PurchaseInvoiceId = change.PurchaseInvoiceId ?? 0,

        //                CirAssignmentChange = change.CirAssignmentChange,
        //                CirInvoiceId = change.CirInvoiceId,
        //                Comment = change.Comment,
        //                Date = change.Date,
        //                EventId = change.EventId,
        //                IsAutoAssigned = change.IsAutoAssigned,
        //                IsSigned = change.IsSigned,
        //                NewInvoiceStatus = change.NewInvoiceStatus,
        //                StornoNumber = change.StornoNumber,
        //                SubscriptionKey = change.SubscriptionKey,

        //            };

        //            _context.PurchaseInvoicesChange.Add(purchaseInvoiceChange);

        //        }

        //        _context.SaveChanges();

        //    }


        //    return new ApplyResult { Success = true};

        //}

        protected override AInvoiceChangeRecord<PurchaseInvoiceStatusChangeDto, int> GetChangeRecord(PurchaseInvoiceStatusChangeDto? change)
        {
           var record = _context.PurchaseInvoiceRecordChanges.Where(e=>e.Id == change.EventId).FirstOrDefault();
           
            return record;  
        }

        protected override List<AInvoiceChangeRecord<PurchaseInvoiceStatusChangeDto, int>> GetLatestPreviousRecordedChanges(List<PurchaseInvoiceStatusChangeDto> changes)
        {
            throw new NotImplementedException();
        }

        protected override void CheckChange(PurchaseInvoiceStatusChangeDto? change)
        {
            throw new NotImplementedException();
        }

        protected override void SetError(PurchaseInvoiceStatusChangeDto? change, string message)
        {
            throw new NotImplementedException();
        }

        protected override ApplyResult ApplyChange(PurchaseInvoiceStatusChangeDto? change)
        {
            try
            {

        
            var invoiceStored = _context.PurchaseInvoices.FirstOrDefault(i => i.InvoiceId == change.PurchaseInvoiceId);

            if (invoiceStored == null)
            {

            }
            else
            {
                var stored = StoreInvoice(change);


            }


            switch (change.NewInvoiceStatus)
            {   
                case PurchaseInvoiceStatus.NewEnum:
                    break;
                case PurchaseInvoiceStatus.SeenEnum:
                    break;
                case PurchaseInvoiceStatus.ReNotifiedEnum:
                    break;
                case PurchaseInvoiceStatus.DeletedEnum:
                    break;
                case PurchaseInvoiceStatus.ApprovedEnum:
                    break;
                case PurchaseInvoiceStatus.RejectedEnum:
                    break;
                case PurchaseInvoiceStatus.CancelledEnum:
                    break;
                case PurchaseInvoiceStatus.StornoEnum:
                    break;
                case PurchaseInvoiceStatus.SendingInProgressEnum:
                    break;
                case PurchaseInvoiceStatus.UnknownEnum:
                    break;
                default:
                    break;
            }

            }
            catch (Exception e)
            {
                throw new Exception("Error applying purchase invoice change.", e);
            }


        }

        protected override AInvoiceChangeRecord<PurchaseInvoiceStatusChangeDto, int> SaveRecord(PurchaseInvoiceStatusChangeDto? change)
        {
            throw new NotImplementedException();
        }

        protected override void SkipChange(AInvoiceChangeRecord<PurchaseInvoiceStatusChangeDto, int>? record)
        {
            throw new NotImplementedException();
        }

        protected override List<PurchaseInvoiceStatusChangeDto> OrderChangesByDateAscending(List<PurchaseInvoiceStatusChangeDto> changes)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<int, List<PurchaseInvoiceStatusChangeDto>> GroupChangesByInvoice(List<PurchaseInvoiceStatusChangeDto>? allChanges)
        {
            throw new NotImplementedException();
        }
    }
}
