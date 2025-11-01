using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.Api.Models.Invoices;
using eFaktureModel.Api.Models.Vat;
using eFaktureModel.Api.Models.Dto;
using eFaktureModel.Api.Models.Enums;

namespace eFaktureApiDemo.Controllers
{

    [ApiController]

    public class SalesController:ControllerBase
    {

        /// <summary>
        /// Cancel invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/cancel")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceCancelPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceCancelPost([FromBody] CancelInvoiceMessageDto body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"channelAddress\" : \"channelAddress\",\r\n  \"orderNumber\" : \"orderNumber\",\r\n  \"prepaymentCalculation\" : {\r\n    \"prepaymentFeeReductionForVatCategories\" : [ {\r\n      \"amount\" : 7.835035282970782,\r\n      \"vatRate\" : 3.1497903714250555,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"taxAmount\" : 0.4768402382624515\r\n    }, {\r\n      \"amount\" : 7.835035282970782,\r\n      \"vatRate\" : 3.1497903714250555,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"taxAmount\" : 0.4768402382624515\r\n    } ],\r\n    \"totalPrepaymentInvoice\" : 5.877124706116695,\r\n    \"prepaymentPaidVat\" : 9.897492629215506,\r\n    \"totalPrepaymentWithoutVat\" : 3.111202833403195\r\n  },\r\n  \"vatRate\" : 7.061401241503109,\r\n  \"creditInvoices\" : [ null, null ],\r\n  \"channel\" : 6,\r\n  \"bankAccounts\" : [ {\r\n    \"bankAccountId\" : 0,\r\n    \"salesInvoiceId\" : 7,\r\n    \"unifiedBankAccount\" : \"unifiedBankAccount\"\r\n  }, {\r\n    \"bankAccountId\" : 0,\r\n    \"salesInvoiceId\" : 7,\r\n    \"unifiedBankAccount\" : \"unifiedBankAccount\"\r\n  } ],\r\n  \"discountAmount\" : 5.637376656633329,\r\n  \"errorCode\" : \"Invalid\",\r\n  \"vatSum\" : 9.301444243932576,\r\n  \"publicPurchaseContractSignerContractId\" : 1,\r\n  \"sourceInvoices\" : [ {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  }, {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  } ],\r\n  \"senderReceiverContractNumber\" : \"senderReceiverContractNumber\",\r\n  \"exemptionReasonsByVatCategory\" : [ {\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"feeItemsValueWithoutVat\" : 3.804112695731078,\r\n    \"feeWithoutVat\" : 4.518309517874243,\r\n    \"reasonCode\" : \"reasonCode\",\r\n    \"exemptionDecisionNumber\" : \"exemptionDecisionNumber\",\r\n    \"discountFeeWithoutVat\" : 8.675064425986758\r\n  }, {\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"feeItemsValueWithoutVat\" : 3.804112695731078,\r\n    \"feeWithoutVat\" : 4.518309517874243,\r\n    \"reasonCode\" : \"reasonCode\",\r\n    \"exemptionDecisionNumber\" : \"exemptionDecisionNumber\",\r\n    \"discountFeeWithoutVat\" : 8.675064425986758\r\n  } ],\r\n  \"receiverId\" : 4,\r\n  \"discounts\" : [ {\r\n    \"amount\" : 0.4833312865174044,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"vatRate\" : 0.35262192099236644\r\n  }, {\r\n    \"amount\" : 0.4833312865174044,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"vatRate\" : 0.35262192099236644\r\n  } ],\r\n  \"referenceNumber\" : \"referenceNumber\",\r\n  \"uasSender\" : {\r\n    \"informationServiceProviderName\" : \"informationServiceProviderName\",\r\n    \"addresses\" : [ null, null ],\r\n    \"groupId\" : [ 3, 3 ],\r\n    \"bankAccounts\" : [ {\r\n      \"bankId\" : 3,\r\n      \"isPrimary\" : true,\r\n      \"bankAccountId\" : 6,\r\n      \"iban\" : \"iban\",\r\n      \"currency\" : \"currency\",\r\n      \"unifiedBankAccount\" : \"unifiedBankAccount\",\r\n      \"swift\" : \"swift\"\r\n    }, {\r\n      \"bankId\" : 3,\r\n      \"isPrimary\" : true,\r\n      \"bankAccountId\" : 6,\r\n      \"iban\" : \"iban\",\r\n      \"currency\" : \"currency\",\r\n      \"unifiedBankAccount\" : \"unifiedBankAccount\",\r\n      \"swift\" : \"swift\"\r\n    } ],\r\n    \"hasISP\" : true,\r\n    \"contactPerson\" : \"contactPerson\",\r\n    \"countryId\" : 5,\r\n    \"companyWillBeDeletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"emails\" : [ {\r\n      \"isActivated\" : true,\r\n      \"email\" : \"\",\r\n      \"activationToken\" : \"activationToken\"\r\n    }, {\r\n      \"isActivated\" : true,\r\n      \"email\" : \"\",\r\n      \"activationToken\" : \"activationToken\"\r\n    } ],\r\n    \"plusChannelsActive\" : true,\r\n    \"nonSebIbanWarning\" : true,\r\n    \"ispAcceptedToRepresentCompany\" : true,\r\n    \"registrationCode\" : \"registrationCode\",\r\n    \"logo\" : \"logo\",\r\n    \"additionalCode\" : \"additionalCode\",\r\n    \"settings\" : {\r\n      \"homeRoute\" : \"homeRoute\",\r\n      \"modules\" : [ \"root\", \"root\" ]\r\n    },\r\n    \"isMainCompany\" : true,\r\n    \"specialTreatment\" : true,\r\n    \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n    \"isPrivateCompany\" : true,\r\n    \"contactEmail\" : \"contactEmail\",\r\n    \"webAddress\" : \"webAddress\",\r\n    \"packageId\" : 7,\r\n    \"informationServiceProviderId\" : 0,\r\n    \"storeInvoiceDetails\" : true,\r\n    \"companyId\" : 6,\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"budgetCompanyType\" : \"budgetCompanyType\",\r\n    \"status\" : \"Active\"\r\n  },\r\n  \"sumWithVat\" : 3.616076749251911,\r\n  \"paymentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirHistory\" : {\r\n    \"settlements\" : [ {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"cancellation\" : {\r\n      \"reason\" : \"reason\",\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"cancelledBy\" : 0\r\n    },\r\n    \"assignment\" : {\r\n      \"assignmentDebtorName\" : \"assignmentDebtorName\",\r\n      \"assignmentContractNr\" : \"assignmentContractNr\",\r\n      \"originalIdfNr\" : \"originalIdfNr\",\r\n      \"assignmentDebtorCompanyNr\" : \"assignmentDebtorCompanyNr\",\r\n      \"assignmentIdfNr\" : \"assignmentIdfNr\"\r\n    },\r\n    \"comment\" : \"comment\",\r\n    \"amountChanges\" : [ {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"totalToPay\" : 9.254183946267839,\r\n  \"isPrepaymentInvoice\" : true,\r\n  \"receiver\" : \"receiver\",\r\n  \"contract\" : {\r\n    \"channelAddress\" : \"channelAddress\",\r\n    \"addresses\" : [ {\r\n      \"city\" : \"city\",\r\n      \"streetAndHouse\" : \"streetAndHouse\",\r\n      \"postalIndex\" : \"postalIndex\",\r\n      \"countryId\" : 9,\r\n      \"addressId\" : 5\r\n    }, {\r\n      \"city\" : \"city\",\r\n      \"streetAndHouse\" : \"streetAndHouse\",\r\n      \"postalIndex\" : \"postalIndex\",\r\n      \"countryId\" : 9,\r\n      \"addressId\" : 5\r\n    } ],\r\n    \"customFields\" : [ {\r\n      \"name\" : \"name\",\r\n      \"id\" : 9,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"name\" : \"name\",\r\n      \"id\" : 9,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"channel\" : 9,\r\n    \"invoiceCurrency\" : \"invoiceCurrency\",\r\n    \"isReceiverCompanyDeleted\" : true,\r\n    \"isDeleted\" : true,\r\n    \"ownerCompanyId\" : 8,\r\n    \"invoiceNotificationEmail\" : \"invoiceNotificationEmail\",\r\n    \"sendInvoiceToCir\" : true,\r\n    \"fineRatePerDay\" : 4964.721971135656,\r\n    \"serviceId\" : \"serviceId\",\r\n    \"paymentTerms\" : 1172,\r\n    \"contactPersonMail\" : \"\",\r\n    \"contractDesc\" : \"contractDesc\",\r\n    \"referenceNr\" : \"referenceNr\",\r\n    \"contractNumber\" : 6,\r\n    \"contractApplication\" : {\r\n      \"channelAddress\" : \"channelAddress\",\r\n      \"addresses\" : [ null, null ],\r\n      \"contractDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"contractApplicationId\" : 3,\r\n      \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n      \"companyName\" : \"companyName\",\r\n      \"referenceNr\" : \"referenceNr\",\r\n      \"channel\" : 6,\r\n      \"contactPersonName\" : \"contactPersonName\",\r\n      \"companyEmail\" : \"companyEmail\",\r\n      \"companyPhone\" : \"companyPhone\",\r\n      \"serviceProvider\" : \"serviceProvider\",\r\n      \"registrationCode\" : \"registrationCode\",\r\n      \"invoiceNotificationEmail\" : \"invoiceNotificationEmail\",\r\n      \"serviceId\" : \"serviceId\",\r\n      \"fineRatePerDay\" : 2.8841621266687802,\r\n      \"paymentTerms\" : 1,\r\n      \"contactPersonEmail\" : \"contactPersonEmail\",\r\n      \"receiverCompanyId\" : 6,\r\n      \"companyLabel\" : \"companyLabel\"\r\n    },\r\n    \"contactPersonName\" : \"contactPersonName\",\r\n    \"channels\" : [ 6, 6 ],\r\n    \"contractId\" : 6,\r\n    \"serviceProvider\" : \"serviceProvider\",\r\n    \"isBudgetClient\" : true,\r\n    \"availableContracts\" : [ \"availableContracts\", \"availableContracts\" ],\r\n    \"customerSupplierId\" : 7\r\n  },\r\n  \"version\" : 2,\r\n  \"cirSettledAmount\" : 1.8268702177058116,\r\n  \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n  \"sourceInvoiceSelectionMode\" : \"InvoiceSelection\",\r\n  \"sender\" : \"sender\",\r\n  \"serviceProvider\" : \"serviceProvider\",\r\n  \"fiscalBillNumbersRepresentation\" : [ {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  }, {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  } ],\r\n  \"publicPurchaseContractSigner\" : {\r\n    \"lastName\" : \"lastName\",\r\n    \"personalId\" : \"personalId\",\r\n    \"specialTreatment\" : true,\r\n    \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n    \"companyName\" : \"companyName\",\r\n    \"language\" : \"cs_CZ\",\r\n    \"isCompany\" : true,\r\n    \"countryId\" : 1,\r\n    \"firstName\" : \"firstName\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"ownerCompanyId\" : 1,\r\n    \"registrationCode\" : \"registrationCode\",\r\n    \"companyMail\" : \"\",\r\n    \"serbiaCompanyType\" : \"Company\",\r\n    \"customerSupplierId\" : 7,\r\n    \"email\" : \"email\",\r\n    \"additionalCode\" : \"additionalCode\"\r\n  },\r\n  \"invoiceTotalPaymentsCalculation\" : {\r\n    \"paymentFeeForVatCategories\" : [ null, null ],\r\n    \"totalPayments\" : 2.380090174313445\r\n  },\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"status\" : \"New\",\r\n  \"note\" : \"note\",\r\n  \"roundingAmount\" : 7.203794749804894,\r\n  \"accountingDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"attachments\" : [ {\r\n    \"isLink\" : true,\r\n    \"fileName\" : \"fileName\",\r\n    \"fileSize\" : 9,\r\n    \"fileData\" : \"\",\r\n    \"isUbl\" : true,\r\n    \"link\" : \"link\",\r\n    \"invoiceId\" : 9,\r\n    \"id\" : 0,\r\n    \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"isLink\" : true,\r\n    \"fileName\" : \"fileName\",\r\n    \"fileSize\" : 9,\r\n    \"fileData\" : \"\",\r\n    \"isUbl\" : true,\r\n    \"link\" : \"link\",\r\n    \"invoiceId\" : 9,\r\n    \"id\" : 0,\r\n    \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"indebtednessPeriodFromDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"indebtednessPeriodToDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"description\" : \"description\",\r\n  \"vatPointDate\" : 3,\r\n  \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"discountPercentage\" : 5.962133916683182,\r\n  \"acceptRejectMessage\" : \"acceptRejectMessage\",\r\n  \"senderId\" : 6,\r\n  \"isDebitNote\" : true,\r\n  \"selectedPrepaymentInvoices\" : [ {\r\n    \"contractId\" : 4,\r\n    \"individualPrepaymentCalculations\" : [ {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    }, {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    } ],\r\n    \"selectedPrepaymentInvoiceId\" : 5,\r\n    \"prepaymentInvoiceId\" : 4,\r\n    \"prepayedAmount\" : 6.073898085781152,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n    \"prepayedVAT\" : 8.251625748923757\r\n  }, {\r\n    \"contractId\" : 4,\r\n    \"individualPrepaymentCalculations\" : [ {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    }, {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    } ],\r\n    \"selectedPrepaymentInvoiceId\" : 5,\r\n    \"prepaymentInvoiceId\" : 4,\r\n    \"prepayedAmount\" : 6.073898085781152,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n    \"prepayedVAT\" : 8.251625748923757\r\n  } ],\r\n  \"invoiceDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceNumber\" : \"invoiceNumber\",\r\n  \"currency\" : \"currency\",\r\n  \"sendInvoiceToCir\" : true,\r\n  \"serviceId\" : \"serviceId\",\r\n  \"fineRatePerDay\" : 1.4658129805029452,\r\n  \"isProFormaInvoice\" : true,\r\n  \"createdFromXml\" : true,\r\n  \"cirAmountChangeId\" : \"cirAmountChangeId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"lotNumber\" : \"lotNumber\",\r\n  \"rows\" : [ {\r\n    \"unitPrice\" : 7.740351818741173,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"orderNo\" : 8,\r\n    \"code\" : \"code\",\r\n    \"quantity\" : 3.0205796992916243,\r\n    \"vatRate\" : 32.58856561904761,\r\n    \"description\" : \"description\",\r\n    \"discountAmount\" : 7.04836565559697,\r\n    \"vatSum\" : 4.078845849666752,\r\n    \"rowId\" : 0,\r\n    \"discountPercentage\" : 30.576100241049343,\r\n    \"unit\" : \"unit\",\r\n    \"classificationCode\" : \"classificationCode\",\r\n    \"sumWithoutVat\" : 5.533258397034986,\r\n    \"invoiceId\" : 4,\r\n    \"sumWithVat\" : 0.2025324113236393,\r\n    \"allowances\" : [ {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    }, {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    } ]\r\n  }, {\r\n    \"unitPrice\" : 7.740351818741173,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"orderNo\" : 8,\r\n    \"code\" : \"code\",\r\n    \"quantity\" : 3.0205796992916243,\r\n    \"vatRate\" : 32.58856561904761,\r\n    \"description\" : \"description\",\r\n    \"discountAmount\" : 7.04836565559697,\r\n    \"vatSum\" : 4.078845849666752,\r\n    \"rowId\" : 0,\r\n    \"discountPercentage\" : 30.576100241049343,\r\n    \"unit\" : \"unit\",\r\n    \"classificationCode\" : \"classificationCode\",\r\n    \"sumWithoutVat\" : 5.533258397034986,\r\n    \"invoiceId\" : 4,\r\n    \"sumWithVat\" : 0.2025324113236393,\r\n    \"allowances\" : [ {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    }, {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    } ]\r\n  } ],\r\n  \"globUniqId\" : \"globUniqId\",\r\n  \"lastModifiedUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"isCreditInvoice\" : true,\r\n  \"totalRowsCount\" : 7,\r\n  \"debitNotes\" : [ null, null ],\r\n  \"sumWithoutVat\" : 2.3021358869347655,\r\n  \"fiscalBillNumbers\" : [ \"fiscalBillNumbers\", \"fiscalBillNumbers\" ],\r\n  \"invoiceId\" : 0,\r\n  \"modelNumber\" : \"modelNumber\",\r\n  \"invoiceMessage\" : \"invoiceMessage\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"cancelInvoiceMessage\" : \"cancelInvoiceMessage\",\r\n  \"cirAssignationHistory\" : {\r\n    \"invoiceChanges\" : [ {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    }, {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    } ],\r\n    \"invoiceId\" : 5\r\n  }\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InvoiceDto>(exampleJson)
            : default(InvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Search for all sales invoices which status changed on specific date
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="date"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/changes")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceChangesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SalesInvoiceStatusChangeDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceChangesPost([FromHeader] string apiKey, [FromQuery] DateTime? date)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SalesInvoiceStatusChangeDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"salesInvoiceId\" : 6,\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n}, {\r\n  \"date\" : \"date\",\r\n  \"eventId\" : 0,\r\n  \"isAutoAssigned\" : true,\r\n  \"cirAssignmentChange\" : \"Assignment\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"isSigned\" : true,\r\n  \"newInvoiceStatus\" : \"New\",\r\n  \"salesInvoiceId\" : 6,\r\n  \"comment\" : \"comment\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"subscriptionKey\" : \"subscriptionKey\"\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SalesInvoiceStatusChangeDto>>(exampleJson)
            : default(List<SalesInvoiceStatusChangeDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete only draft or new sales invoices, other invoices are ignored.
        /// </summary>
        /// <remarks>Sample Request: [ salesInvoiceId1, salesInvoiceId2, salesInvoiceId3 ]</remarks>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<long?>), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceDelete([FromBody] List<long?> body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<long?>));
            string exampleJson = null;
            exampleJson = "[ 0, 0 ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<long?>>(exampleJson)
            : default(List<long?>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get sales invoice
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SimpleSalesInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SimpleSalesInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"cancelComment\" : \"cancelComment\",\r\n  \"version\" : 6,\r\n  \"cirSettledAmount\" : 1.4658129805029452,\r\n  \"globUniqId\" : \"globUniqId\",\r\n  \"lastModifiedUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceId\" : 0,\r\n  \"comment\" : \"comment\",\r\n  \"stornoComment\" : \"stornoComment\",\r\n  \"status\" : \"New\"\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SimpleSalesInvoiceDto>(exampleJson)
            : default(SimpleSalesInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get list of all exemption reasons
        /// </summary>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/getValueAddedTaxExemptionReasonList")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceGetValueAddedTaxExemptionReasonListGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ValueAddedTaxExemptionReasonDto>), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceGetValueAddedTaxExemptionReasonListGet([FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ValueAddedTaxExemptionReasonDto>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"paragraph\" : \"paragraph\",\r\n  \"law\" : \"law\",\r\n  \"reasonId\" : 0,\r\n  \"subpoint\" : \"subpoint\",\r\n  \"activeTo\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"text\" : \"text\",\r\n  \"category\" : \"category\",\r\n  \"key\" : \"key\",\r\n  \"article\" : \"article\",\r\n  \"point\" : \"point\",\r\n  \"freeFormNote\" : \"freeFormNote\",\r\n  \"activeFrom\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"paragraph\" : \"paragraph\",\r\n  \"law\" : \"law\",\r\n  \"reasonId\" : 0,\r\n  \"subpoint\" : \"subpoint\",\r\n  \"activeTo\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"text\" : \"text\",\r\n  \"category\" : \"category\",\r\n  \"key\" : \"key\",\r\n  \"article\" : \"article\",\r\n  \"point\" : \"point\",\r\n  \"freeFormNote\" : \"freeFormNote\",\r\n  \"activeFrom\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ValueAddedTaxExemptionReasonDto>>(exampleJson)
            : default(List<ValueAddedTaxExemptionReasonDto>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get sales invoice IDs
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="status"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ids")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceIdsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(SalesInvoicesDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceIdsPost([FromHeader] string apiKey, [FromQuery] string status, [FromQuery] DateTime? dateFrom, [FromQuery] DateTime? dateTo)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SalesInvoicesDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"salesInvoiceIds\" : [ 0, 0 ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SalesInvoicesDto>(exampleJson)
            : default(SalesInvoicesDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete only draft or new sales invoices, other invoices cannot be deleted
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/{invoiceId}")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceInvoiceIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long?), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceInvoiceIdDelete([FromRoute][Required] long? invoiceId, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long?));
            string exampleJson = null;
            exampleJson = "0";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long?>(exampleJson)
            : default(long?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Download sales invoice extended PDF as FileStream or generate new one if not exists
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/pdf")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoicePdfGet")]
        public virtual IActionResult ApiPublicApiSalesInvoicePdfGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get sales invoice signature
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/signature")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceSignatureGet")]
        public virtual IActionResult ApiPublicApiSalesInvoiceSignatureGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Invoice Storno Cancellation
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/storno")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceStornoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceStornoPost([FromBody] StornoInvoiceMessageDto body, [FromHeader] string apiKey)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"channelAddress\" : \"channelAddress\",\r\n  \"orderNumber\" : \"orderNumber\",\r\n  \"prepaymentCalculation\" : {\r\n    \"prepaymentFeeReductionForVatCategories\" : [ {\r\n      \"amount\" : 7.835035282970782,\r\n      \"vatRate\" : 3.1497903714250555,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"taxAmount\" : 0.4768402382624515\r\n    }, {\r\n      \"amount\" : 7.835035282970782,\r\n      \"vatRate\" : 3.1497903714250555,\r\n      \"vatCategory\" : \"vatCategory\",\r\n      \"taxAmount\" : 0.4768402382624515\r\n    } ],\r\n    \"totalPrepaymentInvoice\" : 5.877124706116695,\r\n    \"prepaymentPaidVat\" : 9.897492629215506,\r\n    \"totalPrepaymentWithoutVat\" : 3.111202833403195\r\n  },\r\n  \"vatRate\" : 7.061401241503109,\r\n  \"creditInvoices\" : [ null, null ],\r\n  \"channel\" : 6,\r\n  \"bankAccounts\" : [ {\r\n    \"bankAccountId\" : 0,\r\n    \"salesInvoiceId\" : 7,\r\n    \"unifiedBankAccount\" : \"unifiedBankAccount\"\r\n  }, {\r\n    \"bankAccountId\" : 0,\r\n    \"salesInvoiceId\" : 7,\r\n    \"unifiedBankAccount\" : \"unifiedBankAccount\"\r\n  } ],\r\n  \"discountAmount\" : 5.637376656633329,\r\n  \"errorCode\" : \"Invalid\",\r\n  \"vatSum\" : 9.301444243932576,\r\n  \"publicPurchaseContractSignerContractId\" : 1,\r\n  \"sourceInvoices\" : [ {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  }, {\r\n    \"cirInvoiceId\" : \"cirInvoiceId\",\r\n    \"invoiceNumber\" : \"invoiceNumber\",\r\n    \"invoiceId\" : \"invoiceId\",\r\n    \"sentToCir\" : true\r\n  } ],\r\n  \"senderReceiverContractNumber\" : \"senderReceiverContractNumber\",\r\n  \"exemptionReasonsByVatCategory\" : [ {\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"feeItemsValueWithoutVat\" : 3.804112695731078,\r\n    \"feeWithoutVat\" : 4.518309517874243,\r\n    \"reasonCode\" : \"reasonCode\",\r\n    \"exemptionDecisionNumber\" : \"exemptionDecisionNumber\",\r\n    \"discountFeeWithoutVat\" : 8.675064425986758\r\n  }, {\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"feeItemsValueWithoutVat\" : 3.804112695731078,\r\n    \"feeWithoutVat\" : 4.518309517874243,\r\n    \"reasonCode\" : \"reasonCode\",\r\n    \"exemptionDecisionNumber\" : \"exemptionDecisionNumber\",\r\n    \"discountFeeWithoutVat\" : 8.675064425986758\r\n  } ],\r\n  \"receiverId\" : 4,\r\n  \"discounts\" : [ {\r\n    \"amount\" : 0.4833312865174044,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"vatRate\" : 0.35262192099236644\r\n  }, {\r\n    \"amount\" : 0.4833312865174044,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"vatRate\" : 0.35262192099236644\r\n  } ],\r\n  \"referenceNumber\" : \"referenceNumber\",\r\n  \"uasSender\" : {\r\n    \"informationServiceProviderName\" : \"informationServiceProviderName\",\r\n    \"addresses\" : [ null, null ],\r\n    \"groupId\" : [ 3, 3 ],\r\n    \"bankAccounts\" : [ {\r\n      \"bankId\" : 3,\r\n      \"isPrimary\" : true,\r\n      \"bankAccountId\" : 6,\r\n      \"iban\" : \"iban\",\r\n      \"currency\" : \"currency\",\r\n      \"unifiedBankAccount\" : \"unifiedBankAccount\",\r\n      \"swift\" : \"swift\"\r\n    }, {\r\n      \"bankId\" : 3,\r\n      \"isPrimary\" : true,\r\n      \"bankAccountId\" : 6,\r\n      \"iban\" : \"iban\",\r\n      \"currency\" : \"currency\",\r\n      \"unifiedBankAccount\" : \"unifiedBankAccount\",\r\n      \"swift\" : \"swift\"\r\n    } ],\r\n    \"hasISP\" : true,\r\n    \"contactPerson\" : \"contactPerson\",\r\n    \"countryId\" : 5,\r\n    \"companyWillBeDeletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"emails\" : [ {\r\n      \"isActivated\" : true,\r\n      \"email\" : \"\",\r\n      \"activationToken\" : \"activationToken\"\r\n    }, {\r\n      \"isActivated\" : true,\r\n      \"email\" : \"\",\r\n      \"activationToken\" : \"activationToken\"\r\n    } ],\r\n    \"plusChannelsActive\" : true,\r\n    \"nonSebIbanWarning\" : true,\r\n    \"ispAcceptedToRepresentCompany\" : true,\r\n    \"registrationCode\" : \"registrationCode\",\r\n    \"logo\" : \"logo\",\r\n    \"additionalCode\" : \"additionalCode\",\r\n    \"settings\" : {\r\n      \"homeRoute\" : \"homeRoute\",\r\n      \"modules\" : [ \"root\", \"root\" ]\r\n    },\r\n    \"isMainCompany\" : true,\r\n    \"specialTreatment\" : true,\r\n    \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n    \"isPrivateCompany\" : true,\r\n    \"contactEmail\" : \"contactEmail\",\r\n    \"webAddress\" : \"webAddress\",\r\n    \"packageId\" : 7,\r\n    \"informationServiceProviderId\" : 0,\r\n    \"storeInvoiceDetails\" : true,\r\n    \"companyId\" : 6,\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"budgetCompanyType\" : \"budgetCompanyType\",\r\n    \"status\" : \"Active\"\r\n  },\r\n  \"sumWithVat\" : 3.616076749251911,\r\n  \"paymentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirHistory\" : {\r\n    \"settlements\" : [ {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 5.299143560275359,\r\n      \"comment\" : \"comment\",\r\n      \"settlementDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"cancellation\" : {\r\n      \"reason\" : \"reason\",\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"cancelledBy\" : 0\r\n    },\r\n    \"assignment\" : {\r\n      \"assignmentDebtorName\" : \"assignmentDebtorName\",\r\n      \"assignmentContractNr\" : \"assignmentContractNr\",\r\n      \"originalIdfNr\" : \"originalIdfNr\",\r\n      \"assignmentDebtorCompanyNr\" : \"assignmentDebtorCompanyNr\",\r\n      \"assignmentIdfNr\" : \"assignmentIdfNr\"\r\n    },\r\n    \"comment\" : \"comment\",\r\n    \"amountChanges\" : [ {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"amount\" : 3.502657762086401,\r\n      \"cancelDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"changedId\" : 9,\r\n      \"comments\" : \"comments\",\r\n      \"cancelComments\" : \"cancelComments\",\r\n      \"id\" : 8,\r\n      \"creationDate\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"totalToPay\" : 9.254183946267839,\r\n  \"isPrepaymentInvoice\" : true,\r\n  \"receiver\" : \"receiver\",\r\n  \"contract\" : {\r\n    \"channelAddress\" : \"channelAddress\",\r\n    \"addresses\" : [ {\r\n      \"city\" : \"city\",\r\n      \"streetAndHouse\" : \"streetAndHouse\",\r\n      \"postalIndex\" : \"postalIndex\",\r\n      \"countryId\" : 9,\r\n      \"addressId\" : 5\r\n    }, {\r\n      \"city\" : \"city\",\r\n      \"streetAndHouse\" : \"streetAndHouse\",\r\n      \"postalIndex\" : \"postalIndex\",\r\n      \"countryId\" : 9,\r\n      \"addressId\" : 5\r\n    } ],\r\n    \"customFields\" : [ {\r\n      \"name\" : \"name\",\r\n      \"id\" : 9,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"name\" : \"name\",\r\n      \"id\" : 9,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"channel\" : 9,\r\n    \"invoiceCurrency\" : \"invoiceCurrency\",\r\n    \"isReceiverCompanyDeleted\" : true,\r\n    \"isDeleted\" : true,\r\n    \"ownerCompanyId\" : 8,\r\n    \"invoiceNotificationEmail\" : \"invoiceNotificationEmail\",\r\n    \"sendInvoiceToCir\" : true,\r\n    \"fineRatePerDay\" : 4964.721971135656,\r\n    \"serviceId\" : \"serviceId\",\r\n    \"paymentTerms\" : 1172,\r\n    \"contactPersonMail\" : \"\",\r\n    \"contractDesc\" : \"contractDesc\",\r\n    \"referenceNr\" : \"referenceNr\",\r\n    \"contractNumber\" : 6,\r\n    \"contractApplication\" : {\r\n      \"channelAddress\" : \"channelAddress\",\r\n      \"addresses\" : [ null, null ],\r\n      \"contractDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"contractApplicationId\" : 3,\r\n      \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n      \"companyName\" : \"companyName\",\r\n      \"referenceNr\" : \"referenceNr\",\r\n      \"channel\" : 6,\r\n      \"contactPersonName\" : \"contactPersonName\",\r\n      \"companyEmail\" : \"companyEmail\",\r\n      \"companyPhone\" : \"companyPhone\",\r\n      \"serviceProvider\" : \"serviceProvider\",\r\n      \"registrationCode\" : \"registrationCode\",\r\n      \"invoiceNotificationEmail\" : \"invoiceNotificationEmail\",\r\n      \"serviceId\" : \"serviceId\",\r\n      \"fineRatePerDay\" : 2.8841621266687802,\r\n      \"paymentTerms\" : 1,\r\n      \"contactPersonEmail\" : \"contactPersonEmail\",\r\n      \"receiverCompanyId\" : 6,\r\n      \"companyLabel\" : \"companyLabel\"\r\n    },\r\n    \"contactPersonName\" : \"contactPersonName\",\r\n    \"channels\" : [ 6, 6 ],\r\n    \"contractId\" : 6,\r\n    \"serviceProvider\" : \"serviceProvider\",\r\n    \"isBudgetClient\" : true,\r\n    \"availableContracts\" : [ \"availableContracts\", \"availableContracts\" ],\r\n    \"customerSupplierId\" : 7\r\n  },\r\n  \"version\" : 2,\r\n  \"cirSettledAmount\" : 1.8268702177058116,\r\n  \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n  \"sourceInvoiceSelectionMode\" : \"InvoiceSelection\",\r\n  \"sender\" : \"sender\",\r\n  \"serviceProvider\" : \"serviceProvider\",\r\n  \"fiscalBillNumbersRepresentation\" : [ {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  }, {\r\n    \"transactionType\" : \"Sale\",\r\n    \"fiscalBillNumber\" : \"fiscalBillNumber\",\r\n    \"sufTaxCode\" : \"sufTaxCode\"\r\n  } ],\r\n  \"publicPurchaseContractSigner\" : {\r\n    \"lastName\" : \"lastName\",\r\n    \"personalId\" : \"personalId\",\r\n    \"specialTreatment\" : true,\r\n    \"vatRegistrationCode\" : \"vatRegistrationCode\",\r\n    \"companyName\" : \"companyName\",\r\n    \"language\" : \"cs_CZ\",\r\n    \"isCompany\" : true,\r\n    \"countryId\" : 1,\r\n    \"firstName\" : \"firstName\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"ownerCompanyId\" : 1,\r\n    \"registrationCode\" : \"registrationCode\",\r\n    \"companyMail\" : \"\",\r\n    \"serbiaCompanyType\" : \"Company\",\r\n    \"customerSupplierId\" : 7,\r\n    \"email\" : \"email\",\r\n    \"additionalCode\" : \"additionalCode\"\r\n  },\r\n  \"invoiceTotalPaymentsCalculation\" : {\r\n    \"paymentFeeForVatCategories\" : [ null, null ],\r\n    \"totalPayments\" : 2.380090174313445\r\n  },\r\n  \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"status\" : \"New\",\r\n  \"note\" : \"note\",\r\n  \"roundingAmount\" : 7.203794749804894,\r\n  \"accountingDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"attachments\" : [ {\r\n    \"isLink\" : true,\r\n    \"fileName\" : \"fileName\",\r\n    \"fileSize\" : 9,\r\n    \"fileData\" : \"\",\r\n    \"isUbl\" : true,\r\n    \"link\" : \"link\",\r\n    \"invoiceId\" : 9,\r\n    \"id\" : 0,\r\n    \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"isLink\" : true,\r\n    \"fileName\" : \"fileName\",\r\n    \"fileSize\" : 9,\r\n    \"fileData\" : \"\",\r\n    \"isUbl\" : true,\r\n    \"link\" : \"link\",\r\n    \"invoiceId\" : 9,\r\n    \"id\" : 0,\r\n    \"createdUtc\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"indebtednessPeriodFromDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirInvoiceId\" : \"cirInvoiceId\",\r\n  \"indebtednessPeriodToDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"description\" : \"description\",\r\n  \"vatPointDate\" : 3,\r\n  \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"discountPercentage\" : 5.962133916683182,\r\n  \"acceptRejectMessage\" : \"acceptRejectMessage\",\r\n  \"senderId\" : 6,\r\n  \"isDebitNote\" : true,\r\n  \"selectedPrepaymentInvoices\" : [ {\r\n    \"contractId\" : 4,\r\n    \"individualPrepaymentCalculations\" : [ {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    }, {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    } ],\r\n    \"selectedPrepaymentInvoiceId\" : 5,\r\n    \"prepaymentInvoiceId\" : 4,\r\n    \"prepayedAmount\" : 6.073898085781152,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n    \"prepayedVAT\" : 8.251625748923757\r\n  }, {\r\n    \"contractId\" : 4,\r\n    \"individualPrepaymentCalculations\" : [ {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    }, {\r\n      \"totalPrepaymentInvoice\" : 2.9409642974827896,\r\n      \"individualPrepaymentPrepaymentVatPerRateParameters\" : [ {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      }, {\r\n        \"prepaidVatPerRate\" : 8.863729185622827,\r\n        \"prepaymentCalculationVatPerRateParametersId\" : 8,\r\n        \"prepaymentVatBaseReduction\" : 4.573936264232251,\r\n        \"vatRate\" : 6.623518433804886\r\n      } ],\r\n      \"currency\" : \"currency\",\r\n      \"individualPrepaymentFeeReductionForExemptionReasons\" : [ {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      }, {\r\n        \"feeReduction\" : 1.7325933120207193,\r\n        \"vatCategory\" : \"vatCategory\"\r\n      } ],\r\n      \"prepaymentPaidVat\" : 0.43431398824148815,\r\n      \"totalPrepaymentWithoutVat\" : 3.901545264248647\r\n    } ],\r\n    \"selectedPrepaymentInvoiceId\" : 5,\r\n    \"prepaymentInvoiceId\" : 4,\r\n    \"prepayedAmount\" : 6.073898085781152,\r\n    \"currency\" : \"currency\",\r\n    \"invoiceSentDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"paymentDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"prepaymentInvoiceNumber\" : \"prepaymentInvoiceNumber\",\r\n    \"prepayedVAT\" : 8.251625748923757\r\n  } ],\r\n  \"invoiceDateUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"cirStatus\" : \"None\",\r\n  \"invoiceNumber\" : \"invoiceNumber\",\r\n  \"currency\" : \"currency\",\r\n  \"sendInvoiceToCir\" : true,\r\n  \"serviceId\" : \"serviceId\",\r\n  \"fineRatePerDay\" : 1.4658129805029452,\r\n  \"isProFormaInvoice\" : true,\r\n  \"createdFromXml\" : true,\r\n  \"cirAmountChangeId\" : \"cirAmountChangeId\",\r\n  \"vatNumberFactoringCompany\" : \"vatNumberFactoringCompany\",\r\n  \"lotNumber\" : \"lotNumber\",\r\n  \"rows\" : [ {\r\n    \"unitPrice\" : 7.740351818741173,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"orderNo\" : 8,\r\n    \"code\" : \"code\",\r\n    \"quantity\" : 3.0205796992916243,\r\n    \"vatRate\" : 32.58856561904761,\r\n    \"description\" : \"description\",\r\n    \"discountAmount\" : 7.04836565559697,\r\n    \"vatSum\" : 4.078845849666752,\r\n    \"rowId\" : 0,\r\n    \"discountPercentage\" : 30.576100241049343,\r\n    \"unit\" : \"unit\",\r\n    \"classificationCode\" : \"classificationCode\",\r\n    \"sumWithoutVat\" : 5.533258397034986,\r\n    \"invoiceId\" : 4,\r\n    \"sumWithVat\" : 0.2025324113236393,\r\n    \"allowances\" : [ {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    }, {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    } ]\r\n  }, {\r\n    \"unitPrice\" : 7.740351818741173,\r\n    \"vatCategoryCode\" : \"vatCategoryCode\",\r\n    \"orderNo\" : 8,\r\n    \"code\" : \"code\",\r\n    \"quantity\" : 3.0205796992916243,\r\n    \"vatRate\" : 32.58856561904761,\r\n    \"description\" : \"description\",\r\n    \"discountAmount\" : 7.04836565559697,\r\n    \"vatSum\" : 4.078845849666752,\r\n    \"rowId\" : 0,\r\n    \"discountPercentage\" : 30.576100241049343,\r\n    \"unit\" : \"unit\",\r\n    \"classificationCode\" : \"classificationCode\",\r\n    \"sumWithoutVat\" : 5.533258397034986,\r\n    \"invoiceId\" : 4,\r\n    \"sumWithVat\" : 0.2025324113236393,\r\n    \"allowances\" : [ {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    }, {\r\n      \"reason\" : \"reason\",\r\n      \"amount\" : 7.260521264802104,\r\n      \"salesLineItemId\" : 4,\r\n      \"salesLineItemAllowanceId\" : 6,\r\n      \"percentage\" : 4.678947989005849,\r\n      \"reasonCode\" : \"reasonCode\",\r\n      \"baseAmount\" : 1.041444916118296\r\n    } ]\r\n  } ],\r\n  \"globUniqId\" : \"globUniqId\",\r\n  \"lastModifiedUtc\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"factoringContractNumber\" : \"factoringContractNumber\",\r\n  \"isCreditInvoice\" : true,\r\n  \"totalRowsCount\" : 7,\r\n  \"debitNotes\" : [ null, null ],\r\n  \"sumWithoutVat\" : 2.3021358869347655,\r\n  \"fiscalBillNumbers\" : [ \"fiscalBillNumbers\", \"fiscalBillNumbers\" ],\r\n  \"invoiceId\" : 0,\r\n  \"modelNumber\" : \"modelNumber\",\r\n  \"invoiceMessage\" : \"invoiceMessage\",\r\n  \"stornoNumber\" : \"stornoNumber\",\r\n  \"cancelInvoiceMessage\" : \"cancelInvoiceMessage\",\r\n  \"cirAssignationHistory\" : {\r\n    \"invoiceChanges\" : [ {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    }, {\r\n      \"dateChanged\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"newValue\" : \"newValue\",\r\n      \"propertyName\" : \"propertyName\",\r\n      \"serviceDesk\" : true,\r\n      \"id\" : 8,\r\n      \"oldValue\" : \"oldValue\",\r\n      \"ispName\" : \"ispName\",\r\n      \"user\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\"\r\n      },\r\n      \"version\" : 7\r\n    } ],\r\n    \"invoiceId\" : 5\r\n  }\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InvoiceDto>(exampleJson)
            : default(InvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Import sales ubl
        /// </summary>
        /// <param name="body"></param>
        /// <param name="apiKey"></param>
        /// <param name="requestId"></param>
        /// <param name="sendToCir"></param>
        /// <param name="executeValidation"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceUblPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(MiniInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceUblPost([FromBody] string body, [FromHeader] string apiKey, [FromQuery] string requestId, [FromQuery] SendToCir sendToCir, [FromQuery] bool? executeValidation)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MiniInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"salesInvoiceId\" : 1,\r\n  \"invoiceId\" : 0,\r\n  \"purchaseInvoiceId\" : 6\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<MiniInvoiceDto>(exampleJson)
            : default(MiniInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        [HttpPost]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl/upload")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceUblUploadPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(MiniInvoiceDto), description: "Success")]
        public virtual IActionResult ApiPublicApiSalesInvoiceUblUploadPost([FromForm] IFormFile file, [FromHeader] string apiKey, [FromQuery] string requestId, [FromQuery] SendToCir sendToCir, [FromQuery] bool? executeValidation)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MiniInvoiceDto));
            string exampleJson = null;
            exampleJson = "{\r\n  \"salesInvoiceId\" : 1,\r\n  \"invoiceId\" : 0,\r\n  \"purchaseInvoiceId\" : 6\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<MiniInvoiceDto>(exampleJson)
            : default(MiniInvoiceDto);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Download sales invoice ubl as FileStream
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="invoiceId"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/xml")]
        [ValidateModelState]
        [SwaggerOperation("ApiPublicApiSalesInvoiceXmlGet")]
        public virtual IActionResult ApiPublicApiSalesInvoiceXmlGet([FromHeader] string apiKey, [FromQuery] long? invoiceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

    }
}
