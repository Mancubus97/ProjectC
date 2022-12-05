using Microsoft.AspNetCore.Mvc;
using ProjectC.Models;
using System.Security.Principal;

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

		[HttpPost]
		public ActionResult SaveItem(Item item)
		{
			using (MyDbContext db = new MyDbContext())
			{
				db.innovations.Add(new Innovation(Guid.NewGuid(), item.name, item.description, item.price, item.amount,
					item.implementCosts, item.personelSavings, item.hoursSavings, item.implementHours));
				db.SaveChanges();
				return View("AdminDashboardMain");
				
			}
		}

	}
}
