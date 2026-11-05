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

    public class ApplyResult
    {
        public string? Message { get; set; }

        public bool Success { get; set; }
    }
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

        //public abstract bool ApplyChanges(List<Status>? changes);

        public async Task SyncAsync()
        {
            var allChanges = await apiInvoiceService.GetChangesAsync(DateTime.Now.AddDays(-1));
            List<Status> applyingchanges = new List<Status>();


            Dictionary<int, List<Status>> ChangesByInvoice = GroupChangesByInvoice(allChanges);

            foreach (var pair in ChangesByInvoice)
            {
                var changes = pair.Value;

                changes = OrderChangesByDateAscending(changes);

                var applied = false;

                var counter = 0;
                foreach (var change in changes)
                {
                    counter++;

                    try
                    {

                        // if the change is not the last in the yesterdays changes mark them as done and continue
                        if (counter < changes.Count)
                        {
                            AInvoiceChangeRecord<Status, int>? record = GetChangeRecord(change);
                            if (record == null)
                            {
                                SaveRecord(change);
                            }
                            SkipChange(record);
                            continue;
                        }
                        var i = 0;
                        while (true)
                        {
                            try
                            {
                                AInvoiceChangeRecord<Status, int>? record = GetChangeRecord(change);

                                // if record not previously saved create a new one in the database
                                if (record == null)
                                {
                                    record = SaveRecord(change);
                                }
                                
                                // try to apply the change
                                if (record.RecordStatus != eFaktureModel.Enums.ESyncRecordStatus.APPLIED)
                                {
                                    var applyResult = ApplyChange(change);

                                    if(applyResult.Success)
                                    {
                                        applied = true;

                                        CheckChange(change);
                                    }
                                    else
                                    {
                                        throw new Exception(applyResult.Message);
                                    }
                                }
                                // if already applied just confirm it as already done
                                else
                                {
                                    CheckChange(change);
                                }

                            }
                            catch (Exception)
                            {
                                // try 5 times to apply then alert the error
                                if (i >= 5)
                                {
                                    throw;
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        applied = false;
                        // If error has ocurred set the error in the record in the database and stop propagating changes
                        SetError(change, e.Message);
                        break;
                    }
                }
                List<AInvoiceChangeRecord<Status, int>> lastChangeRecords = GetLatestPreviousRecordedChanges(changes);
                foreach (var lastChangeRecord in lastChangeRecords)
                {
                    if (applied && lastChangeRecord != null)
                    {
                        switch (lastChangeRecord?.RecordStatus)
                        {
                            case eFaktureModel.Enums.ESyncRecordStatus.CHECKED:
                            case eFaktureModel.Enums.ESyncRecordStatus.ERROR:
                                SkipChange(lastChangeRecord);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }

        protected abstract List<AInvoiceChangeRecord<Status, int>> GetLatestPreviousRecordedChanges(List<Status> changes);
        protected abstract void CheckChange(Status? change);
        protected abstract void SetError(Status? change, string message);
        protected abstract ApplyResult ApplyChange(Status? change);
        protected abstract AInvoiceChangeRecord<Status, int> SaveRecord(Status? change);
        protected abstract void SkipChange(AInvoiceChangeRecord<Status, int>? record);
        protected abstract AInvoiceChangeRecord<Status, int>? GetChangeRecord(Status? change);
        protected abstract List<Status> OrderChangesByDateAscending(List<Status> changes);
        protected abstract Dictionary<int, List<Status>> GroupChangesByInvoice(List<Status>? allChanges);
    }
}
