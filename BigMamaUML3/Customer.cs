using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaUML3
{
    class Customer : ICustomer
    {
        public int Id { get; }
        public string Name { get; set; }
        private string _name;

        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
}
