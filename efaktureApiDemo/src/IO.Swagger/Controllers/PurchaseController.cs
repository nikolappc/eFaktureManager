using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Vat;

namespace eFaktureApiDemo.Controllers
{

    [ApiController]

    public class PurchaseController:ControllerBase
    {


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

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<PurchaseInvoiceStatusChangeDto>>(exampleJson)
            : default(List<PurchaseInvoiceStatusChangeDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assign Cir invoice
        /// </summary>
        /// <param name="cirInvoiceId"></param>
        /// <param name="apiKey"></param>
        /// <param name="assignerPartyJBKJS"></param>
        /// <param name="assignationContractNumber"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/{cirInvoiceId}/assign")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceCirInvoiceIdAssignPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(PurchaseInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceCirInvoiceIdAssignPost([FromRoute][Required] string cirInvoiceId, [FromHeader] string apiKey, [FromQuery] string assignerPartyJBKJS, [FromQuery] string assignationContractNumber)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PurchaseInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"receiverUserAccountId\" : 2,\r\n  \"orderNumber\" : \"orderNumber\",\r\n  \"automaticalAcceptance\" : true,\r\n  \"vatRate\" : 4.145608029883936,\r\n  \"creditInvoices\" : [ null, null ],\r\n  \"discountAmount\" : 3.616076749251911,\r\n  \"vatSum\" : 7.386281948385884,\r\n  \"sourceInvoices\" : [ {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  }, {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  } ],\r\n  \"senderReceiverContractNumber\" : \"senderReceiverContractNumber\",\r\n  \"receiverId\" : 5,\r\n  \"referenceNumber\" : \"referenceNumber\",\r\n  \"purchaseSelectedPrepaymentInvoices\" : [ {\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"contractId\" : 9,\r\n    \"invoiceId\" : 1,\r\n    \"prepayedAmount\" : 4.965218492984954,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"outOfEfaktura\" : true,\r\n    \"prepayedVAT\" : 5.025004791520295\r\n  }, {\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"contractId\" : 9,\r\n    \"invoiceId\" : 1,\r\n    \"prepayedAmount\" : 4.965218492984954,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"outOfEfaktura\" : true,\r\n    \"prepayedVAT\" : 5.025004791520295\r\n  } ],\r\n  \"receiverCalculatedVatRate\" : 6.683562403749608,\r\n  \"sumWithVat\" : 1.2315135367772556,\r\n  \"paymentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirHistory\" : {\r\n    \"settlements\" : [ {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"cancellation\" : {\r\n      \"reason\" : \"reason\",\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"cancelledBy\" : 0\r\n    },\r\n    \"assignment\" : {\r\n      \"assignmentDebtorName\" : \"assignmentDebtorName\",\r\n      \"assignmentContractNr\" : \"assignmentContractNr\",\r\n      \"originalIdfNr\" : \"originalIdfNr\",\r\n      \"assignmentDebtorCompanyNr\" : \"assignmentDebtorCompanyNr\",\r\n      \"assignmentIdfNr\" : \"assignmentIdfNr\"\r\n    },\r\n    \"comment\" : \"comment\",\r\n    \"amountChanges\" : [ {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"totalToPay\" : 8.762042012749001,\r\n  \"isPrepaymentInvoice\" : true,\r\n  \"receiver\" : \"receiver\",\r\n  \"addVatRate\" : true,\r\n  \"publicPurchaseContractSignerId\" : 5,\r\n  \"isRelatedToInvoicesFromPreviosPeriod\" : true,\r\n  \"duplicate\" : 1,\r\n  \"invoiceTotalVatPaymentsCalculationDomestic\" : {\r\n    \"vatPerRateCalculations\" : [ {\r\n      \"baseSumForPaymentVatRate\" : 3.5571952270680973,\r\n      \"vatRate\" : 6.438423552598547,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"vatPaymentPerRate\" : 6.965117697638846\r\n    }, {\r\n      \"baseSumForPaymentVatRate\" : 3.5571952270680973,\r\n      \"vatRate\" : 6.438423552598547,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"vatPaymentPerRate\" : 6.965117697638846\r\n    } ],\r\n    \"totalVatPaymentsDomestic\" : 1.284659006116532\r\n  },\r\n  \"cirSettledAmount\" : 9.369310271410669,\r\n  \"sourceInvoiceSelectionMode\" : \"InvoiceSelection\",\r\n  \"sender\" : \"sender\",\r\n  \"receiverCalculatesVat\" : true,\r\n  \"files\" : [ {\r\n    \"mainPdf\" : true,\r\n    \"isLink\" : true,\r\n    \"extension\" : \"extension\",\r\n    \"isFitekInZip\" : true,\r\n    \"mainXml\" : true,\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"extendedPdf\" : true,\r\n    \"invoiceId\" : 7,\r\n    \"id\" : 6\r\n  }, {\r\n    \"mainPdf\" : true,\r\n    \"isLink\" : true,\r\n    \"extension\" : \"extension\",\r\n    \"isFitekInZip\" : true,\r\n    \"mainXml\" : true,\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"extendedPdf\" : true,\r\n    \"invoiceId\" : 7,\r\n    \"id\" : 6\r\n  } ],\r\n  \"fiscalBillNumbersRepresentation\" : [ {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  }, {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  } ],\r\n  \"objectIdentifier\" : \"objectIdentifier\",\r\n  \"publicPurchaseContractSigner\" : \"publicPurchaseContractSigner\",\r\n  \"status\" : \"New\",\r\n  \"note\" : \"note\",\r\n  \"roundingAmount\" : 2.8841621266687802,\r\n  \"accountingDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"indebtednessPeriodFromDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"customFields\" : [ {\r\n    \"value\" : \"value\",\r\n    \"customField\" : \"DocumentType\"\r\n  }, {\r\n    \"value\" : \"value\",\r\n    \"customField\" : \"DocumentType\"\r\n  } ],\r\n  \"indebtednessPeriodToDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"description\" : \"description\",\r\n  \"vatPointDate\" : \"None\",\r\n  \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"ispName\" : \"ispName\",\r\n  \"discountPercentage\" : 9.301444243932576,\r\n  \"acceptRejectMessage\" : \"acceptRejectMessage\",\r\n  \"senderId\" : 1,\r\n  \"isDebitNote\" : true,\r\n  \"ispAcceptedToRepresentCompany\" : true,\r\n  \"currencyName\" : \"currencyName\",\r\n  \"isDeleted\" : true,\r\n  \"invoiceDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceNumber\" : \"invoiceNumber\",\r\n  \"fineRatePerDay\" : 7.061401241503109,\r\n  \"serviceId\" : \"serviceId\",\r\n  \"createdFromXml\" : true,\r\n  \"cirAmountChangeId\" : \"cirAmountChangeId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"invoiceFilePath\" : \"invoiceFilePath\",\r\n  \"senderApplicationId\" : 6,\r\n  \"lotNumber\" : \"lotNumber\",\r\n  \"totalPayments\" : 1.0246457001441578,\r\n  \"sourceInvoicesOutOfEfaktura\" : [ {\r\n    \"sourceInvoiceNumber\" : \"sourceInvoiceNumber\",\r\n    \"sourceInvoiceOutOfEFakturaId\" : 9,\r\n    \"invoiceGlobUniqId\" : \"invoiceGlobUniqId\"\r\n  }, {\r\n    \"sourceInvoiceNumber\" : \"sourceInvoiceNumber\",\r\n    \"sourceInvoiceOutOfEFakturaId\" : 9,\r\n    \"invoiceGlobUniqId\" : \"invoiceGlobUniqId\"\r\n  } ],\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"isCreditInvoice\" : true,\r\n  \"debitNotes\" : [ null, null ],\r\n  \"sumWithoutVat\" : 2.027123023002322,\r\n  \"invoiceId\" : 0,\r\n  \"modelNumber\" : \"modelNumber\",\r\n  \"invoiceMessage\" : \"invoiceMessage\",\r\n  \"salesStatus\" : \"New\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"cancelInvoiceMessage\" : \"cancelInvoiceMessage\",\r\n  \"cirAssignationHistory\" : {\r\n    \"invoiceChanges\" : [ {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    }, {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    } ],\r\n    \"invoiceId\" : 5\r\n  },\r\n  \"internalRoutingNumber\" : \"internalRoutingNumber\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseInvoiceDto>(exampleJson)
            : default(PurchaseInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Cancel Cir invoice assignment
        /// </summary>
        /// <param name="cirInvoiceId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/{cirInvoiceId}/cancelassign")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceCirInvoiceIdCancelassignGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(PurchaseInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceCirInvoiceIdCancelassignGet([FromRoute][Required] string cirInvoiceId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PurchaseInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"receiverUserAccountId\" : 2,\r\n  \"orderNumber\" : \"orderNumber\",\r\n  \"automaticalAcceptance\" : true,\r\n  \"vatRate\" : 4.145608029883936,\r\n  \"creditInvoices\" : [ null, null ],\r\n  \"discountAmount\" : 3.616076749251911,\r\n  \"vatSum\" : 7.386281948385884,\r\n  \"sourceInvoices\" : [ {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  }, {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  } ],\r\n  \"senderReceiverContractNumber\" : \"senderReceiverContractNumber\",\r\n  \"receiverId\" : 5,\r\n  \"referenceNumber\" : \"referenceNumber\",\r\n  \"purchaseSelectedPrepaymentInvoices\" : [ {\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"contractId\" : 9,\r\n    \"invoiceId\" : 1,\r\n    \"prepayedAmount\" : 4.965218492984954,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"outOfEfaktura\" : true,\r\n    \"prepayedVAT\" : 5.025004791520295\r\n  }, {\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"contractId\" : 9,\r\n    \"invoiceId\" : 1,\r\n    \"prepayedAmount\" : 4.965218492984954,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"outOfEfaktura\" : true,\r\n    \"prepayedVAT\" : 5.025004791520295\r\n  } ],\r\n  \"receiverCalculatedVatRate\" : 6.683562403749608,\r\n  \"sumWithVat\" : 1.2315135367772556,\r\n  \"paymentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirHistory\" : {\r\n    \"settlements\" : [ {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"cancellation\" : {\r\n      \"reason\" : \"reason\",\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"cancelledBy\" : 0\r\n    },\r\n    \"assignment\" : {\r\n      \"assignmentDebtorName\" : \"assignmentDebtorName\",\r\n      \"assignmentContractNr\" : \"assignmentContractNr\",\r\n      \"originalIdfNr\" : \"originalIdfNr\",\r\n      \"assignmentDebtorCompanyNr\" : \"assignmentDebtorCompanyNr\",\r\n      \"assignmentIdfNr\" : \"assignmentIdfNr\"\r\n    },\r\n    \"comment\" : \"comment\",\r\n    \"amountChanges\" : [ {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"totalToPay\" : 8.762042012749001,\r\n  \"isPrepaymentInvoice\" : true,\r\n  \"receiver\" : \"receiver\",\r\n  \"addVatRate\" : true,\r\n  \"publicPurchaseContractSignerId\" : 5,\r\n  \"isRelatedToInvoicesFromPreviosPeriod\" : true,\r\n  \"duplicate\" : 1,\r\n  \"invoiceTotalVatPaymentsCalculationDomestic\" : {\r\n    \"vatPerRateCalculations\" : [ {\r\n      \"baseSumForPaymentVatRate\" : 3.5571952270680973,\r\n      \"vatRate\" : 6.438423552598547,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"vatPaymentPerRate\" : 6.965117697638846\r\n    }, {\r\n      \"baseSumForPaymentVatRate\" : 3.5571952270680973,\r\n      \"vatRate\" : 6.438423552598547,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"vatPaymentPerRate\" : 6.965117697638846\r\n    } ],\r\n    \"totalVatPaymentsDomestic\" : 1.284659006116532\r\n  },\r\n  \"cirSettledAmount\" : 9.369310271410669,\r\n  \"sourceInvoiceSelectionMode\" : \"InvoiceSelection\",\r\n  \"sender\" : \"sender\",\r\n  \"receiverCalculatesVat\" : true,\r\n  \"files\" : [ {\r\n    \"mainPdf\" : true,\r\n    \"isLink\" : true,\r\n    \"extension\" : \"extension\",\r\n    \"isFitekInZip\" : true,\r\n    \"mainXml\" : true,\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"extendedPdf\" : true,\r\n    \"invoiceId\" : 7,\r\n    \"id\" : 6\r\n  }, {\r\n    \"mainPdf\" : true,\r\n    \"isLink\" : true,\r\n    \"extension\" : \"extension\",\r\n    \"isFitekInZip\" : true,\r\n    \"mainXml\" : true,\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"extendedPdf\" : true,\r\n    \"invoiceId\" : 7,\r\n    \"id\" : 6\r\n  } ],\r\n  \"fiscalBillNumbersRepresentation\" : [ {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  }, {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  } ],\r\n  \"objectIdentifier\" : \"objectIdentifier\",\r\n  \"publicPurchaseContractSigner\" : \"publicPurchaseContractSigner\",\r\n  \"status\" : \"New\",\r\n  \"note\" : \"note\",\r\n  \"roundingAmount\" : 2.8841621266687802,\r\n  \"accountingDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"indebtednessPeriodFromDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"customFields\" : [ {\r\n    \"value\" : \"value\",\r\n    \"customField\" : \"DocumentType\"\r\n  }, {\r\n    \"value\" : \"value\",\r\n    \"customField\" : \"DocumentType\"\r\n  } ],\r\n  \"indebtednessPeriodToDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"description\" : \"description\",\r\n  \"vatPointDate\" : \"None\",\r\n  \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"ispName\" : \"ispName\",\r\n  \"discountPercentage\" : 9.301444243932576,\r\n  \"acceptRejectMessage\" : \"acceptRejectMessage\",\r\n  \"senderId\" : 1,\r\n  \"isDebitNote\" : true,\r\n  \"ispAcceptedToRepresentCompany\" : true,\r\n  \"currencyName\" : \"currencyName\",\r\n  \"isDeleted\" : true,\r\n  \"invoiceDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceNumber\" : \"invoiceNumber\",\r\n  \"fineRatePerDay\" : 7.061401241503109,\r\n  \"serviceId\" : \"serviceId\",\r\n  \"createdFromXml\" : true,\r\n  \"cirAmountChangeId\" : \"cirAmountChangeId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"invoiceFilePath\" : \"invoiceFilePath\",\r\n  \"senderApplicationId\" : 6,\r\n  \"lotNumber\" : \"lotNumber\",\r\n  \"totalPayments\" : 1.0246457001441578,\r\n  \"sourceInvoicesOutOfEfaktura\" : [ {\r\n    \"sourceInvoiceNumber\" : \"sourceInvoiceNumber\",\r\n    \"sourceInvoiceOutOfEFakturaId\" : 9,\r\n    \"invoiceGlobUniqId\" : \"invoiceGlobUniqId\"\r\n  }, {\r\n    \"sourceInvoiceNumber\" : \"sourceInvoiceNumber\",\r\n    \"sourceInvoiceOutOfEFakturaId\" : 9,\r\n    \"invoiceGlobUniqId\" : \"invoiceGlobUniqId\"\r\n  } ],\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"isCreditInvoice\" : true,\r\n  \"debitNotes\" : [ null, null ],\r\n  \"sumWithoutVat\" : 2.027123023002322,\r\n  \"invoiceId\" : 0,\r\n  \"modelNumber\" : \"modelNumber\",\r\n  \"invoiceMessage\" : \"invoiceMessage\",\r\n  \"salesStatus\" : \"New\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"cancelInvoiceMessage\" : \"cancelInvoiceMessage\",\r\n  \"cirAssignationHistory\" : {\r\n    \"invoiceChanges\" : [ {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    }, {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    } ],\r\n    \"invoiceId\" : 5\r\n  },\r\n  \"internalRoutingNumber\" : \"internalRoutingNumber\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseInvoiceDto>(exampleJson)
            : default(PurchaseInvoiceDto);            //TODO: Change the data returned
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
        /// Download purchase invoice ubl as FileStream by CIR invoice id
        /// </summary>
        /// <param name="cirInvoiceId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/ubl/{cirInvoiceId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiPurchaseInvoiceUblCirInvoiceIdGet")]
        public virtual IActionResult ApiPublicApiPurchaseInvoiceUblCirInvoiceIdGet([FromRoute][Required] string cirInvoiceId, [FromHeader] string apiKey)
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
