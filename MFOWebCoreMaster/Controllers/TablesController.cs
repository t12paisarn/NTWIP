using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFOWebCoreMaster.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Simple()
        {
            return View();
        }

        public IActionResult Data()
        {
            return View();
        }
    }
}