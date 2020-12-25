using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Interfaces
{
    public interface ICategory
    {
        List<Category> GetCategories();

        Category GetCategory(int id);

    }
}
