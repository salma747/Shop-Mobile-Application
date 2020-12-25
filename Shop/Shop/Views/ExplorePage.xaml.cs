﻿using Shop.Models;
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
    public partial class ExplorePage : ContentPage
    {
        private ExploreViewModel ExploreViewModel;
        public ExplorePage()
        {
            ExploreViewModel = new ExploreViewModel();
            InitializeComponent();
            BindingContext = ExploreViewModel;
        }

       
    }
}