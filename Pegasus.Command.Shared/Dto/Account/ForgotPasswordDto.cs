using System.ComponentModel.DataAnnotations;

namespace Pegasus.Command.Shared.Dto.Account
{
    public class ForgotPasswordDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
