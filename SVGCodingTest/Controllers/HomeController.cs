using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SVGCodingTest.Models;

namespace SVGCodingTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var listOfVehicles = new List<Vehicle>()
            {
                new Vehicle() { VehicleType = "Bicycle", Sales2018 = 200, Sales2019 = 220 },
                new Vehicle() { VehicleType = "Car", Sales2018 = 100, Sales2019 = 94 },
                new Vehicle() { VehicleType = "Truck", Sales2018 = 150, Sales2019 = 168 },
                new Vehicle() { VehicleType = "Motorcycle", Sales2018 = 40, Sales2019 = 55 },
                new Vehicle() { VehicleType = "Jet", Sales2018 = 11, Sales2019 = 14 }
            };
            
            return View(listOfVehicles);
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
