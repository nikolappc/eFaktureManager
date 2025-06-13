using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public class SyncService : ISyncService
    {
        private readonly IConfiguration configRoot;
        public SyncService(IConfiguration configRoot)
        {
            this.configRoot = configRoot;
        }

        void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
