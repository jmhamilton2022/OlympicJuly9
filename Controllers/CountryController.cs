using Microsoft.AspNetCore.Mvc;
using OlympicGames.Models;
using System.Linq;

namespace OlympicGames.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            var countries = CountryData.Countries.OrderBy(c => c.Name).ToList();
            return View(countries);
        }

        public IActionResult FilterByGame(string game)
        {
            var countries = CountryData.Countries.Where(c => c.Game == game || game == "ALL").OrderBy(c => c.Name).ToList();
            return View("Index", countries);
        }

        public IActionResult FilterByType(string type)
        {
            var countries = CountryData.Countries.Where(c => c.Type == type || type == "ALL").OrderBy(c => c.Name).ToList();
            return View("Index", countries);
        }

        public IActionResult Details(int id)
        {
            var country = CountryData.Countries.FirstOrDefault(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return View(country);
        }
    }
}
