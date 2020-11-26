using System.Collections.Generic;
using WebApi5.Data;
using WebApi5.Data.Models;
using WebApi5.Data.Interfaces;
using WebApi5.Data.Models;

namespace WebShop.Data.Repository
{
    
    public class CategoryRepository : ICategoryW 
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }

        public IEnumerable<CategoryW> AllCategories => appDBContent.CategoryW;
    }
    
}