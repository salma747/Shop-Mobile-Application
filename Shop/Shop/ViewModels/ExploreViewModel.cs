using Shop.Models;
using Shop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class ExploreViewModel: BaseViewModel
    {
        public List<Category> AllCategories { get => GetCategories(); }
        public ICommand CatTapCommand => new Command<Category>(OpenCategoryProducts);

        private List<Category> GetCategories()
        {
            return CategoryService.GetCategories();
        }
        async void OpenCategoryProducts(Category category)
        {
           await Application.Current.MainPage.Navigation.PushModalAsync((new CategoriesPage(category)));
        }

    }
}
