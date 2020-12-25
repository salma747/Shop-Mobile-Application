using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.MockData
{
    public class CategoryList
    {
        public static Category Vetements = new Category 
        { 
            ID = 1,
            Name = "CLOTHES",
            Image = "clothesIcon",
            Caption="TOP DISCOUNT IS HERE"
        };
        public static Category Chaussures = new Category
        {
            ID = 2,
            Name = "SHOES",
            Image = "shoesIcon",
            Caption = "TOP DISCOUNT IS HERE"
        };
        public static Category Accessoires = new Category
        {
            ID = 3,
            Name = "ACCESSORIES",
            Image = "accessoiresIcon",
            Caption = "TOP DISCOUNT IS HERE"
        };
    }
}
