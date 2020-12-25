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
    public partial class CollectionsPage : ContentPage
    {
        private CollectionViewModel CollectionViewModel;
        public CollectionsPage()
        {
            CollectionViewModel = new CollectionViewModel();
            InitializeComponent();
            BindingContext = CollectionViewModel;
        }


    }

}