using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Shop.Views
{
    [DesignTimeVisible(false)]
    public partial class EditProfile : ContentPage
    {
        public EditProfileViewModel EditProfileViewModel;
        public EditProfile()
        {
            EditProfileViewModel = new EditProfileViewModel();
            InitializeComponent();
            BindingContext = EditProfileViewModel;
        }
    }
}