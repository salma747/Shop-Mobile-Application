using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Shop.Services;
using Shop.Views;

namespace Shop
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "CollectionView_Experimental", "SwipeView_Experimental","RadioButton_Experimental" });
            DependencyService.Register<ProductsService>();
            DependencyService.Register<CategoryService>();
            DependencyService.Register<CustomerService>();
            DependencyService.Register<BannerService>();
            DependencyService.Register<UserService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
