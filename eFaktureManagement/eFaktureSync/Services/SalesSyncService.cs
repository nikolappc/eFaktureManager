using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public class SalesSyncService : SyncService<SimpleSalesInvoiceDto, SalesInvoiceStatusChangeDto>
    {
        public SalesSyncService(IConfiguration configRoot, IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto> apiInvoiceService) : base(configRoot, apiInvoiceService)
        {
        }

        public override void ApplyChanges(List<SalesInvoiceStatusChangeDto> changes)
        {
            throw new NotImplementedException();
        }
    }
}
