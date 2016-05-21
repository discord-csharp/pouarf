using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Models
{
    public class Email : BaseModel
    {

        [Required]
        public string Label { get; set; }

        // Better naming? hummmm
        [Required]
        public string EmailAdr { get; set; }
    }
}
