using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureSync.ApiServices
{
    public static class PurchaseApiPaths
    {
        public static readonly Dictionary<EApiPaths, string> Paths = new()
        {
            { EApiPaths.API_ROOT, "API_ROOT" },
            { EApiPaths.CHANGES, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/changes" },
            { EApiPaths.SINGLE, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice" },
            { EApiPaths.PURCHASE_ACCEPT_REJECT, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/acceptRejectPurchaseInvoice" },
        };
    }

    public static class SalesApiPaths
    {
        public static readonly Dictionary<EApiPaths, string> Paths = new()
        {
            { EApiPaths.API_ROOT, "API_ROOT" },
            { EApiPaths.CHANGES, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/changes" },
            { EApiPaths.SINGLE, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice" },
            { EApiPaths.UBL, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl" },
            { EApiPaths.VAT_EXEMPTIONS, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/vatExemptions" },
            { EApiPaths.UBL_UPLOAD, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl/upload" }
        };
    }

}
