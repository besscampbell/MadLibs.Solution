using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/input")]
        public ActionResult Input() { return View();}

        [Route("/output")]
        public ActionResult Output(string country, string adjective1, string noun1, string pastTenseVerb, string noun2, string adjective2, string celebrity, string ingverb, string noun3 )
        {
            InputVariable madLibVariable = new InputVariable();
            madLibVariable.Country = country;
            madLibVariable.Adjective1 = adjective1;
            madLibVariable.Noun1 = noun1;
            madLibVariable.PastTenseVerb = pastTenseVerb;
            madLibVariable.Noun2 = noun2;
            madLibVariable.Adjective2 = adjective2;
            madLibVariable.Celebrity = celebrity;
            madLibVariable.IngVerb = ingverb;
            madLibVariable.Noun3 = noun3;
            return View(madLibVariable);
        }
    }
}