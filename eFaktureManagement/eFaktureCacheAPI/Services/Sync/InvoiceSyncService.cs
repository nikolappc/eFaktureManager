using eFaktureModel.Api.Models;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Sync;
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
            List<Status> applyingchanges = new List<Status>();


            //Check which changes should be applied and which are already applied
            foreach (var change in changes)
            {

                // Get relevant record from database to check if it is already applied
                AInvoiceChangeRecord record = GetChangeRecord(change);

                // If record is null or not applied, add to applyingchanges
                if (record == null || record.RecordStatus != eFaktureModel.Enums.ESyncRecordStatus.APPLIED)
                {
                    applyingchanges.Add(change);
                }
            }
            ApplyChanges(applyingchanges);
        }

        protected abstract AInvoiceChangeRecord GetChangeRecord(Status? change);
    }
}
