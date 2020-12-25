using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {

        public ICommand OpenCart => new Command(ToCart);
        public ICommand OpenCommands => new Command(ToCommands);
        public ICommand LogoutCommand => new Command(Logout);

        public ICommand EditProfileCommand => new Command(EditProfile);
        public bool IsLoggedIn { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

        public Customer Customer { get; set; }

        public AccountViewModel()
        {
            Customer = CustomerService.GetCurrentCustomer();
            IsLoggedIn = Customer != null;
            if(IsLoggedIn)
            {
                FullName = Customer.FullName;
                Email = Customer.Email;
            }
            else
            {
                FullName = "Not Connected";
                Email = "";
            }
        }

        private async void EditProfile()
        {
            if(IsLoggedIn)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync((new Shop.Views.EditProfile()));
            }
        }
        private async void ToCart()
        {
            if(IsLoggedIn)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync((new Shop.Views.Cart()));
            }
        }
        private async void ToCommands()
        {
            if (IsLoggedIn)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new Shop.Views.MyCommandPage());
            }
        }
        private async void Logout()
        {
            UserService.Logout();
            Application.Current.MainPage = new AppShell();
        }

    }
}
