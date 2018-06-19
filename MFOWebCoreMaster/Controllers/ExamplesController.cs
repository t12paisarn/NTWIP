using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFOWebCoreMaster.Controllers
{
    public class ExamplesController : Controller
    {
       public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult InvoicePrint()
        {
            return View();
        }
        
        public IActionResult ProfileEx()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Lockscreen()
        {
            return View();
        }

        public IActionResult P404()
        {
            return View();
        }

        public IActionResult P500()
        {
            return View();
        }

        public IActionResult Blank()
        {
            return View();
        }

        public IActionResult Pace()
        {
            return View();
        }
    }
}