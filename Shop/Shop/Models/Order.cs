using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItems>();
        }

        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItems> OrderItems { get; set; }

        public float TotalPrice { 
            get {
                float total = 0;
                foreach (OrderItems orderItems in OrderItems)
                {
                    total += orderItems.Product.Price * orderItems.Quantity;
                }
                return total;
            } }
       
    }
}
