using Shop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class PaymentViewModel :BaseViewModel
    {
        public string FullName { get; set; }
        public ICommand DeliveryCommand => new Command(OpenDelivery);

        public PaymentViewModel()
        {
            FullName = CustomerService.GetCurrentCustomer().FullName;
        }
        private async void OpenDelivery()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new DeliveryPage()));
        }
    }
}
