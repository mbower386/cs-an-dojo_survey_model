using DojoSurveyModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyModel.Controllers
{
    public class DojoSurveyModelController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }

        // remember to use [HttpPost] attributes!
        [HttpPost]
        [Route ("submit")]
        public IActionResult Submit (string inputName, string location, string language, string comment)
        {
            Survey survey = new Survey (inputName, location, language, comment);

            return View ("Survey", survey);
        }

    }
}