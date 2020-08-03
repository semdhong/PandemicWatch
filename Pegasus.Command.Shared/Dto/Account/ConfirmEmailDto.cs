using System.ComponentModel.DataAnnotations;

namespace Pegasus.Command.Shared.Dto.Account
{

    public class ConfirmEmailDto
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
