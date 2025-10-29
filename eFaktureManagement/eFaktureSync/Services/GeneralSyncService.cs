using eFaktureManagement.Data;
using eFaktureModel.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.Services
{
    public abstract class AGeneralSyncService : ISyncService

    {

        private readonly eFaktureContext _eFaktureContext;

        protected AGeneralSyncService(eFaktureContext eFaktureContext)
        {
            _eFaktureContext = eFaktureContext;
        }



        // FOR NOW
        public abstract Task<List<MiniCompanyDto>> GetCompanies();
        public abstract Task<string> GetEFaktureVersion();


        public void Sync()
        {
            throw new NotImplementedException();
        }

        public async Task SyncAsync()
        {

            // Use somewehere later???
            var version = await GetEFaktureVersion();

            var companies = await GetCompanies();


            foreach (var company in companies)
            {
            }






        }
    }
}
