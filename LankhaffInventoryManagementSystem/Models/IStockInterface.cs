using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public interface IStockInterface
    {
        RegisterStocks AddStock(RegisterStocks stock);
    }
}
