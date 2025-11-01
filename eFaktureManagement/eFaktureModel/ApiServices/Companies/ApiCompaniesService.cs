using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models.Company;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices.Companies;
using eFaktureSync.ApiServices;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MiniInvoiceDto = eFaktureModel.Api.Models.Invoices.MiniInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiCompaniesService : IApiCompaniesService<MiniCompanyDto, CompanyAccountOnEfAkturaDto>
    {
        public Task<CompanyAccountOnEfAkturaDto> CheckIfCompanyRegisteredOnEfaktura(string registrationNumber, string jbkjs, string vatNumber)
        {
            throw new NotImplementedException();
        }

        public Task<List<MiniCompanyDto>> GetAllCompaniesAsync(bool? includeAllStatuses = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompanies()
        {
            throw new NotImplementedException();
        }
    }
}
