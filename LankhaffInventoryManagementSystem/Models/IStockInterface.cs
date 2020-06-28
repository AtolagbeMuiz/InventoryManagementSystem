using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public interface IStockInterface
    {
        string AddStock(RegisterStocks stock);

        List<string> GetStocks();
        int getstockRate(string data);
    }
}
