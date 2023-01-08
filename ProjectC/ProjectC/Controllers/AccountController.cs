using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectC.Models;
using System.Data.SqlClient;

namespace ProjectC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Verify(Account account)
        {
				MyDbContext db = new MyDbContext();

				var userDetails = db.accounts.Where(_ => _.username == account.username && _.password == account.password).FirstOrDefault();
                if (userDetails != null)
                {
				if (userDetails.isAdmin)
				{
					var fetchedInnovs = db.innovations;
					return View("../Admin/AdminDashboardMain", fetchedInnovs);
				}
				if (!userDetails.isAdmin)
				{
					var fetchedInnovs = db.innovations;
					return View("../User/UserDashboardMain", fetchedInnovs);
				}
					
                }

                return View("Error");
                
            
                
        }

		[HttpPost]
		public ActionResult RegisterAcc(Account account)
		{
			using (MyDbContext db = new MyDbContext())
			{
				var userDetails = db.accounts.Where(_ => _.username == account.username).FirstOrDefault();
				if (userDetails != null)
				{
					return View("Error2");
				}
				else
				{
                    // creating account
					db.accounts.Add(new Account(Guid.NewGuid(), account.username, account.password, false));
					db.SaveChanges();
					return View("Login");
				}
			}
		}



	}
    
}
