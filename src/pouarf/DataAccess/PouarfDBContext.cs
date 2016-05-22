using Microsoft.EntityFrameworkCore;
using Pouarf.Models;

namespace Pouarf.DataAccess
{
    public class PouarfDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<StreetAddress> StreetAddresses { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }       

        public PouarfDBContext(DbContextOptions<PouarfDBContext> options)
            : base(options)
        {
        }


     

    }

   

}
