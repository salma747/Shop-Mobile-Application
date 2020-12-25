using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class DeliveryViewModel : BaseViewModel
    {
        public DeliveryViewModel()
        {

        }

        public void Buy()
        {
            CustomerService.Buy(CustomerService.GetCurrentCustomer().Cart.OrderItems);
            AndroidPopUp.LongToast("Command Purchased");
            Application.Current.MainPage = new AppShell();

        }
    }
}
