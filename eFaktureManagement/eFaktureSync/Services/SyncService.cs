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
    public class SyncService : ISyncService
    {
        private readonly IConfiguration configRoot;


        
        private readonly IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto> apiInvoiceService;



        public SyncService(IConfiguration configRoot, IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto> apiInvoiceService)
        {
            this.configRoot = configRoot;
            this.apiInvoiceService = apiInvoiceService;
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }

        public async Task SyncAsync()
        {
            await apiInvoiceService.GetChangesAsync(DateTime.Now.AddDays(-1));
        }
    }
}
