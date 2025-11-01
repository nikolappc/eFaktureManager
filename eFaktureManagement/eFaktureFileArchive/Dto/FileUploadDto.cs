namespace eFaktureFileArchive.Dto
{
    public class FileUploadDto
    {
        public long InvoiceId { get; set; }
        public byte[] FileContent { get; set; }
    }


}
