using Shop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("shop", typeof(ShopPage));
            Routing.RegisterRoute("explore", typeof(ExplorePage));
            Routing.RegisterRoute("collection", typeof(CollectionsPage));
            Routing.RegisterRoute("account", typeof(Account));
        }
    }
}