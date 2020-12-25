using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Shop.Views
{
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel LoginViewModel;
        public LoginPage()
        {
            LoginViewModel = new LoginViewModel();
            InitializeComponent();
            BindingContext = LoginViewModel;
        }
    }
}