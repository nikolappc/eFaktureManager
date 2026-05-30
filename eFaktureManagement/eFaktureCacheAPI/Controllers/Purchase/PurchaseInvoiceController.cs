using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Purchase;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/purchase-invoices")]
public class PurchaseController : ControllerBase
{
    private readonly AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> _service;

    public PurchaseController(AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto> service)
    {
        _service = service;
    }

    [HttpPost("accept-reject")]
    public async Task<IActionResult> AcceptReject([FromBody] AcceptRejectPurchaseInvoiceDto body)
    {
        if (body.Accepted)
        {
            var result = await _service.AcceptPurchaseInvoiceAsync(body.InvoiceId, body.Comment);
            return Ok(result);
        }
        else
        {
            var result = await _service.RejectPurchaseInvoiceAsync(body.InvoiceId, body.Comment);
            return Ok(result);

        }
    }

    [HttpGet("changes")]
    public async Task<IActionResult> GetChanges([FromQuery] DateTime date)
    {
        var result = await _service.GetChangesAsync(date);
        return Ok(result);
    }

    [HttpGet("{invoiceId}")]
    public async Task<IActionResult> GetInvoice(long invoiceId)
    {
        var result = await _service.GetInvoiceAsync(invoiceId);
        return Ok(result);
    }

    [HttpGet("ids")]
    public async Task<IActionResult> GetIds([FromQuery] string status, [FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
    {
        var result = await _service.GetIdsAsync(status, dateFrom, dateTo);
        return Ok(result);
    }

    [HttpGet("xml/{invoiceId}")]
    public async Task<IActionResult> GetXml(long invoiceId)
    {
        var xml = await _service.GetXmlAsync(invoiceId);
        return File(xml, "application/xml", $"{invoiceId}.xml");
    }
}