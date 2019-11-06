using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName="Hard Candy", CategoryDescription="somme hard candy description"},

            new Category{CategoryId = 2, CategoryName="Chocolate Candy", CategoryDescription="somme Chocolate candy description"},

            new Category{CategoryId = 2, CategoryName="Sweet and Sour Candy", CategoryDescription="somme sweet and sour candy description"}

        };
    }
}
