using Microsoft.AspNetCore.Mvc;
using Pouarf.DataAccess;
using Pouarf.Models;
using System.Collections.Generic;
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

            return View(new { people, peopleTwo, emails, phoneNumbers, streetAddresses });
        }

        [Route("api/[action]")]
        public async Task<IEnumerable<Person>> People()
        {
            return await _contactProvider.GetPeople(true);
        }
    }
}
