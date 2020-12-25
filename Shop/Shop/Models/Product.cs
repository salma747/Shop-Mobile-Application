using Newtonsoft.Json;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shop.Models
{
    public class Product
    {
        public Product()
        {
            Sizes = new List<string>();
            Colors = new List<string>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> Colors { get; set; }
        public string Details { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   ID == product.ID;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
      
    }
}
