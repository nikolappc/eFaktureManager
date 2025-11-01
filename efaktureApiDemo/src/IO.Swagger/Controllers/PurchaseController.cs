using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Vat;
using eFaktureApiDemo.Services;

namespace eFaktureApiDemo.Controllers
{

    [ApiController]

    public class PurchaseController:ControllerBase
    {


        private readonly PurchaseRandomService _service;

        public PurchaseController(PurchaseRandomService service)
        {
            _service = service;
        }

        /// <summary>
        /// Search for all invoices which status changed on specific date and company is public purchase contract signer
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="date"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/changes")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPublicPurchaseContractorInvoiceChangesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PurchaseInvoiceStatusChangeDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiPublicPurchaseContractorInvoiceChangesPost([FromHeader] string apiKey, [FromQuery] DateTime? date)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<PurchaseInvoiceStatusChangeDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"purchaseInvoiceId\" : 6,\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n}, {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"purchaseInvoiceId\" : 6,\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<PurchaseInvoiceStatusChangeDto>>(exampleJson)
            : default(List<PurchaseInvoiceStatusChangeDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get purchase invoice for public purchase contract signer
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPublicPurchaseContractorInvoiceGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SimplePurchaseInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPublicPurchaseContractorInvoiceGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SimplePurchaseInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"cancelComment\" : \"cancelComment\",\r\n  \"version\" : 6,\r\n  \"cirSettledAmount\" : 1.4658129805029452,\r\n  \"globUniqId\" : \"globUniqId\",\r\n  \"lastModifiedUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceId\" : 0,\r\n  \"comment\" : \"comment\",\r\n  \"stornoComment\" : \"stornoComment\",\r\n  \"status\" : \"New\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SimplePurchaseInvoiceDto>(exampleJson)
            : default(SimplePurchaseInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get purchase invoice IDs for public purchase contract signer
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="status"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/ids")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPublicPurchaseContractorInvoiceIdsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(PurchaseInvoicesDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPublicPurchaseContractorInvoiceIdsPost([FromHeader] string apiKey, [FromQuery] PurchaseInvoiceStatusFilter status, [FromQuery] DateTime? dateFrom, [FromQuery] DateTime? dateTo)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PurchaseInvoicesDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"purchaseInvoiceIds\" : [ 0, 0 ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseInvoicesDto>(exampleJson)
            : default(PurchaseInvoicesDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get public purchase invoice signature for public purchase contract signer
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/signature")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPublicPurchaseContractorInvoiceSignatureGet")]
        public virtual IActionResult ApiPublicApiPublicPurchaseContractorInvoiceSignatureGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Download purchase invoice ubl as FileStream where company is public purchase contract signer
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/xml")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPublicPurchaseContractorInvoiceXmlGet")]
        public virtual IActionResult ApiPublicApiPublicPurchaseContractorInvoiceXmlGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }



        /// <summary>
        /// Accept or reject purchase invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/acceptRejectPurchaseInvoice")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceAcceptRejectPurchaseInvoicePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(AcceptRejectResponse), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceAcceptRejectPurchaseInvoicePost([FromBody] AcceptRejectPurchaseInvoice body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AcceptRejectResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"success\" : true,\r\n  \"httpStatus\" : \"httpStatus\",\r\n  \"invoice\" : {\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"status\" : \"New\"\r\n  },\r\n  \"message\" : \"message\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AcceptRejectResponse>(exampleJson)
            : default(AcceptRejectResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Search for all purchase invoices which status changed on specific date
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="date"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/changes")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceChangesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PurchaseInvoiceStatusChangeDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceChangesPost([FromHeader] string apiKey, [FromQuery] DateTime? date)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<PurchaseInvoiceStatusChangeDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"purchaseInvoiceId\" : 6,\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n}, {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"purchaseInvoiceId\" : 6,\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n} ]";

            var list = _service.GenerateChanges();

            var example = list != null
            ? list
            : default;
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get purchase invoice
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SimplePurchaseInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SimplePurchaseInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"cancelComment\" : \"cancelComment\",\r\n  \"version\" : 6,\r\n  \"cirSettledAmount\" : 1.4658129805029452,\r\n  \"globUniqId\" : \"globUniqId\",\r\n  \"lastModifiedUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceId\" : 0,\r\n  \"comment\" : \"comment\",\r\n  \"stornoComment\" : \"stornoComment\",\r\n  \"status\" : \"New\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SimplePurchaseInvoiceDto>(exampleJson)
            : default(SimplePurchaseInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get purchase invoice IDs
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="status"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/ids")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceIdsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(PurchaseInvoicesDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceIdsPost([FromHeader] string apiKey, [FromQuery] string status, [FromQuery] DateTime? dateFrom, [FromQuery] DateTime? dateTo)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PurchaseInvoicesDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"purchaseInvoiceIds\" : [ 0, 0 ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseInvoicesDto>(exampleJson)
            : default(PurchaseInvoicesDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Download purchase invoice extended pdf as FileStream or generate new one if not exists
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/pdf")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoicePdfGet")]
        public virtual IActionResult ApiPublicApiPurchaseInvoicePdfGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get purchase invoice signature
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/signature")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceSignatureGet")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceSignatureGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Records VAT on specified invoice calculated by receiver, for invoice with VAT reverse charge
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/vatReverseCharge")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceVatReverseChargePost")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceVatReverseChargePost([FromBody] VatReverseChargeDto body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Download purchase invoice ubl as FileStream
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/xml")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceXmlGet")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceXmlGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
