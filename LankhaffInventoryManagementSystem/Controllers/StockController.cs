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

        public StockController(IStockInterface accesslayer)
        {
            this._objStock = accesslayer;
        }
       public IActionResult RegisterStocks (RegisterStocks stock)
       {
            if (ModelState.IsValid)
            {
                this._objStock.AddStock(stock);
            }
            return View();
       }
    }
}