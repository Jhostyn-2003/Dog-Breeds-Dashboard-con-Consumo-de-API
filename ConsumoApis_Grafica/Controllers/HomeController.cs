using ConsumoApis_Grafica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsumoApis_Grafica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DogBreedsChart()
        {
            var breeds = await GetDogBreedsAsync();
            return View(breeds);
        }

        private async Task<Dictionary<string, List<string>>?> GetDogBreedsAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://dog.ceo/api/breeds/list/all");
                var breeds = JObject.Parse(response)["message"]?.ToObject<Dictionary<string, List<string>>>();
                return breeds;
            }
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
