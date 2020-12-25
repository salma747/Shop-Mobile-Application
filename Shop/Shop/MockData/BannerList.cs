using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.MockData
{
    public class BannerList
    {
        public static Banner Banner = new Banner
        {
            Heading = "WINTER COLLECTION",
            Message = "60% Discount",
            Caption = "BEST DISCOUNT THIS SEASON",
            Image = "classic2.png"
        };
        public static Banner Banner1 = new Banner
        {
            Heading = "CLASSIC STYLE",
            Message = "30% Discount",
            Caption = "TOP DISCOUNT IS HERE",
            Image = "classic1.png"
        };
        public static Banner Banner2 = new Banner
        {
            Heading = "KIDS AS WELL",
            Message = "40% Discount",
            Caption = "THE BEST CHOICE FOUND",
            Image = "classic3.png"
        };
    }
}
