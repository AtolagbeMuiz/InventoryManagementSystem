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
        
        //Initializes the iCustomrInterface by creating an instance
        public CustomerController(ICustomerInterface accesslayer)
        {
            this.objCustomer = accesslayer;
        }

        //Renders the RegisterCustomer View to register the Customer
        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        //Validates and Accesses the CustomerRepo to Add the customer to the DB
        [HttpPost]
        public IActionResult RegisterCustomer(RegisterCustomer customer)
        {
            if (ModelState.IsValid)
            {
                objCustomer.AddCustomer(customer);
            }
            return View();
        }

        //Accesses the CustomerRepo to return the list of customers from the DB
        public IActionResult GetAllCustomers()
        {
            List<RegisterCustomer> customerList = new List<RegisterCustomer>();
            customerList = this.objCustomer.GetAllCustomers().ToList();
            return View("DisplayAllCustomers", customerList);
        }
    }
}