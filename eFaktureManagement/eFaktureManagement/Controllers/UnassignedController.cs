using eFaktureManagement.Dto;
using eFaktureManagement.Paging;
using eFaktureManagement.Services.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eFaktureManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnassignedController : ControllerBase
    {
        IPagingService<UnassignedInvoiceFilter, UnassignedInvoiceDto> _pagingService;
        ILogger<UnassignedController> _logger;
        public UnassignedController(IPagingService<UnassignedInvoiceFilter, UnassignedInvoiceDto> pagingService, ILogger<UnassignedController> logger)
        {
            _pagingService = pagingService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<Page<UnassignedInvoiceDto>> UnassignedPaging([FromBody]PageRequest<UnassignedInvoiceDto, UnassignedInvoiceFilter> pageRequest)
        {
            try
            {
                var page = await _pagingService.GetPageAsync(pageRequest.PageNumber, pageRequest.PageSize, pageRequest.Filter, pageRequest.Sorting);  

                return page;
            }
            catch (Exception e)
            {
                _logger.LogCritical(e, e.Message);
                throw;
            }

        }
    }
}
