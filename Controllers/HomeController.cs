using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojo_Survey_Validations.Models;

namespace Dojo_Survey_Validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Survey(Survey survey)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("Valid");
                return View(survey);
            }
            else
            {
                Console.WriteLine("Not Valid");
                Console.WriteLine(survey.Name);
                return View("Index");
            }
        }
    }
}
