using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    public class EditProfileViewModel : BaseViewModel
    {
        public ICommand UpdateCommand => new Command(UpdateProfile);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public EditProfileViewModel()
        {
            var customer = CustomerService.GetCurrentCustomer();
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;
            ZipCode = customer.ZipCode;
            Street = customer.Street;
            City = customer.City;
        }

        private void UpdateProfile()
        {
            if(FirstName.Equals("") ||
                LastName.Equals("") || 
                Phone.Equals("") || 
                ZipCode.Equals("") ||
                Street.Equals("") || 
                City.Equals(""))
            {
                AndroidPopUp.ShortToast("Fill the form");
            }
            else
            {
                CustomerService.UpdateProfile(FirstName, LastName, Phone, ZipCode, Street, City);
                AndroidPopUp.ShortToast("Profile Updated");
                Application.Current.MainPage = new AppShell();
            }
        }
    }
}
