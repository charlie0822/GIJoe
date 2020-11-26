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
    public class RegisterController : Controller
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
            try
            {
                var newname = new User() { username = request.username, password = request.password, mail = request.mail };
                _DBContext.Add(newname);
                await _DBContext.SaveChangesAsync();
                ViewBag.Content = $"Register Success";
                return View("Login");
            }
            catch (DbUpdateException)
            {
                _logger.LogError("Unable to save changes");
            }
            return View();
        }
    }
}
