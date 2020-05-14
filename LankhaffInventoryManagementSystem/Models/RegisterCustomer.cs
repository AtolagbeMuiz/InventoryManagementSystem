using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class RegisterCustomer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int CustomerName { get; set; }
        [Required]
        public int CustomerEmail { get; set; }
        [Required]
        public int CustomerTelephone { get; set; }
        [Required]
        public int CustomerAddress { get; set; }

    }
}
