using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class CustomerRepo : ICustomerInteface
    {
        private readonly InventoryDBContext _context;

        public CustomerRepo(InventoryDBContext context)
        {
            this._context = context;
        }
        public RegisterCustomer AddCustomer(RegisterCustomer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public IEnumerable<RegisterCustomer> getAllCustomers()
        {
            return _context.Customers;
        }


    }
}
