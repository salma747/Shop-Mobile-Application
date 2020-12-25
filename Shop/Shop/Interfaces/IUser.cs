using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Interfaces
{
    public interface IUser
    {
        User Register(string login,string password,string firstName,string lastName,string email);
        User Login(string login,string password);

        void Logout();
    }
}
