using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string account, string password)
        {
            if (account=="joeychen" && password=="1234")
            {
                return RedirectToAction("Index", "Welcome");
            }

            return View();
        }
    }
}
