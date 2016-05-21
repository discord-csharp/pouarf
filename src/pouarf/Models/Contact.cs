using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Models
{
    public class Contact : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        public virtual List<Address> Addresses { get; set; }
        public virtual List<Email> Emails { get; set; }
        public virtual List<Phone> Phones { get; set; }
    }
}
