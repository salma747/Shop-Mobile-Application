using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Shop.ViewModels;
using Rg.Plugins.Popup.Services;
using Shop.Models;

namespace Shop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        private CategoriesViewModel CategoriesViewModel;
        public CategoriesPage(Category category)
        {
            CategoriesViewModel = new CategoriesViewModel(category);
            InitializeComponent();
            title.Text = category.Name;
            BindingContext = CategoriesViewModel;

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
           
        }

    }
}