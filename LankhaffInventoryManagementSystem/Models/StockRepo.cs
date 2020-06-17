using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class StockRepo : IStockInterface
    {
        private readonly InventoryDBContext _context;

        //initializes the DBContext by creating an instance of InventoryDBContext 
        public StockRepo(InventoryDBContext context)
        {
            this._context = context;
        }

        //Adds the Stock to the DB
        public RegisterStocks AddStock(RegisterStocks stock)
        {
            if(!(_context.Stocks.Any(x => x.StockName == stock.StockName)))
            {
                _context.Stocks.Add(stock);
                _context.SaveChanges();
            }
            return stock;
        }

        //Gets the List of Stocks from the DB
        public List<string> GetStocks()
        {
            var stk =_context.Stocks.Select(x => x.StockName).ToList();
            return stk;
        }

        //Gets the price of the selected stock
        public int getstockRate(string data)
        {
            //if (select != null)
           // {
                var s = _context.Stocks.Where(a => a.StockName == data).Select(x => x.StockPrice).FirstOrDefault();
                
           // }
            //var stockRate = _context.Stocks.Select(x => x.StockPrice).Where().ToList();
            return s;
        }
    }
}
