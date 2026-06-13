using eFaktureCacheAPI.Services.Sync;
using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Purchase;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

[ApiController]
[Route("api/purchase-sync")]
public class PurchaseSyncController : GenericSyncController<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>   
{
    private readonly AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> _service;
    private readonly InvoiceSyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto> _purchaseSyncService;

    public PurchaseSyncController(AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> service, InvoiceSyncService<SimplePurchaseInvoiceDto, PurchaseInvoiceStatusChangeDto> purchaseSyncService): base(service, purchaseSyncService)    
    {
        _service = service;
        _purchaseSyncService = purchaseSyncService;
    }

}