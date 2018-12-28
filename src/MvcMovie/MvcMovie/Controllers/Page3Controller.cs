using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class Page3Controller : Controller
    {
        // GET: 薪金标准管理
        public ActionResult XinJinList()
        {
            return View();
        }
              //薪金标准新建
        public ActionResult XinJinCreate()
        {
            return View();
        }
              //薪金标准修改
        public ActionResult XinJinEdit()
        {
            return View();
        }
              //薪金标准查看
        public ActionResult XinJinView()
        {
            return View();
        }
    }
}