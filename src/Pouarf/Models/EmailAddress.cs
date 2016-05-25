using System.ComponentModel.DataAnnotations;

namespace Pouarf.Models
{
    public class EmailAddress : ContactInformationBase
    {

        [Required]
        public string Label { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
