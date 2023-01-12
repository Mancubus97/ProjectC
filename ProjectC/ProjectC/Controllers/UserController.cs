using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectC.Models;
using System.Security.Principal;


namespace ProjectC.Controllers
{
    public class UserController : Controller
    {
		public MyDbContext db;
		public UserController(MyDbContext db)
		{
			this.db = db;
		}


        [HttpGet]
        public ActionResult UserDashboardMain()
        {
		
			var fetchedInnovs = db.innovations;
			return View("UserDashboardMain", fetchedInnovs);
			
				
		}

		[HttpGet]
		public IActionResult Item(Innovation innovToShow)
		{
			return View("Item", innovToShow);

		}


	}
}
