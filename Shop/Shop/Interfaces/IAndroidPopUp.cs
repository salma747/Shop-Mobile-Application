using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Interfaces
{
    public interface IAndroidPopUp
    {
        void ShortToast(string message);
        void LongToast(string message);
    }
}
