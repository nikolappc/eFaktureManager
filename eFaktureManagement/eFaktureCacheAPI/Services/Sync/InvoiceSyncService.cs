using eFaktureModel.Api.Models;
using eFaktureModel.ApiServices;
using eFaktureModel.Services.Sync;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureCacheAPI.Services.Sync
{
    public abstract class InvoiceSyncService<T, Status> : ISyncService
    {
        private readonly IConfiguration configRoot;


        public readonly IApiInvoiceService<Status, T> apiInvoiceService;


        public InvoiceSyncService(IConfiguration configRoot, IApiInvoiceService<Status, T> apiInvoiceService)
        {
            this.configRoot = configRoot;
            this.apiInvoiceService = apiInvoiceService;
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }

        public abstract void ApplyChanges(List<Status>? changes);

        public async Task SyncAsync()
        {
            var changes = await apiInvoiceService.GetChangesAsync(DateTime.Now.AddDays(-1));

            ApplyChanges(changes);
        }
    }
}
