using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class Page4Controller : Controller
    {
        // GET:  培训计划
        public ActionResult PeiXunJiHuaList()
        {
            return View();
        }
             //培训计划新建
        public ActionResult PeiXunCreate()
        {
            return View();
        }
             //培训计划页面
        public ActionResult PeiXunCreateFuHe()
        {
            return View();
        }
             //培训计划修改
        public ActionResult PeiXunEdit()
        {
            return View();
        }
            //培训计划查看
        public ActionResult PeiXunView()
        {
            return View();
        }

    }
}