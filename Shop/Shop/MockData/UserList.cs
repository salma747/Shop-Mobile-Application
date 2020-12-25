using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.MockData
{
    public class UserList
    {
        public static User User = new User
        {
            ID = 1,
            FirstName = "Mohamed",
            LastName = "Mseddi",
            City = "Sfax",
            DateCreated = new DateTime(2020, 11, 29),
            Login = "Troliste",
            Password = "1996medmsd",
            Email = "mameya.mseddi@gmail.com",
            Phone = "99481394",
            ZipCode = "3069",
            Street = "Route Tunis km 2.5",
            Cart = new Cart()
            {
                ID=1,
            }
        };
        public static User User1 = new User
        {
            ID = 2,
            FirstName = "Salma",
            LastName = "Ghariani",
            City = "Sfax",
            DateCreated = new DateTime(2020, 11, 29),
            Login = "Slayma",
            Password = "ghariani",
            Email = "salma.ghariani@gmail.com",
            Phone = "99663322",
            ZipCode = "3058",
            Street = "Route Gremda km 3",
            Cart = new Cart() 
            {
                ID=2,
            }
        };
    }
}
