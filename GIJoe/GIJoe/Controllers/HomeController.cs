using GIJoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GIJoe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _DBContext;
        public HomeController(ILogger<HomeController> logger,DBContext dbcontext)
        {
            _logger = logger;
            _DBContext = dbcontext;
        }


        public IActionResult Index()
        {
            _logger.LogDebug("test debug log");
            _logger.LogError("test error log");
            return View();
        }

        public async Task<IActionResult> Register(User request)
        {


            return View();
        }
        //[HttpPost]
        public IActionResult Login(User request)
        {


            return View();
        }
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetterOrDigit(ch));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
