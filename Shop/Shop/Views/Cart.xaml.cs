using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Shop.ViewModels;
using Xamarin.Forms.Xaml;

namespace Shop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        private CartViewModel CartViewModel;
        public Cart()
        {
            CartViewModel = new CartViewModel(Navigation);
            InitializeComponent();
            BindingContext = CartViewModel;
        }
      
    }
}