using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo.Models;
using demo.Models.Interfaces;
using demo.ViewModels;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrinkRepository drinkRepository;

        public HomeController(ILogger<HomeController> logger, IDrinkRepository drinkRepository)
        {
            _logger = logger;
            this.drinkRepository=drinkRepository;
        }

        public IActionResult Index()
        {
            var home=new HomeViewModel{
                PreferredDrinks = drinkRepository.PreferredDrinks
            };
            return View(home);
        }
    }
}
