﻿using Pouarf.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pouarf.DataAccess
{
    public interface IContactProvider
    {
        Task<IEnumerable<Person>> GetPeople(bool includeRelationships = false);
        Task<Person> GetPerson(Guid id, bool includeRelationships = false);
        Task AddPerson(Person person);
        Task<Person> DeletePerson(Guid id);

        Task<IEnumerable<EmailAddress>> GetEmailAddresses();
        Task<EmailAddress> GetEmailAddress(Guid id);
        Task AddEmailAddress(EmailAddress emailAddress);
        Task<EmailAddress> DeleteEmailAddress(Guid id);

        Task<IEnumerable<PhoneNumber>> GetPhoneNumbers();
        Task<PhoneNumber> GetPhoneNumber(Guid id);
        Task AddPhoneNumber(PhoneNumber phoneNumber);
        Task<PhoneNumber> DeletePhoneNumber(Guid id);

        Task<IEnumerable<StreetAddress>> GetStreetAddresses();
        Task<StreetAddress> GetStreetAddress(Guid id);
        Task AddStreetAddress(StreetAddress streetAddress);
        Task<StreetAddress> DeleteStreetAddress(Guid id);

        Task Commit();
    }
}
