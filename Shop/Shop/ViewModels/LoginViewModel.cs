using Shop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand => new Command(TryLogin);
        public ICommand RegisterCommand => new Command(Register);
        public LoginViewModel()
        {
            
        }
        private void TryLogin()
        {
            var user = UserService.Login(Login, Password);
            if (user!=null)
            {
                AndroidPopUp.LongToast("Welcome "+user.FirstName);
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                AndroidPopUp.ShortToast("Error");
            }
        }
        async void Register()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new SignupPage()));
        }
    }
}