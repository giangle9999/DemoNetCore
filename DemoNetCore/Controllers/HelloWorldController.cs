using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoNetCore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index (){
            return View ();
        }
        public IActionResult Demo(){
            return View ();
        }
        }
}