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
        public int ID { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Customer Email")]
        public string CustomerEmail { get; set; }
        [Required]
        [Display(Name = "Customer Telephone Number")]
        public string CustomerTelephone { get; set; }
        [Required]
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }

    }
}
