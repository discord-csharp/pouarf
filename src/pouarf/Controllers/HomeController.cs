using Microsoft.AspNetCore.Mvc;
using Pouarf.DataAccess;
using Pouarf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactProvider _contactProvider;

        public HomeController(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
        }

        public async Task<IActionResult> Index()
        {
            var people = await _contactProvider.GetPeople();
            var emails = await _contactProvider.GetEmailAddresses();
            var phoneNumbers = await _contactProvider.GetPhoneNumbers();
            var streetAddresses = await _contactProvider.GetStreetAddresses();
            var peopleTwo = await _contactProvider.GetPeople();
            
            var toBeDelete = people.ElementAt(1);
            await _contactProvider.DeletePerson(toBeDelete.Id);
            await _contactProvider.Commit();

            var newListOfPeople = await _contactProvider.GetPeople();
            var newListOfemails = await _contactProvider.GetEmailAddresses();
            var newListOfphoneNumbers = await _contactProvider.GetPhoneNumbers();
            var newListOFstreetAddresses = await _contactProvider.GetStreetAddresses();

            var toBeUpdate = await _contactProvider.GetPerson(people.ElementAt(2).Id);
            toBeUpdate.LastName = "Updated last name";
            await _contactProvider.UpdatePerson(toBeUpdate);
            await _contactProvider.Commit();
            var updatedPerson = await _contactProvider.GetPerson(toBeUpdate.Id);
                        

            return View(new { people, peopleTwo, emails, phoneNumbers, streetAddresses });
        }

        [Route("api/[action]")]
        [HttpGet]
        public async Task<IEnumerable<Person>> People()
        {
            return await _contactProvider.GetPeople(true);
        }

        [Route("api/[action]")]
        [HttpPost]
        public async Task<IActionResult> Person([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _contactProvider.AddPerson(person);
                await _contactProvider.Commit();
                return Ok(person);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [Route("api/[action]")]
        [HttpDelete]
        public async Task<IActionResult> Person([FromBody] string guid)
        {
            Guid personId = Guid.Empty;
            if(string.IsNullOrWhiteSpace(guid) || !Guid.TryParse(guid, out personId))
            {
                return BadRequest(new { Message = "The guid input is not in a correct format." });
            }

            var person = await _contactProvider.DeletePerson(personId);
            await _contactProvider.Commit();
            return Ok(person);
        }
    }
}
