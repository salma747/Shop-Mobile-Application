using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using Shop.Views;

namespace Shop.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public ObservableCollection<OrderItems> OrderItems { get; private set; }

        public INavigation Navigation { get; set; }
        public ICommand CheckoutCommand => new Command(Checkout);

        public ICommand DeleteCommand => new Command<OrderItems>(RemoveCart);
        public Shop.Models.Cart Cart { get; set; }

        public float Total { get; set; }

        public CartViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Cart = CustomerService.GetCurrentCustomer().Cart;
            Total = Cart.GetTotalPrice();
            CreateItemCollection();
        }

        void RemoveCart(OrderItems orderItems)
        {
            foreach (OrderItems order in OrderItems)
            {
                if (order.ID == orderItems.ID)
                {
                    Cart.OrderItems.Remove(order);
                    OrderItems.Remove(order);
                    break;
                }
            }
            Total = Cart.GetTotalPrice();
            OnPropertyChanged("Total");
            OnPropertyChanged("Cart");
        }

        void CreateItemCollection()
        {
            OrderItems = new ObservableCollection<OrderItems>(Cart.OrderItems);

        }

        async void Checkout()
        {
            if (Total != 0)
            {
                await Navigation.PushModalAsync(new PaymentWaysPage());
            }
        }
    }
}
