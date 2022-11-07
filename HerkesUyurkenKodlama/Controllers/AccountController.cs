using HerkesUyurkenKodlama.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerkesUyurkenKodlama.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //login islemleri
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //login islemleri
            }

            return View(model);
        }


        public IActionResult Profile()
        {
            return View();
        }
    }
}
