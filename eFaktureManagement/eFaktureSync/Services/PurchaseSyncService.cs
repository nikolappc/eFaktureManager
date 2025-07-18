using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public class PurchaseSyncService : SyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto>
    {
        private eFaktureContext _context;

        public PurchaseSyncService(eFaktureContext context, IConfiguration configRoot, IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> apiInvoiceService) : base(configRoot, apiInvoiceService)
        {
            this._context = context;

        }

        public override void ApplyChanges(List<PurchaseInvoiceStatusChangeDto> changes)
        {

            foreach (var change in changes)
            {
                
            }
           Dictionary<long?, PurchaseInvoiceStatusChangeDto> changesDict = changes?.ToDictionary(x => x.PurchaseInvoiceId)??new();
            foreach (var id in changesDict.Keys)
            {
               


            }
            _context.SaveChanges();



        }
    }
}
