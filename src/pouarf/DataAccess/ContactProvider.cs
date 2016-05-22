using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pouarf.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pouarf.DataAccess
{

    public class ContactProvider : IContactProvider
    {
        private PouarfDbContext _dbContext;

        public ContactProvider(PouarfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddEmailAddress(EmailAddress emailAddress)
        {
            await Task.Run(() => _dbContext.EmailAddresses.Add(emailAddress));
        }

        public async Task AddPerson(Person person)
        {
            await Task.Run(() => _dbContext.People.Add(person));
        }

        public async Task AddPhoneNumber(PhoneNumber phoneNumber)
        {
            await Task.Run(() => _dbContext.PhoneNumbers.Add(phoneNumber));
        }

        public async Task AddStreetAddress(StreetAddress streetAddress)
        {
            await Task.Run(() => _dbContext.StreetAddresses.Add(streetAddress));
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EmailAddress> GetEmailAddress(Guid id)
        {
            return await _dbContext.EmailAddresses.FirstOrDefaultAsync(i => i.Id.Equals(id));
        }

        public async Task<IEnumerable<EmailAddress>> GetEmailAddresses()
        {
            return await _dbContext.EmailAddresses.ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetPeople(bool includeRelationships = false)
        {
            var people = _dbContext.People;

            if (includeRelationships)
            {
                people.Include(p => p.PhoneNumbers)
                    .Include(p => p.EmailAddresses)
                    .Include(p => p.StreetAddresses);
            }

            return await people.ToListAsync();
        }

        public async Task<Person> GetPerson(Guid id, bool includeRelationships = false)
        {
            var people = _dbContext.People;

            if (includeRelationships)
            {
                people.Include(p => p.PhoneNumbers)
                    .Include(p => p.EmailAddresses)
                    .Include(p => p.StreetAddresses);
            }

            return await people.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<PhoneNumber> GetPhoneNumber(Guid id)
        {
            return await _dbContext.PhoneNumbers.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<PhoneNumber>> GetPhoneNumbers()
        {
            return await _dbContext.PhoneNumbers.ToListAsync();
        }

        public async Task<StreetAddress> GetStreetAddress(Guid id)
        {
            return await _dbContext.StreetAddresses.FirstOrDefaultAsync(s => s.Id.Equals(id));
        }

        public async Task<IEnumerable<StreetAddress>> GetStreetAddresses()
        {
            return await _dbContext.StreetAddresses.ToListAsync();
        }
    }
}
