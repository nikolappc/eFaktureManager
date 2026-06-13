using eFaktureCacheAPI.Services.Sync;
using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Sales;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

[ApiController]
[Route("api/sales-sync")]
public class SalesSyncController : GenericSyncController<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>   
{
    private readonly AApiSalesService _service;
    private readonly InvoiceSyncService<SimpleSalesInvoiceDto, SalesInvoiceStatusChangeDto> _purchaseSyncService;

    public SalesSyncController(AApiSalesService service, InvoiceSyncService<SimpleSalesInvoiceDto, SalesInvoiceStatusChangeDto> purchaseSyncService): base(service, purchaseSyncService)    
    {
        _service = service;
        _purchaseSyncService = purchaseSyncService;
    }

}