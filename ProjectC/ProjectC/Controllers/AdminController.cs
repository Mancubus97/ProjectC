using Microsoft.AspNetCore.Mvc;
using ProjectC.Models;

namespace ProjectC.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult CreateInnov()
        {
            return View("Edit");

        }
        [HttpGet]
        public ActionResult AdminDashboardMain()
        {
            return View();

        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();

        }

		[HttpGet]
		public IActionResult Item()
		{
			return View();

		}


	}
}
