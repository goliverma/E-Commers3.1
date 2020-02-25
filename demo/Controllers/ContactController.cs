using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}