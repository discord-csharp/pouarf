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

        public async Task DeleteEmailAddress(Guid id)
        {
            var emailAddress = await GetEmailAddress(id);
            await Task.Run(() => _dbContext.EmailAddresses.Remove(emailAddress));
        }

        public async Task DeletePerson(Guid id)
        {
            var person = await GetPerson(id);

            foreach (var phoneNumber in person.PhoneNumbers)
            {
                var phone = await GetPhoneNumber(phoneNumber.Id);
                await Task.Run(() => _dbContext.PhoneNumbers.Remove(phone));
            }

            foreach (var emailAdress in person.EmailAddresses)
            {
                var email = await GetEmailAddress(emailAdress.Id);
                await Task.Run(() => _dbContext.EmailAddresses.Remove(email));
            }

            foreach (var streetAddress in person.StreetAddresses)
            {
                var street = await GetStreetAddress(streetAddress.Id);
                await Task.Run(() => _dbContext.StreetAddresses.Remove(street));
            }

            await Task.Run(() => _dbContext.People.Remove(person));
        }

        public async Task DeletePhoneNumber(Guid id)
        {
            var phoneNumber = await GetPhoneNumber(id);
            await Task.Run(() => _dbContext.PhoneNumbers.Remove(phoneNumber));
        }

        public async Task DeleteStreetAddress(Guid id)
        {
            var streetAddress = await GetStreetAddress(id);
            await Task.Run(() => _dbContext.StreetAddresses.Remove(streetAddress));
        }

        public async Task<EmailAddress> GetEmailAddress(Guid id)
        {
            return await _dbContext.EmailAddresses.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<EmailAddress>> GetEmailAddresses()
        {
            return await _dbContext.EmailAddresses.ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetPeople(bool includeRelationships = false)
        {
            IQueryable<Person> people = _dbContext.People;
            if (includeRelationships)
            {
                people = people
                    .Include(p => p.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Include(p => p.StreetAddresses);
            }

            return await people.ToListAsync();
        }

        public async Task<Person> GetPerson(Guid id, bool includeRelationships = false)
        {
            IQueryable<Person> people = _dbContext.People;
            if (includeRelationships)
            {
                people = people
                    .Include(p => p.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
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
