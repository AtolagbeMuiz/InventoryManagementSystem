using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class RegisterStocks
    {
        public int ID { get; set; }

        public DateTime DateStockRegistered { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Stock Name")]
        public string StockName { get; set; }

        [Required]
        [Display(Name = "Stock Price")]
        public int StockPrice { get; set; }
    }
}
