using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LankhaffInventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LankhaffInventoryManagementSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerInterface objCustomer;

        public CustomerController(ICustomerInterface accesslayer)
        {
            this.objCustomer = accesslayer;
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
            return View("DisplayAllCustomers", customerList);
        }
    }
}