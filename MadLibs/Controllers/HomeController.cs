using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/input")]
        public ActionResult Input() { return View();}

        [Route("/output")]
        public ActionResult Output()
        {

        }
    }
}