using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Shop.Services
{
    public class CustomerService : ICustomer
    {
        public Cart AddProductToCart(Product product, string size, string color)
        {
            var customer = GetCurrentCustomer();
            if (customer != null)
            {
                bool exist = false;
                foreach (OrderItems orderItems in customer.Cart.OrderItems)
                {
                    if (orderItems.Product.ID == product.ID && orderItems.Size == size && orderItems.ProductColor == color)
                    {
                        orderItems.Quantity = orderItems.Quantity + 1;
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    customer.Cart.OrderItems.Add(new OrderItems()
                    {
                        ID = API.OrderItems.Count + 1,
                        Product = product,
                        Quantity = 1,
                        Size = size,
                        ProductColor = color,
                        Color = System.Drawing.Color.FromName(color)
                    });
                }
                return customer.Cart;
            }
            return null;
        }

        public Order Buy(List<OrderItems> orderItems)
        {
            var customer = GetCurrentCustomer();
            if (customer != null)
            {
                Order newOrder = new Order
                {
                    ID = API.Orders.Count + 1,
                    OrderDate = DateTime.Now,
                };
                newOrder.OrderItems.AddRange(orderItems);
                customer.Orders.Add(newOrder);
                API.Orders.Add(newOrder);
                customer.Cart.OrderItems.RemoveAll(delegate (OrderItems order)
                {
                    return orderItems.Contains(order);
                });
                return newOrder;
            }
            return null;
        }

        public Customer GetCurrentCustomer()
        {
            int id = Preferences.Get("userID", 0);
            return GetCustomer(id);
        }

        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in API.Customers)
            {
                if (customer.ID == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public void UpdateProfile(string firstName, string lastName, string phone, string zipCode, string street, string city)
        {
            var customer=GetCurrentCustomer();
             customer.FirstName= firstName;
            customer.LastName=lastName;
            customer.Phone=phone;
            customer.ZipCode = zipCode ;
            customer.Street=street;
            customer.City=city;
        }
    }
}
