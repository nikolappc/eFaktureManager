using eFaktureModel.Api.Models.Cir;
using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace eFaktureApiDemo.Controllers
{
    [ApiController]
    public class CirSalesController : ControllerBase
    {

        /// <summary>
        /// Get invoice payments and history from sales side by CIR invoice Id
        /// </summary>
        /// <param name="cirInvoiceId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-cir-invoice/getInvoicePaymentsAndHistory/{cirInvoiceId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesCirInvoiceGetInvoicePaymentsAndHistoryCirInvoiceIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CirHistoryDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesCirInvoiceGetInvoicePaymentsAndHistoryCirInvoiceIdGet([FromRoute][Required] string cirInvoiceId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CirHistoryDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"settlements\" : [ {\r\n    \"amount\" : 5.299143560275359,\r\n    \"comment\" : \"comment\",\r\n    \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"amount\" : 5.299143560275359,\r\n    \"comment\" : \"comment\",\r\n    \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"cancellation\" : {\r\n    \"reason\" : \"reason\",\r\n    \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"cancelledBy\" : 0\r\n  },\r\n  \"assignment\" : {\r\n    \"assignmentDebtorName\" : \"assignmentDebtorName\",\r\n    \"assignmentContractNr\" : \"assignmentContractNr\",\r\n    \"originalIdfNr\" : \"originalIdfNr\",\r\n    \"assignmentDebtorCompanyNr\" : \"assignmentDebtorCompanyNr\",\r\n    \"assignmentIdfNr\" : \"assignmentIdfNr\"\r\n  },\r\n  \"comment\" : \"comment\",\r\n  \"amountChanges\" : [ {\r\n    \"amount\" : 3.502657762086401,\r\n    \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"changedId\" : 9,\r\n    \"comments\" : \"comments\",\r\n    \"cancelComments\" : \"cancelComments\",\r\n    \"id\" : 8,\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"amount\" : 3.502657762086401,\r\n    \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"changedId\" : 9,\r\n    \"comments\" : \"comments\",\r\n    \"cancelComments\" : \"cancelComments\",\r\n    \"id\" : 8,\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CirHistoryDto>(exampleJson)
            : default(CirHistoryDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
