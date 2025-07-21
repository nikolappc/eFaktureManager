using System.ComponentModel.DataAnnotations;

namespace eFaktureManagement.Dto.Unassigned
{
    public class AssignDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int InvoiceId { get; set; }  
    }
}
