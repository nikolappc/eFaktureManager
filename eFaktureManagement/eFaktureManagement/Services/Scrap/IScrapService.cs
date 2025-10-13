using eFaktureManagement.Filters;
using eFaktureManagement.Models.Repository.Scrap;
using eFaktureManagement.Services.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Services.Scrap
{
    public interface IScrapService: IPagingService<ScrapFilter, ScrapPageItem>
    {

    }
}
