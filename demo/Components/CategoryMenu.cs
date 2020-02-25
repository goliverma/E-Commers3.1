using System.Linq;
using demo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace demo.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository=categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.Categories.OrderBy(x => x.CategoryName);
            return View(categories);
        }
    }
}