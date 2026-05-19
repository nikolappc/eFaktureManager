using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Enums.Cir;
using eFaktureModel.Api.Models.Cir;
using eFaktureModel.Api.Models.Purchase;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using PurchaseInvoiceStatus = eFaktureModel.Api.Enums.Purchase.PurchaseInvoiceStatus;

namespace eFaktureApiDemo.Services
{
    public class PurchaseRandomService
    {
        private static readonly Random _random = new Random();

        public List<PurchaseInvoiceStatusChangeDto> GenerateChanges()
        {
            var list = new List<PurchaseInvoiceStatusChangeDto>();

            var count = _random.Next(5, 10);    

            for (int i = 0; i < count; i++)
            {
                var item = new PurchaseInvoiceStatusChangeDto
                {
                    EventId = _random.Next(1000, 9999),
                    Date = DateTime.Now.AddDays(-_random.Next(0, 365)).ToString("yyyy-MM-dd"),
                    NewInvoiceStatus = (PurchaseInvoiceStatus)_random.Next(Enum.GetNames(typeof(PurchaseInvoiceStatus)).Length),
                    PurchaseInvoiceId = _random.NextInt64(100000, 999999),
                    Comment = i%3==0?$"Comment #{i}":"",
                    CirInvoiceId = $"CIR-{_random.Next(10000, 99999)}",
                    SubscriptionKey = Guid.NewGuid().ToString(),
                    StornoNumber = $"ST-{_random.Next(1000, 9999)}",
                    CirAssignmentChange = new CirAssignmentChange
                    {
                    },
                    IsSigned = _random.Next(0, 2) == 1,
                    IsAutoAssigned = _random.Next(0, 2) == 1
                };

                list.Add(item);
            }
            return list;    
        }
    }
}
