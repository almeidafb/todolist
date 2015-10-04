using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            User user = (User)Session["user"];

            if (user != null)
                return RedirectToAction("Index");
            else
            {
                ViewBag.Message = "Please login";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            var user = db.Users.SingleOrDefault(u => u.Name == name && u.Password == password);

            if (user != null) // login ok
            {
                Session["user"] = user;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Incorrect User or password!";
                return View();
            }
        }

        public ActionResult Logoff()
        {
            Session.Clear();

            return RedirectToAction("Login");
        }
    }
}