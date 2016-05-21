using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Pouarf.Models
{
    public class Address : BaseModel
    {
        [Required]
        public string Label { get; set; }

        // ie: 34 Main Street (naming is hard....)
        [Required]
        public string StreetAdr { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
