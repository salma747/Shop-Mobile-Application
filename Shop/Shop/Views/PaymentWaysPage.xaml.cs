using Shop.Models;
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
    public partial class PaymentWaysPage : ContentPage
    {
        private bool IsChecked { get; set; }
        public PaymentWaysPage()
        {
            InitializeComponent();
        }



        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = true;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(IsChecked)
            {
                await Navigation.PushModalAsync(new PaymentPage());
            }
        }
    }
}