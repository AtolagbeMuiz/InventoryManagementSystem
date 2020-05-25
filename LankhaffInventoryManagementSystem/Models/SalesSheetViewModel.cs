using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class SalesSheetViewModel
    {
        public IEnumerable<RegisterCustomer> Customers { get; set; }
        //public List<RegisterStocks> Stocks { get; set; }
        public List<string> Stocks { get; set; }

    }
}
