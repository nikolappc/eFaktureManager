using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Reference
{
    public class UserInvoice
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public InvoiceWorkStatus InvoiceWorkStatus { get; set; }

        public IdentityUser  user { get; set; }

    }
}
