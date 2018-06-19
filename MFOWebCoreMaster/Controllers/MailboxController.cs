using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFOWebCoreMaster.Controllers
{
    public class MailboxController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }

        public IActionResult Compose()
        {
            return View();
        }

        public IActionResult Read()
        {
            return View();
        }
    }
}