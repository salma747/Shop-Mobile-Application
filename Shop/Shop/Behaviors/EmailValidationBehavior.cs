using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Shop.Behaviors
{
    public class EmailValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.Unfocused += OnTextChanged;
            
            base.OnAttachedTo(bindable);
        }

        private void OnTextChanged(object sender,FocusEventArgs focusEventArgs)
        {
            var entry = (Entry) sender;
            var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            var isValid = Regex.IsMatch(entry.Text, emailPattern);
            entry.TextColor = isValid ? Color.Black : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Unfocused -= OnTextChanged;
            base.OnDetachingFrom(bindable);
        }
        
    }
}