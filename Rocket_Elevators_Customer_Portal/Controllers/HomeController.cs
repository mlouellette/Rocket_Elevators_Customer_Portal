using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rocket_Elevators_Customer_Portal.Areas.Identity.Data;
using Rocket_Elevators_Customer_Portal.Models;
using System.Diagnostics;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

        private readonly UserManager<IdentityUser> _userManager;
        Customers? _customer = new Customers();

        Buildings? _building = new Buildings();

        Batteries? _battery = new Batteries();

        Columns? _column = new Columns();

        Elevators? _elevator = new Elevators();

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
		{
			_userManager = userManager;
			_logger = logger;
		}

        [Authorize]
		public async Task<IActionResult> Index()
		{
			var user = User.Identity?.Name;
            HttpClient userCustomer = new HttpClient();

            var customerData = await userCustomer.GetStringAsync("https://localhost:7234/api/customers/" + user);

            _customer = JsonConvert.DeserializeObject<Customers>(customerData);

            ViewBag.Customer = _customer;
            return View();

		}

        [Authorize]
        public IActionResult Intervention()
		{
			return View();
		}


        public async Task<IActionResult> CreateNewForm()
        {
            var user = User.Identity?.Name;
            HttpClient userCustomer = new HttpClient();

            // customer ----- 

            var customerData = await userCustomer.GetStringAsync("https://localhost:7234/api/customers/" + user);

            _customer = JsonConvert.DeserializeObject<Customers>(customerData);

            ViewBag.Customer = _customer;

            // building --------

            HttpClient userBuilding = new HttpClient();

            var buildingsList = await userBuilding.GetStringAsync("https://localhost:7234/api/Buildings/customer/" + user);

            List<Buildings>? userBuildings =  JsonConvert.DeserializeObject<List<Buildings>>(buildingsList);

            ViewBag.Building = userBuildings;

            return View();
        }


        [Authorize]
        public async Task<IActionResult> Product()
        {
            var user = User.Identity?.Name;
            HttpClient userCustomer = new HttpClient();

            // customer ----- 

            var customerData = await userCustomer.GetStringAsync("https://localhost:7234/api/customers/" + user);

            _customer = JsonConvert.DeserializeObject<Customers>(customerData);

            ViewBag.Customer = _customer;

            // building --------

            HttpClient userBuilding = new HttpClient();

            var buildingsList = await userBuilding.GetStringAsync("https://localhost:7234/api/Buildings/customer/" + user);

            List<Buildings>? userBuildings = JsonConvert.DeserializeObject<List<Buildings>>(buildingsList);

            ViewBag.Building = userBuildings;

       

            // Battery --------

            HttpClient userBattery = new HttpClient();

            var batteriesList = await userBuilding.GetStringAsync("https://localhost:7234/api/Batteries/customer/" + user);

            List<Batteries>? userBatteries = JsonConvert.DeserializeObject<List<Batteries>>(batteriesList);

            ViewBag.Battery = userBatteries;

           

            // Column --------

            HttpClient userColumn = new HttpClient();

            var columnsList = await userBuilding.GetStringAsync("https://localhost:7234/api/Columns/customer/" + user);

            List<Columns>? userColumns = JsonConvert.DeserializeObject<List<Columns>>(columnsList);

            ViewBag.Column = userColumns;

           

            // Elevator --------

            HttpClient userElevator = new HttpClient();

            var elevatorsList = await userBuilding.GetStringAsync("https://localhost:7234/api/Elevators/customer/" + user);

            List<Elevators>? userElevators = JsonConvert.DeserializeObject<List<Elevators>>(elevatorsList);

            ViewBag.Elevator = userElevators;

            return View();


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}