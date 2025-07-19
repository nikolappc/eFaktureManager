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
    public abstract class SyncService<T, Status> : ISyncService
    {
        private readonly IConfiguration configRoot;


        
        public readonly IApiInvoiceService<Status, T> apiInvoiceService;



        public SyncService(IConfiguration configRoot, IApiInvoiceService<Status, T> apiInvoiceService)
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
