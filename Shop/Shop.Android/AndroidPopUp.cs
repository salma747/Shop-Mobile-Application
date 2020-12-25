using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using Shop.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Shop.Droid.AndroidPopUp))]
namespace Shop.Droid
{
    public class AndroidPopUp : IAndroidPopUp
    {
        public void ShortToast(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }

        public void LongToast(string message)
        {        
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}