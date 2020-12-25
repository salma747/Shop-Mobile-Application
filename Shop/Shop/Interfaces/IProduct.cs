
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public interface IProduct
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        List<Product> Search(string query);

        List<Product> GetProductsByCategory(int id);
           
    }
}
