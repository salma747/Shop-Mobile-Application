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
    public partial class MyCommandPage : ContentPage
    {
        private CommandViewModel CommandViewModel;
        public MyCommandPage()
        {
            CommandViewModel = new CommandViewModel();
            InitializeComponent();
            BindingContext = CommandViewModel;
        }
    }
}