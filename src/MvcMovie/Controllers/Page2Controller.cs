using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    [RoutePrefix("Page2")]
    public class Page2Controller : Controller
    {
        // 用户管理
        public ActionResult UsersList()
        {
            return View();
        }
            //新增用户
        public ActionResult UserCreate()
        {
            return View();
        }
           //修改用户信息
        public ActionResult UserEdit()
        {
            return View();
        }
           //查看用户信息
        public ActionResult UserView()
        {
            return View();
        }



        //组织结构设置
        public ActionResult OrganizationList()
        {
            return View();
        }





        //职位设置
        public ActionResult ZhiWeiList()
        {
            return View();
        }
             //新增职位
        public ActionResult ZhiWeiCreate()
        {
            return View();
        }
             //修改职位信息
        public ActionResult ZhiWeiEdit()
        {
            return View();
        }
             //查看职位信息
        public ActionResult ZhiWeiView()
        {
            return View();
        }


        //题库设置
        public ActionResult TiKuList()
        {
            return View();
        }
            //新增题库
        public ActionResult TiKuCreate()
        {
            return View();
        }
            //修改题库信息
        public ActionResult TiKuEdit()
        {
            return View();
        }
            //查看题库信息
        public ActionResult TiKuView()
        {
            return View();
        }




        //薪酬项目设置
        public ActionResult XinChouList()
        {
            return View();
        }
    }
}