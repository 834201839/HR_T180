using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        Models.Model1 db = new Model1();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(string id, string pwd)
        {
            User user = db.Users.FirstOrDefault(s => s.Username == id && s.PassWord == pwd);
            List<User> users = db.Users.ToList();


            if (user != null)
            {
                Session["user"] = user;
                return Redirect("../Page1/UpdataPassword");

            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Vi()
        {

            return View(db.QuanXians.Where(s => s.ParentID == null));
        }
    }
}