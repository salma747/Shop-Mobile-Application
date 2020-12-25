using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Shop.Services
{
    public class UserService : IUser
    {
        public User Login(string login,string password)
        {
            foreach(User user in API.Users)
            {
                if (user.Login.Equals(login) && user.Password.Equals(password))
                {
                    Preferences.Set("userID", user.ID);
                    return user;
                }
            }
            return null;
        }

        public void Logout()
        {
            Preferences.Remove("userID");
        }

        public User Register(string login, string password, string firstName, string lastName, string email)
        {
            foreach (User user in API.Users)
            {
                if(user.Login.Equals(login) || user.Email.Equals(email))
                {                    
                    return null;
                }
            }
            User newUser = new User
            {
                ID = API.Users.Count + 1,
                DateCreated = DateTime.Now,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Login = login,
                Password = password,
                Cart=new Cart(),
                
            };
            API.Customers.Add(newUser);
            API.Users.Add(newUser);
            return newUser;
        }
    }
}
