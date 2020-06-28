using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LankhaffInventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LankhaffInventoryManagementSystem.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockInterface _objStock;

        //Initilizes the IStockInterface by creating an instance
        public StockController(IStockInterface accesslayer)
        {
            this._objStock = accesslayer;
        }

        //Returns the RegisterStock view 
        [HttpGet]
        public IActionResult RegisterStocks()
        {
            return View();
        }

        //Accesses the StockRepo to add the stock to the DB
        [HttpPost]
        public IActionResult RegisterStocks (RegisterStocks stock)
        {
            if (ModelState.IsValid)
            {
                var mess = this._objStock.AddStock(stock).ToString();
                ViewBag.Message = mess;
            }
            return View();
        }
    }
}