using System.ComponentModel.DataAnnotations;

namespace Pouarf.Models
{
    public class PhoneNumber : ContactInformationBase
    {
        [Required]
        public string Label { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
