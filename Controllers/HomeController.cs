using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OlympicGames.Models;
using OlympicGames.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace OlympicGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string selectedGame = "All", string selectedType = "All")
        {
            var countries = CountryData.Countries.AsQueryable();

            if (!string.IsNullOrEmpty(selectedGame) && selectedGame != "All")
            {
                countries = countries.Where(c => c.Game == selectedGame);
            }

            if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
            {
                countries = countries.Where(c => c.Type == selectedType);
            }

            var viewModel = new CountryViewModel
            {
                Countries = countries.ToList(),
                SelectedGame = selectedGame,
                SelectedType = selectedType
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
