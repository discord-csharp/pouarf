using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Models
{
    public class Phone : BaseModel
    {
        [Required]
        public string Label { get; set; }


        // Better naming, again?
        [Required]
        public string PhoneNbr { get; set; }
    }
}
