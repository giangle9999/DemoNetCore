using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetCore
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}