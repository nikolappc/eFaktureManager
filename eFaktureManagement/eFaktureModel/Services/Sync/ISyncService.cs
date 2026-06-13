using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Services.Sync
{
    public interface ISyncService
    {
        void Sync();
        Task SyncAsync();
    }
}
