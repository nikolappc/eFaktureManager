using eFaktureModel.Api.Models.Cir;
using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace eFaktureApiDemo.Controllers
{
    [ApiController]
    public class CirController
    {
        /// <summary>
        /// Creates new ticket on CIR
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/cir-tickets/addCirTicket")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiCirTicketsAddCirTicketPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(int?), description: "Success")]
        public virtual IActionResult ApiPublicApiCirTicketsAddCirTicketPost([FromBody] AddCirTicketRequest body, [FromHeader] string apiKey)
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
        /// Gets all tickets by CIR invoice Id on from CIR
        /// </summary>
        /// <param name="cirInvoiceId"></param>
        /// <param name="onlyActiveTickets"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/cir-tickets/{cirInvoiceId}/{onlyActiveTickets}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiCirTicketsCirInvoiceIdOnlyActiveTicketsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CirTicketListResponse), description: "Success")]
        public virtual IActionResult ApiPublicApiCirTicketsCirInvoiceIdOnlyActiveTicketsGet([FromRoute][Required] string cirInvoiceId, [FromRoute][Required] bool? onlyActiveTickets, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CirTicketListResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"total\" : 0,\r\n  \"tickets\" : [ {\r\n    \"resourceId\" : \"Invoice\",\r\n    \"cirId\" : \"cirId\",\r\n    \"operatorComment\" : \"\",\r\n    \"data\" : \"data\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"closingDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"organizationId\" : 1,\r\n    \"userComment\" : \"userComment\",\r\n    \"companyNumber\" : \"companyNumber\",\r\n    \"categoryCyr\" : \"categoryCyr\",\r\n    \"cirTicketHistory\" : {\r\n      \"cirTicketId\" : 5,\r\n      \"cirTicketChanges\" : [ {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      }, {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      } ]\r\n    },\r\n    \"id\" : 6,\r\n    \"category\" : \"category\",\r\n    \"status\" : \"Active\"\r\n  }, {\r\n    \"resourceId\" : \"Invoice\",\r\n    \"cirId\" : \"cirId\",\r\n    \"operatorComment\" : \"\",\r\n    \"data\" : \"data\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"closingDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"organizationId\" : 1,\r\n    \"userComment\" : \"userComment\",\r\n    \"companyNumber\" : \"companyNumber\",\r\n    \"categoryCyr\" : \"categoryCyr\",\r\n    \"cirTicketHistory\" : {\r\n      \"cirTicketId\" : 5,\r\n      \"cirTicketChanges\" : [ {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      }, {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      } ]\r\n    },\r\n    \"id\" : 6,\r\n    \"category\" : \"category\",\r\n    \"status\" : \"Active\"\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CirTicketListResponse>(exampleJson)
            : default(CirTicketListResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets all tickets from CIR
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/cir-tickets/find")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiCirTicketsFindPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(CirTicketListResponse), description: "Success")]
        public virtual IActionResult ApiPublicApiCirTicketsFindPost([FromBody] CirTicketSearchParameter body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CirTicketListResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"total\" : 0,\r\n  \"tickets\" : [ {\r\n    \"resourceId\" : \"Invoice\",\r\n    \"cirId\" : \"cirId\",\r\n    \"operatorComment\" : \"\",\r\n    \"data\" : \"data\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"closingDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"organizationId\" : 1,\r\n    \"userComment\" : \"userComment\",\r\n    \"companyNumber\" : \"companyNumber\",\r\n    \"categoryCyr\" : \"categoryCyr\",\r\n    \"cirTicketHistory\" : {\r\n      \"cirTicketId\" : 5,\r\n      \"cirTicketChanges\" : [ {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      }, {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      } ]\r\n    },\r\n    \"id\" : 6,\r\n    \"category\" : \"category\",\r\n    \"status\" : \"Active\"\r\n  }, {\r\n    \"resourceId\" : \"Invoice\",\r\n    \"cirId\" : \"cirId\",\r\n    \"operatorComment\" : \"\",\r\n    \"data\" : \"data\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"closingDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"organizationId\" : 1,\r\n    \"userComment\" : \"userComment\",\r\n    \"companyNumber\" : \"companyNumber\",\r\n    \"categoryCyr\" : \"categoryCyr\",\r\n    \"cirTicketHistory\" : {\r\n      \"cirTicketId\" : 5,\r\n      \"cirTicketChanges\" : [ {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      }, {\r\n        \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"newValue\" : \"newValue\",\r\n        \"propertyName\" : \"propertyName\",\r\n        \"serviceDesk\" : true,\r\n        \"id\" : 5,\r\n        \"oldValue\" : \"oldValue\",\r\n        \"user\" : {\r\n          \"firstName\" : \"firstName\",\r\n          \"lastName\" : \"lastName\"\r\n        },\r\n        \"version\" : 2\r\n      } ]\r\n    },\r\n    \"id\" : 6,\r\n    \"category\" : \"category\",\r\n    \"status\" : \"Active\"\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CirTicketListResponse>(exampleJson)
            : default(CirTicketListResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get cir ticket history by CIR ticket Id
        /// </summary>
        /// <param name="cirTicketId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/cir-tickets/getCirTicketHistory/{cirTicketId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiCirTicketsGetCirTicketHistoryCirTicketIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CirTicketHistoryDto), description: "Success")]
        public virtual IActionResult ApiPublicApiCirTicketsGetCirTicketHistoryCirTicketIdGet([FromRoute][Required] int? cirTicketId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CirTicketHistoryDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"cirTicketId\" : 5,\r\n  \"cirTicketChanges\" : [ {\r\n    \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"newValue\" : \"newValue\",\r\n    \"propertyName\" : \"propertyName\",\r\n    \"serviceDesk\" : true,\r\n    \"id\" : 5,\r\n    \"oldValue\" : \"oldValue\",\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\"\r\n    },\r\n    \"version\" : 2\r\n  }, {\r\n    \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"newValue\" : \"newValue\",\r\n    \"propertyName\" : \"propertyName\",\r\n    \"serviceDesk\" : true,\r\n    \"id\" : 5,\r\n    \"oldValue\" : \"oldValue\",\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\"\r\n    },\r\n    \"version\" : 2\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CirTicketHistoryDto>(exampleJson)
            : default(CirTicketHistoryDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }


       

    }
}
