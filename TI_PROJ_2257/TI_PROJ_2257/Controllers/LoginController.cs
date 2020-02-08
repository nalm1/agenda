using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TI_PROJ_2257.Models;

namespace TI_PROJ_2257.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string pass)
        {
            Log log = new Log(username, pass);
            if (log.logged)
            {
                ViewBag.log = log;
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Registar(string username, string pass, string mail)
        {
            return View("login");
        }
    }
}