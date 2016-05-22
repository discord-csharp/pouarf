using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pouarf.DataAccess;
using Pouarf.Models;

namespace Pouarf.Helpers
{
    public class MockPeople
    {
        private readonly IContactProvider _contactProvider;

        public MockPeople(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
        }

        public async Task CreateSampleData()
        {
            await Task.Run(async () =>
            {
                var people = new List<Person>()
                {
                    new Person()
                    {
                        FirstName = "Delilah", LastName = "Ezekiel", BirthDate = DateTimeOffset.Now, CreatedAt = DateTimeOffset.Now, StreetAddresses = new List<StreetAddress>()
                        {
                            new StreetAddress() { Label="Home", Street = "654 Main Street", City = "Montreal", Country = "Canada"},
                            new StreetAddress() { Label="Work", Street = "725 Main Street", City = "Colorado", Country = "USA"}
                        },
                        EmailAddresses = new List<EmailAddress>()
                        {
                            new EmailAddress() { Label = "Home", Email = "me@hotmail.com"},
                            new EmailAddress() { Label = "Work", Email = "you@hotmail.com"}
                        },
                        PhoneNumbers = new List<PhoneNumber>()
                        {
                            new PhoneNumber() { Label = "Home", Phone = "153-321-1234"},
                            new PhoneNumber() { Label = "Work", Phone = "542-543-9848"}
                        }
                    },
                    new Person()
                    {
                        FirstName = "Aileen", LastName = "Shana", BirthDate = DateTimeOffset.Now, CreatedAt = DateTimeOffset.Now, StreetAddresses = new List<StreetAddress>()
                        {
                            new StreetAddress() { Label="Home", Street = "987 Dumb Street", City = "Vancouver", Country = "Canada"},
                            new StreetAddress() { Label="Work", Street = "123 Test Street", City = "Austin", Country = "USA"}
                        },
                        EmailAddresses = new List<EmailAddress>()
                        {
                            new EmailAddress() { Label = "Home", Email = "me@hotmail.com"},
                            new EmailAddress() { Label = "Work", Email = "you@hotmail.com"}
                        },
                        PhoneNumbers = new List<PhoneNumber>()
                        {
                            new PhoneNumber() { Label = "Home", Phone = "584-321-8945"},
                            new PhoneNumber() { Label = "Work", Phone = "685-543-9848"}
                        }
                    },
                    new Person()
                    {
                        FirstName = "James", LastName = "Nadine", BirthDate = DateTimeOffset.Now, CreatedAt = DateTimeOffset.Now, StreetAddresses = new List<StreetAddress>()
                        {
                            new StreetAddress() { Label="Home", Street = "123 Main Street", City = "Montreal", Country = "Canada"},
                            new StreetAddress() { Label="Work", Street = "123 Main Street", City = "Montreal", Country = "Canada"}
                        },
                        EmailAddresses = new List<EmailAddress>()
                        {
                            new EmailAddress() { Label = "Home", Email = "me@hotmail.com"},
                            new EmailAddress() { Label = "Work", Email = "you@hotmail.com"}
                        },
                        PhoneNumbers = new List<PhoneNumber>()
                        {
                            new PhoneNumber() { Label = "Home", Phone = "542-321-1234"},
                            new PhoneNumber() { Label = "Work", Phone = "542-543-9848"}
                        }
                    },
                };

                foreach (var person in people)
                {
                    await _contactProvider.AddPerson(person);
                }

                await _contactProvider.Commit();
            });
        }
    }
}

