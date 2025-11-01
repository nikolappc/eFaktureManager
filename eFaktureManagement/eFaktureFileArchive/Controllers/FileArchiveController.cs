using eFaktureFileArchive.Dto;
using eFaktureFileArchive.Enums;
using Microsoft.AspNetCore.Mvc;

namespace eFaktureFileArchive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileArchiveController : ControllerBase
    {


        private readonly ILogger<FileArchiveController> _logger;

        private readonly IConfiguration _configuration;

        public FileArchiveController(ILogger<FileArchiveController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        private IActionResult UploadFile(FileUploadDto request, string directory, FileType fileType)
        {

            if (request?.FileContent == null || request.FileContent.Length == 0)
            {
                _logger.LogWarning($"Empty '{fileType.ToString()}' file for invoice {request.InvoiceId}");
                return BadRequest("File content is empty.");
            }

            try
            {
                Directory.CreateDirectory(directory);
                var filePath = Path.Combine(directory, $"{request.InvoiceId}.{fileType.ToString().ToLower()}");
                System.IO.File.WriteAllBytes(filePath, request.FileContent);


                _logger.LogInformation($"'{fileType.ToString()}' file uploaded for invoice ID {request.InvoiceId}");
                return Ok($"{fileType.ToString()} file uploaded successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error uploading '{fileType.ToString()}' file for invoice ID {request.InvoiceId}");
                return StatusCode(500, "Internal server error.");
            }
        }


        [HttpPost("upload-xml-purchase")]
        public IActionResult UploadPurchaseInvoiceXml([FromBody] FileUploadDto request)
        {

            return UploadFile(request, _configuration["FileStorage:Purchase:XmlDirectory"], FileType.Xml);

        }

        [HttpPost("upload-pdf-purchase")]
        public IActionResult UploadPurchaseInvoicePdf([FromBody] FileUploadDto request)
        {
            return UploadFile(request, _configuration["FileStorage:Purchase:PdfDirectory"], FileType.Pdf);

        }

        [HttpPost("upload-xml-sales")]
        public IActionResult UploadSalesInvoiceXml([FromBody] FileUploadDto request)
        {
            return UploadFile(request, _configuration["FileStorage:Sales:XmlDirectory"], FileType.Xml);
        }

        [HttpPost("upload-pdf-sales")]
        public IActionResult UploadSalesInvoicePdf([FromBody] FileUploadDto request)
        {
            return UploadFile(request, _configuration["FileStorage:Sales:PdfDirectory"], FileType.Pdf);

        }


        private IActionResult DownloadFile(long invoiceId, string directory, FileType fileType)
        {
            var filePath = Path.Combine(directory, $"{invoiceId}.{fileType.ToString().ToLower()}");

            if (!System.IO.File.Exists(filePath))
            {
                _logger.LogWarning($"{fileType.ToString()} file not found for invoice ID {invoiceId}");
                return NotFound($"{fileType.ToString()} file not found.");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var contentType = fileType == FileType.Xml ? "application/xml" : "application/pdf";
            return File(fileBytes, contentType, $"{invoiceId}.{fileType.ToString().ToLower()}");
        }
        [HttpGet("download-xml-purchase/{invoiceId}")]
        public IActionResult DownloadPurchaseInvoiceXml(long invoiceId)
        {
            return DownloadFile(invoiceId, _configuration["FileStorage:Purchase:XmlDirectory"], FileType.Xml);
        }

        [HttpGet("download-pdf-purchase/{invoiceId}")]
        public IActionResult DownloadPurchaseInvoicePdf(long invoiceId)
        {
            return DownloadFile(invoiceId, _configuration["FileStorage:Purchase:PdfDirectory"], FileType.Pdf);
        }

        [HttpGet("download-xml-sales/{invoiceId}")]
        public IActionResult DownloadSalesInvoiceXml(long invoiceId)
        {
            return DownloadFile(invoiceId, _configuration["FileStorage:Sales:XmlDirectory"], FileType.Xml);
        }

        [HttpGet("download-pdf-sales/{invoiceId}")]
        public IActionResult DownloadSalesInvoicePdf(long invoiceId)
        {
            return DownloadFile(invoiceId, _configuration["FileStorage:Sales:PdfDirectory"], FileType.Pdf);
        }


    }
}
