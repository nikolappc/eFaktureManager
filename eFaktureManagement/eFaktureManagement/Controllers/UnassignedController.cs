using eFaktureManagement.Dto;
using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Filters;
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

        
        IPagingService<UnassignedFilter, UnassignedInvoiceDto> _pagingService;
        ILogger<UnassignedController> _logger;
        public UnassignedController(IPagingService<UnassignedFilter, UnassignedInvoiceDto> pagingService, ILogger<UnassignedController> logger)
        {
            _pagingService = pagingService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<AssignResultDto> Assign([FromBody]AssignDto dto)
        {

            return new AssignResultDto();
        }
             
        [HttpPost]
        public async Task<Page<UnassignedInvoiceDto>> UnassignedPaging([FromBody]PageRequest<UnassignedInvoiceDto, UnassignedFilter> pageRequest)
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
