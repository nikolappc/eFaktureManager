using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.ApiServices;
using eFaktureModel.Model.Purchase;
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
    public class PurchaseSyncService : NotifySyncService
    {
        public PurchaseSyncService(SyncApiRoot syncApiRoot) :base() 
        {

            PathsConfiguration = syncApiRoot.ApiPaths[eFaktureModel.Enums.EApiSections.PURCHASE];
        }
    }
}
