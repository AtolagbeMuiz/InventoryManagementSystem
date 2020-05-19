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
    }
}
