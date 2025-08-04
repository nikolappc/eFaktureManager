using System.ComponentModel.DataAnnotations;

namespace eFaktureManagement.Dto.Unassigned
{
    public class UnassignedFilter
    {
        [Required, DataType(DataType.Date)]
        public DateTime StartDate{ get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
