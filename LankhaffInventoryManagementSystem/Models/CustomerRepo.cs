using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public class CustomerRepo : ICustomerInterface
    {
        private readonly InventoryDBContext _context;

        //Initializes the DBCOntext by creating an instance 
        public CustomerRepo(InventoryDBContext context)
        {
            this._context = context;
        }
        
        //Adds a cutomer to the DB
        public string AddCustomer(RegisterCustomer customer)
        {
            string message = string.Empty;
            if(!(_context.Customers.Any(x => x.CustomerName == customer.CustomerName)))
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                message= "Customer Saved";
                return message;
            }
            else
            {
                message = "Customer already exists";
                return message;
            }
            //return customer;
        }

        //Gets the list of custoemrs from the DB
        public IEnumerable<RegisterCustomer> GetAllCustomers()
        {
            return _context.Customers;
        }

        //gets a particular customer based on ID from the DB
        public List<RegisterCustomer> GetACustomer(int id)
        {
            List<RegisterCustomer> customerDetails = new List<RegisterCustomer>();
            customerDetails.Add(this._context.Customers.Find(id));
            return customerDetails;
        }
    }
}
