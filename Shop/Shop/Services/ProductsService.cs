using Shop.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class ProductsService : IProduct
    {

        public List<Product> GetProducts()
        {
            return API.Products;
        }

        public Product GetProduct(int id)
        {
            foreach (Product product in API.Products)
            {
                if (product.ID == id)
                    return product;
            }
            return null;
        }

        public List<Product> Search(string query)
        {
            
            return API.Products.FindAll((p)=>p.Name.ToLower().Contains(query.ToLower()));
        }

        public List<Product> GetProductsByCategory(int id)
        {
            List<Product> results = new List<Product>();
            foreach (Product product in API.Products)
            {
                if (product.Category.ID==id)
                {
                    results.Add(product);
                }
            }
            return results;
        }
    }
}
