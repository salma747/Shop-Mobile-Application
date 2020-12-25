using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        public PaymentViewModel PaymentViewModel;
        public PaymentPage()
        {
            PaymentViewModel = new PaymentViewModel();
            InitializeComponent();
            BindingContext = PaymentViewModel;
        }
    }
}