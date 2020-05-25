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

        public StockRepo(InventoryDBContext context)
        {
            this._context = context;
        }
        public RegisterStocks AddStock(RegisterStocks stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }

        public List<string> GetStocks()
        {
            //List<RegisterStocks> stks = new List<RegisterStocks>();
            var stk =_context.Stocks.Select(x => x.StockName).ToList();
            return stk;
        }
    }
}
