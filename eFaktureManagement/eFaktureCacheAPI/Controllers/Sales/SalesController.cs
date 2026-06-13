using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Sales;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/sales-invoices")]
public class SalesController : ControllerBase
{
    private readonly AApiSalesService _service;

    public SalesController(AApiSalesService service)
    {
        _service = service;
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