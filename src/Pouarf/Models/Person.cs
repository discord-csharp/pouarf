using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pouarf.Models
{
    public class Person : ContactInformationBase
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        public virtual ICollection<StreetAddress> StreetAddresses { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
