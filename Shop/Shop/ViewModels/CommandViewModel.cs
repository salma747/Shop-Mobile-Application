using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ViewModels
{
    public class CommandViewModel : BaseViewModel
    {
        public List<Order> Orders { get; set; }

        public CommandViewModel()
        {
            var customer = CustomerService.GetCurrentCustomer();
            Orders = customer.Orders;


        }
    }
}
