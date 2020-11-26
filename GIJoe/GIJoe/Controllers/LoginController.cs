using GIJoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GIJoe.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _DBContext;
        public HomeController(ILogger<HomeController> logger, DBContext dbcontext)
        {
            _logger = logger;
            _DBContext = dbcontext;
        }

        public IActionResult Index(User request)
        {
            if (HasSpecialChars(request.username) || HasSpecialChars(request.password))
            {
                ViewBag.Content = "Invalid input, please try again";
                return View();
            }

            foreach (var i in _DBContext.user)
            {
                if (request.username == i.username && request.password == i.password)
                {
                    ViewBag.Content = $"Hello! {i.username}";
                    return View();
                }
            }

            ViewBag.Content = "Login fail";
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
