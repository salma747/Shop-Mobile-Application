using Shop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class SignupViewModel: BaseViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICommand RegisterCommand => new Command(Register);
        public ICommand LoginCommand => new Command(ToLogin);

        private void Register()
        {
            if(Login.Equals("")|| Password.Equals("") || FirstName.Equals("") || LastName.Equals("") || Email.Equals(""))
            {
                AndroidPopUp.ShortToast("Fill the form first");
            }
            else
            {
                if (UserService.Register(Login, Password, FirstName, LastName, Email) != null)
                {
                    AndroidPopUp.ShortToast("Account created successfully");
                    ToLogin();
                }
                else
                {
                    AndroidPopUp.ShortToast("Error");
                }
            }

        }
        private async void ToLogin()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new LoginPage()));
        }
    }
}
