using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LankhaffInventoryManagementSystem.Models;

namespace LankhaffInventoryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerInterface objCustomer;

        public HomeController(ICustomerInterface accesslayer)
        {
            this.objCustomer = accesslayer;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCustomer(RegisterCustomer customer)
        {
            if (ModelState.IsValid)
            {
                objCustomer.AddCustomer(customer);
            }
            return View();
        }

        public IActionResult GetAllCustomers()
        {
            List<RegisterCustomer> customerList = new List<RegisterCustomer>();
            customerList = this.objCustomer.GetAllCustomers().ToList();
            return View(customerList);
        }
    }
}
