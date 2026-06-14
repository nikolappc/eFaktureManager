using eFaktureCacheAPI.Services.Sync;
using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.ApiServices;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

[ApiController]
[Route("api/purchase-sync")]
public class PurchaseSyncController : GenericSyncController<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>   
{

    public PurchaseSyncController(IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> service, InvoiceSyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto> purchaseSyncService): base(service, purchaseSyncService)    
    {
    
    }

}