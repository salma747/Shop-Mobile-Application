using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace Shop.ViewModels
{
    public class ProductViewModel: BaseViewModel
    {
        public Product Product { get; set; }
        public ICommand OnAddCommand { get; }
        public ICommand OnSelectColor { get; }
        public ICommand OnSelectSize { get; }
        public string Size { get; set; }
        public Color Color { get; set; }
        public string ColorValue { get; set; }
        public ProductViewModel(Product product)
        {
            Product = product;
            Size = product.Sizes[0];
            ColorValue = product.Colors[0];
            Color = System.Drawing.Color.FromName(product.Colors[0]);
            OnAddCommand = new Command(AddProductToCart);
            OnSelectColor = new Command(SelectColor);
            OnSelectSize = new Command(SelectSize);
           
        }

        private void AddProductToCart()
        {
            CustomerService.AddProductToCart(Product,Size,ColorValue);
            AndroidPopUp.ShortToast(Product.Name + " Added");
        }

        private async void SelectColor()
        {
                string action = await Application.Current.MainPage.DisplayActionSheet("Select Color", "Cancel", null, Product.Colors.ToArray());
            
            if (action != "Cancel")
            {
                ColorValue = action;
                Color = System.Drawing.Color.FromName(action);
                OnPropertyChanged("Color");
                OnPropertyChanged("ColorValue");
            }

        }
        private async void SelectSize()
        {
            string action = await Application.Current.MainPage.DisplayActionSheet("Select Size", "Cancel", null, Product.Sizes.ToArray());

            if (action != "Cancel")
            {
                Size = action;
                OnPropertyChanged("Size");
            }

           
        }
    }
}
