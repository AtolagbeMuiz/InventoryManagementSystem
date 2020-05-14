using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class InventoryDBContext:DbContext
    {
        public InventoryDBContext(DbContextOptions<InventoryDBContext> options)
           : base(options)
        {

        }

        public DbSet<RegisterCustomer> Customers { get; set; }
    }
}

