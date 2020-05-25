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
        private readonly IStockInterface _objStock;

        public SalesController(ICustomerInterface accesslayer, IStockInterface stock)
        {
            this._objCustomer = accesslayer;
            this._objStock = stock;
        }


        [HttpGet]
        public IActionResult SalesSheet(int id, RegisterCustomer customer,RegisterStocks stock)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }
            else
            {
                SalesSheetViewModel viewModel = new SalesSheetViewModel();
                viewModel.Customers = this._objCustomer.GetACustomer(id).ToList();
                viewModel.Stocks = this._objStock.GetStocks();
                return View(viewModel);
                //List<RegisterCustomer> customers = new List<RegisterCustomer>();
                //customers = this._objCustomer.GetACustomer(id).ToList();
                //return View(customers);
            }
           
        }

        //[HttpPost]
        //public IActionResult SalesSheet()
        //{
        //    ;
        //}

    }
}