using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Interfaces;
using Lab8_Shop.Data.Models;

namespace Lab8_Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
