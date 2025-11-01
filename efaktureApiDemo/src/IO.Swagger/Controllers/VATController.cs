using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using eFaktureModel.Api.Models.Vat;

namespace eFaktureApiDemo.Controllers
{
    [ApiController]
    public class VATController : ControllerBase
    {

        /// <summary>
        /// Cancel all versions of group vat recording
        /// </summary>
        /// <param name="groupVatId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/group/cancel/{groupVatId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingGroupCancelGroupVatIdPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(int?), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingGroupCancelGroupVatIdPost([FromRoute][Required] int? groupVatId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(int?));
            string exampleJson = null;
            exampleJson = "0";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<int?>(exampleJson)
            : default(int?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get group vat recordings and filter old records by last modified date and new ones by status change date
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/group")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingGroupGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<GroupVatListDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingGroupGet([FromHeader] string apiKey, [FromQuery] DateTime? dateFrom, [FromQuery] DateTime? dateTo)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<GroupVatListDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"groupVatId\" : 0,\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"groupVatId\" : 0,\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<GroupVatListDto>>(exampleJson)
            : default(List<GroupVatListDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get group vat recording by id
        /// </summary>
        /// <param name="groupVatId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/group/{groupVatId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingGroupGroupVatIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(GroupVatDto), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingGroupGroupVatIdGet([FromRoute][Required] int? groupVatId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GroupVatDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"vatIncreaseFromPreviousPeriodAmount\" : 7.386281948385884,\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"groupVatId\" : 0,\r\n  \"turnoverWithFee\" : {\r\n    \"totalAmount10\" : 2.027123023002322,\r\n    \"taxableAmount20\" : 5.637376656633329,\r\n    \"totalAmount20\" : 7.061401241503109,\r\n    \"vatTurnoverId\" : 5,\r\n    \"taxableAmount10\" : 9.301444243932576,\r\n    \"taxAmount10\" : 3.616076749251911,\r\n    \"turnoverDescription20\" : \"turnoverDescription20\",\r\n    \"turnoverDescription10\" : \"turnoverDescription10\",\r\n    \"taxAmount20\" : 2.3021358869347655\r\n  },\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"vatReductionFromPreviousPeriodAmount\" : 4.145608029883936,\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"createdDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"statusChangeDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"groupVatVersionHistory\" : [ {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  }, {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  } ],\r\n  \"calculationNumber\" : \"calculationNumber\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupVatDto>(exampleJson)
            : default(GroupVatDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Record group vat, do a correction for previous group vat record if exist
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <param name="groupVatId"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/group")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingGroupPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(GroupVatDto), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingGroupPost([FromBody] GroupVatAddDto body, [FromHeader] string apiKey, [FromQuery] int? groupVatId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GroupVatDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"vatIncreaseFromPreviousPeriodAmount\" : 7.386281948385884,\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"groupVatId\" : 0,\r\n  \"turnoverWithFee\" : {\r\n    \"totalAmount10\" : 2.027123023002322,\r\n    \"taxableAmount20\" : 5.637376656633329,\r\n    \"totalAmount20\" : 7.061401241503109,\r\n    \"vatTurnoverId\" : 5,\r\n    \"taxableAmount10\" : 9.301444243932576,\r\n    \"taxAmount10\" : 3.616076749251911,\r\n    \"turnoverDescription20\" : \"turnoverDescription20\",\r\n    \"turnoverDescription10\" : \"turnoverDescription10\",\r\n    \"taxAmount20\" : 2.3021358869347655\r\n  },\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"vatReductionFromPreviousPeriodAmount\" : 4.145608029883936,\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"createdDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"statusChangeDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"groupVatVersionHistory\" : [ {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  }, {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  } ],\r\n  \"calculationNumber\" : \"calculationNumber\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupVatDto>(exampleJson)
            : default(GroupVatDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Cancel all versions of individual vat recording
        /// </summary>
        /// <param name="individualVatId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/individual/cancel/{individualVatId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingIndividualCancelIndividualVatIdPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(int?), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingIndividualCancelIndividualVatIdPost([FromRoute][Required] int? individualVatId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(int?));
            string exampleJson = null;
            exampleJson = "0";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<int?>(exampleJson)
            : default(int?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get individual vat recordings and filter old records by last modified date and new ones by status change date
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/individual")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingIndividualGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<IndividualVatListDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingIndividualGet([FromHeader] string apiKey, [FromQuery] DateTime? dateFrom, [FromQuery] DateTime? dateTo)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<IndividualVatListDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"basisForPrepayment\" : \"basisForPrepayment\",\r\n  \"vatAmount10\" : 5.637376656633329,\r\n  \"year\" : 6,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"documentType\" : \"Invoice\",\r\n  \"vatDeductionRight\" : \"None\",\r\n  \"documentNumber\" : \"documentNumber\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"turnoverAmount\" : 1.4658129805029452,\r\n  \"documentDirection\" : \"Inbound\",\r\n  \"internalInvoiceOption\" : \"Turnover\",\r\n  \"vatAmount\" : 5.962133916683182,\r\n  \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"foreignDocument\" : true,\r\n  \"vatPeriod\" : \"January\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"individualVatId\" : 0,\r\n  \"vatAmount20\" : 2.3021358869347655,\r\n  \"relatedPartyIdentifier\" : \"relatedPartyIdentifier\",\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"basisForPrepayment\" : \"basisForPrepayment\",\r\n  \"vatAmount10\" : 5.637376656633329,\r\n  \"year\" : 6,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"documentType\" : \"Invoice\",\r\n  \"vatDeductionRight\" : \"None\",\r\n  \"documentNumber\" : \"documentNumber\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"turnoverAmount\" : 1.4658129805029452,\r\n  \"documentDirection\" : \"Inbound\",\r\n  \"internalInvoiceOption\" : \"Turnover\",\r\n  \"vatAmount\" : 5.962133916683182,\r\n  \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"foreignDocument\" : true,\r\n  \"vatPeriod\" : \"January\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"individualVatId\" : 0,\r\n  \"vatAmount20\" : 2.3021358869347655,\r\n  \"relatedPartyIdentifier\" : \"relatedPartyIdentifier\",\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<IndividualVatListDto>>(exampleJson)
            : default(List<IndividualVatListDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get individual vat recording by id
        /// </summary>
        /// <param name="individualVatId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/individual/{individualVatId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingIndividualIndividualVatIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(IndividualVatDto), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingIndividualIndividualVatIdGet([FromRoute][Required] int? individualVatId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IndividualVatDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"individualVatHistory\" : [ {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  }, {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  } ],\r\n  \"vatAmount10\" : 9.301444243932576,\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"documentType\" : \"Invoice\",\r\n  \"vatDeductionRight\" : \"None\",\r\n  \"documentNumber\" : \"documentNumber\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"vatBaseAmount10\" : 2.3021358869347655,\r\n  \"turnoverDescription\" : \"turnoverDescription\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"createdDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"relatedDocuments\" : [ {\r\n    \"relatedVatDocumentId\" : 4,\r\n    \"documentNumber\" : \"documentNumber\"\r\n  }, {\r\n    \"relatedVatDocumentId\" : 4,\r\n    \"documentNumber\" : \"documentNumber\"\r\n  } ],\r\n  \"turnoverDescription10\" : \"turnoverDescription10\",\r\n  \"vatAmount20\" : 3.616076749251911,\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"basisForPrepayment\" : \"basisForPrepayment\",\r\n  \"turnoverAmount\" : 5.962133916683182,\r\n  \"documentDirection\" : \"Inbound\",\r\n  \"internalInvoiceOption\" : \"Turnover\",\r\n  \"vatAmount\" : 7.061401241503109,\r\n  \"vatBaseAmount20\" : 5.637376656633329,\r\n  \"totalAmount\" : 2.027123023002322,\r\n  \"foreignDocument\" : true,\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"turnoverDescription20\" : \"turnoverDescription20\",\r\n  \"statusChangeDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"individualVatId\" : 0,\r\n  \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"relatedPartyIdentifier\" : \"relatedPartyIdentifier\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<IndividualVatDto>(exampleJson)
            : default(IndividualVatDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Record individual vat, do a correction for previous individual vat record if exist
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <param name="individualVatId"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/vat-recording/individual")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiVatRecordingIndividualPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(IndividualVatDto), description: "Success")]
        public virtual IActionResult ApiPublicApiVatRecordingIndividualPost([FromBody] IndividualVatAddDto body, [FromHeader] string apiKey, [FromQuery] int? individualVatId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IndividualVatDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"individualVatHistory\" : [ {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  }, {\r\n    \"statusChangeDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"calculationNumber\" : \"calculationNumber\"\r\n  } ],\r\n  \"vatAmount10\" : 9.301444243932576,\r\n  \"year\" : 1,\r\n  \"sendDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"documentType\" : \"Invoice\",\r\n  \"vatDeductionRight\" : \"None\",\r\n  \"documentNumber\" : \"documentNumber\",\r\n  \"vatRecordingStatus\" : \"Draft\",\r\n  \"vatBaseAmount10\" : 2.3021358869347655,\r\n  \"turnoverDescription\" : \"turnoverDescription\",\r\n  \"vatRecordingVersion\" : \"First\",\r\n  \"createdDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"relatedDocuments\" : [ {\r\n    \"relatedVatDocumentId\" : 4,\r\n    \"documentNumber\" : \"documentNumber\"\r\n  }, {\r\n    \"relatedVatDocumentId\" : 4,\r\n    \"documentNumber\" : \"documentNumber\"\r\n  } ],\r\n  \"turnoverDescription10\" : \"turnoverDescription10\",\r\n  \"vatAmount20\" : 3.616076749251911,\r\n  \"calculationNumber\" : \"calculationNumber\",\r\n  \"basisForPrepayment\" : \"basisForPrepayment\",\r\n  \"turnoverAmount\" : 5.962133916683182,\r\n  \"documentDirection\" : \"Inbound\",\r\n  \"internalInvoiceOption\" : \"Turnover\",\r\n  \"vatAmount\" : 7.061401241503109,\r\n  \"vatBaseAmount20\" : 5.637376656633329,\r\n  \"totalAmount\" : 2.027123023002322,\r\n  \"foreignDocument\" : true,\r\n  \"companyId\" : 6,\r\n  \"vatPeriod\" : \"January\",\r\n  \"turnoverDescription20\" : \"turnoverDescription20\",\r\n  \"statusChangeDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"individualVatId\" : 0,\r\n  \"turnoverDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"relatedPartyIdentifier\" : \"relatedPartyIdentifier\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<IndividualVatDto>(exampleJson)
            : default(IndividualVatDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
