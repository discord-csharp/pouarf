using System.ComponentModel.DataAnnotations;

namespace Pouarf.Models
{
    public class StreetAddress : ContactInformationBase
    {
        [Required]
        public string Label { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
