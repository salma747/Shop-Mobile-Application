using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class User : Customer
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
