using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.ApiServices
{
    public static class ApiConstants
    {
        public static string API_ROOT = "API_ROOT";
        public static string PURCHASE_CHANGES = "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/changes";
        public static string SALES_CHANGES = "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/changes"; 
        public static string PURCHASE_SINGLE = "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice";
       public static string SALES_SINGLE = "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice";  

        public static string PURCHASE_ACCEPT_REJECT = "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/acceptRejectPurchaseInvoice";



    }
}
