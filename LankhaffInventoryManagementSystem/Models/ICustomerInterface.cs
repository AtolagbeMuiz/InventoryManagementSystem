﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LankhaffInventoryManagementSystem.Models
{
    public interface ICustomerInterface
    {
        string AddCustomer(RegisterCustomer customer);

        IEnumerable<RegisterCustomer> GetAllCustomers();

        List<RegisterCustomer> GetACustomer(int id);
    }
}
