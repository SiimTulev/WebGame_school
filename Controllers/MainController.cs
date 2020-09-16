using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebGame.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}
