using System;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Web.Models;

namespace RealEstateApp.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }
    }
}