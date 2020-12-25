using Shop.Models;
using Shop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class CollectionViewModel:BaseViewModel
    {
        public ICommand SearchCommand => new Command(Search);
        public ICommand ItemTapCommand => new Command<Product>(OpenProduct);
        private string searchText;
        public string SearchText { get { return searchText; } set
            {

                searchText = value;
                if(value == "")
                {
                    MyCollections = GetCollections();
                    OnPropertyChanged("MyCollections");
                }
                OnPropertyChanged("SearchText");
            }
        }
        public CollectionViewModel()
        {
            MyCollections = GetCollections();
        }
        public List<Product> MyCollections { get; set; }

        private List<Product> GetCollections()
        {
            return ProductService.GetProducts();
  
        }
        private void Search()
        {
            Console.WriteLine(ProductService.Search(SearchText).Count);
            MyCollections = ProductService.Search(SearchText);
            OnPropertyChanged("MyCollections");
        }
        void OpenProduct(Product product)
        {
            Application.Current.MainPage.Navigation.PushModalAsync((new ProductPage(product)));
        }
    }
}
