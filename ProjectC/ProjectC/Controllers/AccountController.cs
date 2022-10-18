using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public ActionResult Verify(Account account)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var userDetails = db.accounts.Where(_ => _.username == account.username && _.password == account.password).FirstOrDefault();
                if (userDetails != null)
                {
                    Console.WriteLine("Here");
                    return View("Create");
                }
                else
                {
                    Console.WriteLine("Here");
                    return View("Error");
                }
            }
                
        }
    }
    
}
