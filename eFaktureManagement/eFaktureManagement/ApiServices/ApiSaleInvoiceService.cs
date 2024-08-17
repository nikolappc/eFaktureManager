using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;

namespace eFaktureManagement.ApiServices
{
    public class ApiSaleInvoiceService : IApiInvoiceService<SaleInvoiceChange, SaleInvoiceDto>, IApiSalesService
    {
        public List<SaleInvoiceChange> GetChanges(DateTime date)
        {
            using ( var httpClient = new HttpClient())
                {
                var requestData = "{\"ALIAS\":\"EXTRA\",\"P_USERNAME\":\"WebSite\",\"P_ID\":\"INFO\",\"P_VERIFICATION_CODE\":null}";
                var requestContent = new StringContent(requestData, System.Text.Encoding.UTF8, "application/json");

                httpClient.DefaultRequestHeaders.Add("Host", "WEBSERVER");
                httpClient.DefaultRequestHeaders.Add("Alias", "OPMzqeNCAi");

                var response = await httpClient.PostAsync("PATH TO EXECUTE REQUEST", requestContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();

                // Process the response data
                Console.WriteLine(responseBody);
            }
        }

        public List<long> GetIds(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public SaleInvoiceDto GetInvoice(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public byte[] GetXml(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public MiniInvoiceDto ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml)
        {
            throw new NotImplementedException();
        }

        public MiniInvoiceDto UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml)
        {
            throw new NotImplementedException();
        }
    }
}
