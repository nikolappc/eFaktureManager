using eFaktureCacheAPI.Services.Sync;
using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.ApiServices;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

[ApiController]
[Route("api/sales-sync")]
public class SalesSyncController : GenericSyncController<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>   
{

    public SalesSyncController(IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto> service, InvoiceSyncService<SimpleSalesInvoiceDto, SalesInvoiceStatusChangeDto> purchaseSyncService): base(service, purchaseSyncService)    
    {
    }

}