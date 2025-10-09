using System.ComponentModel.DataAnnotations;

namespace eFaktureManagement.Dto.Identity
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
