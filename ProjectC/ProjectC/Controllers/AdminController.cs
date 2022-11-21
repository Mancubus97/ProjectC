using Microsoft.AspNetCore.Mvc;
using ProjectC.Models;

namespace ProjectC.Controllers
{
    public class AdminController : Controller
    {
        [HttpPost]
        public ActionResult CreateInnov()
        {
            return View("CreateInnovMain");

        }


    }
}
