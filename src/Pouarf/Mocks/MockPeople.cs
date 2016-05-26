using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pouarf.DataAccess;
using Pouarf.Models;
using System.Linq;

namespace Pouarf.Helpers
{
    public class MockPeople
    {
        private readonly IContactProvider _contactProvider;
        private readonly Random _random;

        private T GetRandom<T>(IEnumerable<T> enumerable)
        {
            return enumerable.ElementAt(_random.Next(enumerable.Count()));
        }

        private DateTime GetRandom(DateTime start, DateTime end)
        {
            TimeSpan difference = end - start;
            TimeSpan future = new TimeSpan(0, _random.Next(0, (int)difference.TotalMinutes), 0);
            return start + future;
        }

        private string GetRandomPhoneNumber() => $"({_random.Next(100, 999)}) {_random.Next(100,999)}-{_random.Next(1000,9999)}";

        public MockPeople(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
            _random = new Random();
        }

        IEnumerable<StreetAddress> RandomStreetAddresses()
        {
            while (true)
            {
                string streetName = GetRandom(MockData.Ipsum);
                streetName = Char.ToUpper(streetName[0]) + streetName.Substring(1);

                yield return new StreetAddress
                {
                    Label = GetRandom(MockData.PhysicalLocations),
                    Street = $"{_random.Next(100, 9999)} {GetRandom(MockData.Ipsum)} {GetRandom(MockData.StreetKinds)}.",
                    City = GetRandom(MockData.Cities),
                    Country = GetRandom(MockData.Countries),
                    CreatedAt = GetRandom(MockData.DateBase, DateTime.Now)
                };
            }
        }

        private EmailAddress EmailFromName(string firstname, string lastname)
        {
            return new EmailAddress
            {
                Label = GetRandom(MockData.PhysicalLocations),
                Email = $"{firstname[0]}{lastname}@{GetRandom(MockData.EmailHosts)}.com".ToLowerInvariant(),
                CreatedAt = GetRandom(MockData.DateBase, DateTime.Now)
            };
        }

        IEnumerable<EmailAddress> RandomEmailAddresses(string firstname, string lastname)
        {
            while (true)
            {
                yield return EmailFromName(firstname, lastname);
            }
        }

        IEnumerable<PhoneNumber> RandomPhoneNumbers()
        {
            while (true)
            {
                yield return new PhoneNumber
                {
                    Label = GetRandom(MockData.PhoneLocations),
                    Phone = GetRandomPhoneNumber(),
                    CreatedAt = GetRandom(MockData.DateBase, DateTime.Now)
                };
            }
        }

        IEnumerable<Person> RandomPeople()
        {
            while (true)
            {
                DateTime randomBirthDate = GetRandom(MockData.DateBase, DateTime.Now);
                DateTime randomCreateDate = GetRandom(randomBirthDate, DateTime.Now);
                string firstName = GetRandom(MockData.FirstNames);
                string lastName = GetRandom(MockData.LastNames);

                yield return new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName, LastName = lastName, BirthDate = randomBirthDate, CreatedAt = randomCreateDate,
                    StreetAddresses = RandomStreetAddresses().Take(3).ToList(),
                    EmailAddresses = RandomEmailAddresses(firstName, lastName).Take(3).ToList(),
                    PhoneNumbers = RandomPhoneNumbers().Take(3).ToList()
                };
            }
        }

        public async Task CreateSampleData()
        {
            await Task.Run(async () =>
            {
                var people = RandomPeople().Take(20).ToList(); //Prevent lazy loading

                foreach (var person in people)
                {
                    await _contactProvider.AddPerson(person);
                }

                await _contactProvider.Commit();
            });
        }
    }
}

