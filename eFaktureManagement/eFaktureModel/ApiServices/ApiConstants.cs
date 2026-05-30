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
            { EApiPaths.ACCEPT_REJECT, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/acceptRejectPurchaseInvoice" },
            { EApiPaths.IDS, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/ids" },
            { EApiPaths.XML_DOWNLOAD, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/xml" },
            { EApiPaths.SIGNATURE_DOWNLOAD, "/swagger/public_v1/swagger.json/api/publicApi/purchase-invoice/signature" },

        };
    }
    public static class PublicPurchaseContractorApiPaths
    {
        public static readonly Dictionary<EApiPaths, string> Paths = new()
        {
            { EApiPaths.API_ROOT, "API_ROOT" },
            { EApiPaths.CHANGES, "/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/changes" },
            { EApiPaths.SINGLE, "/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice" },
            { EApiPaths.IDS, "/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/ids" },
            { EApiPaths.XML_DOWNLOAD, "/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/xml" },
            { EApiPaths.SIGNATURE_DOWNLOAD, "/swagger/public_v1/swagger.json/api/publicApi/public-purchase-contractor-invoice/signature" },

        };
    }
    public static class SalesApiPaths
    {
        public static readonly Dictionary<EApiPaths, string> Paths = new()
        {
            { EApiPaths.API_ROOT, "API_ROOT" },
            { EApiPaths.CHANGES, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/changes" },
            { EApiPaths.SINGLE, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice" },
            { EApiPaths.UBL_DOWNLOAD, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl" },
            { EApiPaths.VAT_EXEMPTIONS, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/vatExemptions" },
            { EApiPaths.UBL_UPLOAD, "/swagger/public_v1/swagger.json/api/publicApi/sales-invoice/ubl/upload" }
        };
    }

}
