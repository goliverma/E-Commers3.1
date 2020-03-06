using System.Threading.Tasks;
using demo.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager=userManager;
            this.signInManager=signInManager;
        }
        public IActionResult Login(string returnurl)
        {
            return View(new LoginViewModel(){
                returnurl = returnurl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid)
                return View(loginViewModel);
            var user = await userManager.FindByNameAsync(loginViewModel.UserName);
            if(user != null)
            {
                var result=await signInManager.PasswordSignInAsync(user,loginViewModel.Password,false,false);
                if(result.Succeeded)
                {
                    if(string.IsNullOrEmpty(loginViewModel.returnurl))
                    return RedirectToAction("Index","Home");
                    return Redirect(loginViewModel.returnurl);
                }
            }
            ModelState.AddModelError("","Username/password not found");
            return View(loginViewModel);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                var user=new IdentityUser(){UserName = loginViewModel.UserName};
                var result=await userManager.CreateAsync(user,loginViewModel.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View(loginViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}