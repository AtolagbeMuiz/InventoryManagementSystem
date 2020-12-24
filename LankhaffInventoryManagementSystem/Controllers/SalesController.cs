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

        //Initializes the interfaces by creating instances
        public SalesController(ICustomerInterface accesslayer, IStockInterface stock)
        {
            this._objCustomer = accesslayer;
            this._objStock = stock;
        }


        //displays the Invoice, a view model called SalesSheetViewModel is used to pass multiple models into the SalesSheet view
        [HttpGet]
        public IActionResult SalesSheet(int id, RegisterCustomer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();

            }
            else
            {
                //ViewBag.StateEnabled = false;
                SalesSheetViewModel viewModel = new SalesSheetViewModel();
                viewModel.Customers = this._objCustomer.GetACustomer(id).ToList();
                viewModel.Stocks = this._objStock.GetStocks();
                return View(viewModel);
            }
           
        }

        //gets each price of the selected stock based on the LINQ Query result
        [HttpPost]
        public IActionResult getstockPrice(string data)
        {
            SalesSheetViewModel viewModel = new SalesSheetViewModel();
            var resultPrice = this._objStock.getstockRate(data).ToString();
            

            //ViewBag.StateEnabled = true;
            //ViewBag.StockPrice = resultPrice;
            viewModel.sp = resultPrice;

            return View("SalesSheet");
            //return RedirectToAction("SalesSheet");
            //return resultPrice;
            //return viewModel.sp;

        }
    }
}