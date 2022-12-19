using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectC.Models;
using System.Security.Principal;


namespace ProjectC.Controllers
{
    public class AdminController : Controller
    {
		public MyDbContext db;
		public AdminController(MyDbContext db)
		{
			this.db = db;
		}

		/*[HttpGet]
        public IActionResult CreateInnov()
        {
            return View("Edit");

        }*/
        [HttpGet]
        public ActionResult AdminDashboardMain()
        {
		
			var fetchedInnovs = db.innovations;
			return View("AdminDashboardMain", fetchedInnovs);
			
				
		}

        [HttpGet]
        public IActionResult Edit()
        {
            return View();

        }

		[HttpGet]
		public IActionResult Item(Innovation innovToShow)
		{
			return View("Item", innovToShow);

		}

		[HttpPost]
		public IActionResult Delete(Innovation innovToDelete)
		{
			db.innovations.Entry(db.innovations.Find(innovToDelete.id)).State = EntityState.Detached;
			db.innovations.Remove(innovToDelete);
			db.SaveChanges();
			
			var fetchedInnovs = db.innovations;
			return View("AdminDashboardMain", fetchedInnovs);

		}

		[HttpPost]
		public ActionResult SaveItem(Item item)
		{
			
			db.innovations.Add(new Innovation(Guid.NewGuid(), item.name, item.description, item.price, item.amount,
				item.implementCosts, item.personelSavings, item.hoursSavings, item.implementHours, ((item.socialBenefits - item.socialCosts) / item.implementCosts)));
			db.SaveChanges();
			var fetchedInnovs = db.innovations;
			return View("AdminDashboardMain", fetchedInnovs);
				
			
		}

	}
}
