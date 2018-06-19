using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFOWebCoreMaster.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartJs()
        {
            return View();
        }

        public IActionResult Morris()
        {
            return View();
        }

        public IActionResult Flot()
        {
            return View();
        }

        public IActionResult Inline()
        {
            return View();
        }
    }
}