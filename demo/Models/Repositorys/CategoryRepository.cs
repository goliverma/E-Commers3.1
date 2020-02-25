using System.Collections.Generic;
using demo.Models.Data;
using demo.Models.Interfaces;

namespace demo.Models.Repositorys
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext=appDbContext;
        }
        public IEnumerable<Category> Categories => appDbContext.Categories;
    }
}