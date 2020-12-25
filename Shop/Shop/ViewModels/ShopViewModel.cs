using Shop.Models;
using Shop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class ShopViewModel : BaseViewModel
    {

        public ICommand ItemTapCommand => new Command<Product>(OpenProduct);
        public ICommand CollectionCommand => new Command(OpenCollection);
        public ICommand LoginCommand => new Command(Login);
        public ICommand RegisterCommand => new Command(Register);
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> CollectionsList { get => GetCollections(); }
        public List<Product> TrendsList { get => GetTrends(); }
        public bool IsNotLoggedIn { get; set; }

        public ShopViewModel()
        {
            IsNotLoggedIn = CustomerService.GetCurrentCustomer() == null;
            Console.WriteLine(IsNotLoggedIn);
        }

        async void OpenCollection()
        {
            await Shell.Current.GoToAsync("//home/collection");
        }
        async void Login()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new LoginPage()));
        }
        async void Register()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new SignupPage()));
        }

        private List<Banner> GetBanners()
        {           
            return BannerService.GetBanners();
        }

        private List<Product> GetCollections()
        {
            return new List<Product>()
            {
                ProductService.GetProduct(1),
                ProductService.GetProduct(2),
                ProductService.GetProduct(3),

            };
        }

        private List<Product> GetTrends()
        {
           return new List<Product>()
            {
                ProductService.GetProduct(15),
                ProductService.GetProduct(22),
                ProductService.GetProduct(34),

            };
        }

        async void OpenProduct(Product product)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync((new ProductPage(product)));
        }



    }
}
