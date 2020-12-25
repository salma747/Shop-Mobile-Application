using Shop.MockData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models
{
    public class API
    {
        public static List<Product> Products = new List<Product> 
        { 
            ProductList.Product,
            ProductList.Product1,
            ProductList.Product2, 
            ProductList.Product3,
            ProductList.Product10,
            ProductList.Product11,
            ProductList.Product12,
            ProductList.Product13,
            ProductList.Product14,
            ProductList.Product15,
            ProductList.Product16,
            ProductList.Product17,
            ProductList.Product18,
            ProductList.Product19,
            ProductList.Product20,
            ProductList.Product21,
            ProductList.Product22,
            ProductList.Product23,
            ProductList.Product24,
            ProductList.Product25,
            ProductList.Product26,
            ProductList.Product31,
            ProductList.Product32,
            ProductList.Product33,
            ProductList.Product34,
            ProductList.Product35,
            ProductList.Product36,
            ProductList.Product38,
            ProductList.Product40,
            ProductList.Product41,
            ProductList.Product42,
            ProductList.Product43,
            ProductList.Product44,
            ProductList.Product45,
            ProductList.Product46,
            ProductList.Product47,
            ProductList.Product48,
            ProductList.Product49

        };
        public static List<Category> Categories = new List<Category>
        {
            CategoryList.Vetements,
            CategoryList.Chaussures,
            CategoryList.Accessoires
        };
        public static List<Customer> Customers = new List<Customer>
        {
            CustomerList.Customer,
            CustomerList.Customer1
        };
        public static List<User> Users = new List<User>
        {
            UserList.User,
            UserList.User1
        };
        public static List<Order> Orders = new List<Order>
        {

        };
        public static List<OrderItems> OrderItems = new List<OrderItems>
        {

        };

        public static List<Banner> Banners = new List<Banner>
        {
            BannerList.Banner,
            BannerList.Banner1,
            BannerList.Banner2,
        };
    }
}
