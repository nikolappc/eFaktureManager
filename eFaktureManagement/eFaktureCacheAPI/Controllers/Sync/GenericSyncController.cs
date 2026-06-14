using eFaktureCacheAPI.Services.Sync;
using eFaktureModel.ApiServices;
using eFaktureModel.Dto.Sync;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class GenericSyncController<C, I> : ControllerBase
{
    private readonly IApiInvoiceService<C, I> _apiService;
    private readonly InvoiceSyncService<I, C> _syncService;

    protected GenericSyncController(IApiInvoiceService<C, I> apiService, InvoiceSyncService<I, C> syncService)
    {
        _apiService = apiService;
        _syncService = syncService;
    }

    [HttpPost("sync")]
    public async Task<IActionResult> Sync([FromBody]SyncChangesDto dto)
    {
        try
        {
            var result = await _apiService.GetChangesAsync(dto.Date);

            _syncService.ApplyChanges(result);

            return Ok(new { Message = "Sync completed successfully." });    
        }
        catch (Exception e)
        {

            return BadRequest(e.Message);
        }
    }
}