using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model
{
    public class InvoiceAttachment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Invoice")]
        public long InvoiceId { get; set; } 

        public string FileName { get; set; }
    }
}
