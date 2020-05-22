using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LankhaffInventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LankhaffInventoryManagementSystem.Controllers
{
    public class SalesController : Controller
    {
        private readonly ICustomerInterface _objCustomer;
        public SalesController(ICustomerInterface accesslayer)
        {
            this._objCustomer = accesslayer;
        }


        [HttpGet]
        public IActionResult SalesSheet(int id, RegisterCustomer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }
            else
            {
                List<RegisterCustomer> customers = new List<RegisterCustomer>();
                customers = this._objCustomer.GetACustomer(id).ToList();
               return View(customers);
            }
           
        }

        //[HttpPost]
        //public IActionResult SalesSheet()
        //{
        //    ;
        //}

    }
}