using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Context;
using DataLayer.Services;
using ViewModels;

namespace KimiaCharm.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
        public IActionResult NewPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewPassword(NewPasswordViewModel model)
        {
            return View();
        }
        public IActionResult EmailVertificationForResetingPassword()
        {
            return View();
        }
        public IActionResult SignOut()
        {
            return View();
        }
    }
}
