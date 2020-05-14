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
        private readonly ICustomerInteface objCustomer;

        public HomeController(ICustomerInteface accesslayer)
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
            this.objCustomer.getAllCustomers();
            return View();
        }
    }
}
