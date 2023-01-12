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
        public IActionResult Users()
        {
			var fetchedUsers = db.accounts;
			return View("users", fetchedUsers);

        }

		[HttpGet]
		public IActionResult ItemAdmin(Innovation innovToShow)
		{
			return View("ItemAdmin", innovToShow);

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
		public IActionResult DeleteAccount(Account accountToDelete)
		{
			db.accounts.Entry(db.accounts.Find(accountToDelete.id)).State = EntityState.Detached;
			db.accounts.Remove(accountToDelete);
			db.SaveChanges();

			var fetchedUsers = db.accounts;
			return View("users", fetchedUsers);

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


		[HttpPost]
		public ActionResult RegisterAdmin(Account account)
		{
		
			var userDetails = db.accounts.Where(_ => _.username == account.username).FirstOrDefault();
			if (userDetails != null)
			{
				return View("../Account/Error2");
			}
			else
			{
				// creating account
				db.accounts.Add(new Account(Guid.NewGuid(), account.username, account.password, true));
				db.SaveChanges();
				var fetchedUsers = db.accounts;
				return View("users", fetchedUsers);
			}
			
		}

	}
}
