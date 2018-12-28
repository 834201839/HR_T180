using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class Page5Controller : Controller
    {
        // GET: 职位发布管理
        public ActionResult ZhaoPinManage()
        {
            return View();
        }

        //简历管理
        public ActionResult JianLiManage()
        {
            return View();
        }

        //面试管理
        public ActionResult MianShiManage()
        {
            return View();
        }
    }
}