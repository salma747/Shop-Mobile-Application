using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Shop.Models
{
    public class OrderItems
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public string Size { get; set; }
        public string ProductColor { get; set; }
        public Color Color { get; set; }
    }
}
