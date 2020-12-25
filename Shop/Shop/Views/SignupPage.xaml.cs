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
    public partial class SignupPage : ContentPage
    {
        private SignupViewModel SignupViewModel;
        public SignupPage()
        {
            SignupViewModel = new SignupViewModel();
            InitializeComponent();
            BindingContext = SignupViewModel;
        }
    }
}