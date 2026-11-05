using eFaktureCacheAPI.Services.Sync;

namespace eFaktureCacheAPI.Services.Storage
{
    public interface IInvoiceStorageService<C, State>
    {
        ApplyResult StoreInvoice(C change);
        ApplyResult ChangeStatus(State state);
    }
}
