using Microsoft.AspNetCore.Mvc;
using Pouarf.DataAccess;
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
            var peopleNoMapping = await _contactProvider.GetPeople();
            var emails = await _contactProvider.GetEmailAddresses();
            var phoneNumbers = await _contactProvider.GetPhoneNumbers();
            var streetAddresses = await _contactProvider.GetStreetAddresses();

            return View(new { peopleNoMapping, emails, phoneNumbers, streetAddresses });
        }
    }
}
