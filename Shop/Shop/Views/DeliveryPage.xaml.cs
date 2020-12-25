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
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeliveryPage : ContentPage
    {
        private DeliveryViewModel DeliveryViewModel;
        private bool IsChecked { get; set; }
        public DeliveryPage()
        {
            DeliveryViewModel = new DeliveryViewModel();
            InitializeComponent();
            BindingContext = DeliveryViewModel;
        }



        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = true;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (IsChecked)
            {
                DeliveryViewModel.Buy();
            }
        }

    }
}