using Shop.Models;
using Shop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{  
    public class CategoriesViewModel : BaseViewModel
    {


        public ObservableCollection<Product> Products { get; private set; }
        public Category Category { get; set; }

        public ICommand ItemTapCommand => new Command<Product>(OpenProduct);
        public CategoriesViewModel(Category category)
        {
            Category = category;
            Products = new ObservableCollection<Product>(ProductService.GetProductsByCategory(Category.ID));
        }

        private async void OpenProduct(Product product)
        {            
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductPage(product));
        }

    }


}
