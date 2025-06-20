using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using System.Net.Mime;
using System.Text.Json;

namespace eFaktureManagement.ApiServices
{
    public class ApiSaleInvoiceService : IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, IApiSalesService
    {
        public List<SaleInvoiceChange> GetChanges(DateTime date)
        {
            throw new NotImplementedException();


        }
        public List<long> GetIds(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<List<long>> GetIdsAsync(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public SimpleSalesInvoiceDto GetInvoice(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<SimpleSalesInvoiceDto> GetInvoiceAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public byte[] GetXml(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetXmlAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public ApiModels.MiniInvoiceDto ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml)
        {
            throw new NotImplementedException();
        }

        public ApiModels.MiniInvoiceDto UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml)
        {
            throw new NotImplementedException();
        }

        List<SalesInvoiceStatusChangeDto> IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>.GetChanges(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SalesInvoiceStatusChangeDto>> GetChangesAsync(DateTime date)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new SaleChangeRequest { date = date };
                var requestData = JsonSerializer.Serialize(request);
                var requestContent = new StringContent(requestData, System.Text.Encoding.UTF8, MediaTypeNames.Application.FormUrlEncoded);




                var response = await httpClient.PostAsync("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/changes", requestContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();
                List<SalesInvoiceStatusChangeDto>? list =
               JsonSerializer.Deserialize<List<SalesInvoiceStatusChangeDto>>(responseBody);
                // Process the response data
                Console.WriteLine(responseBody);

                return list ?? new();
            }
        }
    }
}
