using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Sales;
using eFaktureSync.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public class SalesSyncService : NotifySyncService
    {
        public SalesSyncService(SyncApiRoot syncApiRoot) :base() 
        {

            PathsConfiguration = syncApiRoot.ApiPaths[eFaktureModel.Enums.EApiSections.SALES];
        }
    }
}
