using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Interfaces
{
    public interface ICustomer
    {
        Cart AddProductToCart(Product product,string size,string color);

        Order Buy(List<OrderItems> orderItems);

        Customer GetCustomer(int id);

        Customer GetCurrentCustomer();

        void UpdateProfile(string firstName, string lastName, string phone, string zipCode, string street, string city);
        
    }
}
