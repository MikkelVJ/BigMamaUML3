﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaUML3
{
    public interface ICustomerCatalog
    {
        int Count { get; }
        void AddCustomer(ICustomer aCustomer);
        ICustomer LookupCustomerName(string name);
        ICustomer LookupCustomerId(int id);
        void DeleteCustomer(int id);
        void UpdateCustomer(string phoneNo, ICustomer theCustomer);
        void PrintCustomerList();
    }
}
