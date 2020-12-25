using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public List<Order> Orders { get; set; }
        public Cart Cart { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

    }
}
