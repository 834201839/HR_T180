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
        public ActionResult ZhaoPinManageList()
        {
            return View();
        }
             //新建职位发布
        public ActionResult ZhaoPinCreate()
        {
            return View();
        }
             //职位发布变更
        public ActionResult ZhaoPinEdit()
        {
            return View();
        }
             //查看职位信息
        public ActionResult ZhaoPinView()
        {
            return View();
        }

        //简历管理
        public ActionResult JianLiManageList()
        {
            return View();
        }
               //简历发布
        public ActionResult JianLiCreate()
        {
            return View();
        }
               //简历变更
        public ActionResult JianLiEdit()
        {
            return View();
        }
              //简历信息
        public ActionResult JianLiView()
        {
            return View();
        }
              //简历详细信息
        public ActionResult JianLiViewAll()
        {
            return View();
        }
        //面试管理list
        public ActionResult MianShiManageList()
        {
            return View();
        }
              //新建面试
        public ActionResult MianShiCreate()
        {
            return View();
        }
              //查看面试
        public ActionResult MianShiView()
        {
            return View();
        }

        //面试管理list
        public ActionResult LuYongManageList()
        {
            return View();
        }
               //新建面试
        public ActionResult LuYongCreate()
        {
            return View();
        }
                //查看面试
        public ActionResult LuYongView()
        {
            return View();
        }

    }
}