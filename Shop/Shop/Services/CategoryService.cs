using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Services
{
    public class CategoryService : ICategory
    {
        public List<Category> GetCategories()
        {
            return API.Categories;
        }

        public Category GetCategory(int id)
        {
            foreach (Category category in API.Categories)
            {
                if (category.ID == id)
                    return category;
            }
            return null;
        }
    }
}
