using System;
using Microsoft.AspNetCore.Mvc;
using Pouarf.DataAccess;
using Pouarf.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Server.Kestrel.Networking;

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

            return View(new { people, peopleTwo, emails, phoneNumbers, streetAddresses });
        }

        [Route("api/[action]")]
        public async Task<IEnumerable<Person>> People()
        {
            return await _contactProvider.GetPeople(true);
        }

        [Route("api/[action]")]
        [HttpPost]
        public async Task<IActionResult> People([FromBody] Person person)
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

    }
}
