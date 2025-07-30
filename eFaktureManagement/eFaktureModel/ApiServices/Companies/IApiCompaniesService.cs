using eFaktureModel.Api.Models;

namespace eFaktureModel.ApiServices.Companies
{
    public interface IApiCompaniesService<C, R>
    {
        Task<List<C>> GetAllCompaniesAsync(bool? includeAllStatuses = false);

        Task<R> CheckIfCompanyRegisteredOnEfaktura(string registrationNumber, string jbkjs, string vatNumber);

        Task UpdateCompanies();
    }
}
