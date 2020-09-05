using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseOfferingApplication.Controllers
{
    public class CoOrdinatorController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }
    }
}
