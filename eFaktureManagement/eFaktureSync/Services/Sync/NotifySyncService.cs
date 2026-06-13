using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices;
using eFaktureModel.ApiServices.Util;
using eFaktureModel.Dto.Sync;
using eFaktureModel.Services.Sync;
using eFaktureSync.Config;
using eFaktureSync.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace eFaktureSync.Services
{
    public class NotifySyncService : ISyncService
    {
        public NotifySyncService()
        {
            PathsConfiguration = new SyncApiOptions();  
        }
        public NotifySyncService(SyncApiOptions pathsConfiguration)
        {
            PathsConfiguration = pathsConfiguration;
        }

        protected SyncApiOptions PathsConfiguration { get; set; }

        public void Sync()
        {
            throw new NotImplementedException();
        }


        public async Task SyncAsync()
        {
            var path = PathsConfiguration.Endpoints[ESyncPaths.SYNC];
            var root = PathsConfiguration.BaseUrl;
            if (string.IsNullOrWhiteSpace(root))
            {
                throw new Exception("Api root not found.");
            }
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new Exception("Api path not found.");
            }


            using (var httpClient = new HttpClientBuilder<string?>(root))
            {

                var date = DateTime.Now.AddDays(-1);    
                var request = new SyncChangesDto { Date = date };

                httpClient.AddHttpContentBody(request).AddPath(path);
                string? res = (await httpClient.PostResult()).Result;

            }
        }
    }
}
