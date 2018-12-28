using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class Page1Controller : Controller
    {


        Models.Model1 db = new Model1();
        // GET: 修改账户密码

        public ActionResult UpdataPassword()
        {
            User user = Session["user"] as User;

            ViewBag.mima = user.PassWord;
            return View();
        }
        [HttpPost]
        public ActionResult UpdataPassword(string xin)
        {
            User user = Session["user"] as User;
            db.Users.FirstOrDefault(s => s.ID == user.ID).PassWord = xin;
            db.SaveChanges();

            return View();
        }
        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult ScheduleChuLi()
        {
            return View();
        }

    }
}