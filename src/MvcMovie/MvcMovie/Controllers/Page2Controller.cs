using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    [RoutePrefix("Page2")]
    public class Page2Controller : Controller
    {
        public List<DepartmentVM> digui(Department dep,string gang) {
            List<DepartmentVM> list = new List<DepartmentVM>();
            if (dep.Departments1.Count != 0) {
                foreach (var item in dep.Departments1)
                {
                    list.Add(new DepartmentVM() { ID = item.ID, Dname = gang+item.Dname }); ;
                    list.AddRange(digui(item, "-" + gang));
                }
            }

            return list;

        }

        Models.Model1 db = new Model1();
        // 用户管理
        public ActionResult UsersList()
        {
            List<Roleinfo> ls = db.Roleinfoes.ToList();
            ls.Insert(0, new Roleinfo() {  Rolename = "全部" });
            ViewBag.RID = new SelectList(ls, "ID", "Rolename");
            List<DepartmentVM> vms = new List<DepartmentVM>();
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            vms.Insert(0, new DepartmentVM() {  Dname = "全部" });
            ViewBag.DID = new SelectList(vms, "ID", "Dname");
            return View(db.Users.ToList());
        }
        
        //新增用户
        public ActionResult UserCreate()
        {

            ViewBag.RID = new SelectList(db.Roleinfoes, "ID", "Rolename");
            List<DepartmentVM> vms = new List<DepartmentVM>();
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            ViewBag.DID = new SelectList(vms, "ID", "Dname");
            return View();
        }
        [HttpPost]
        public ActionResult UserCreate(User user)
        {
            user.ID = Guid.NewGuid();
            db.Users.Add(user);
            db.SaveChanges();
            
            return Redirect("../Page2/UsersList");
        }
        [HttpPost]
        public ActionResult deleteUser(string id) {

            db.Users.Remove(db.Users.FirstOrDefault(s => s.ID.ToString() == id));
            db.SaveChanges();

            return Content("12345");
        } 
        //修改用户信息
        public ActionResult UserEdit(Guid? id)
        {


            User user = db.Users.FirstOrDefault(s => s.ID == id);
            ViewBag.RID =new SelectList(db.Roleinfoes,"ID", "Rolename",user.Roleinfo.ID);

            List<Department> deps = db.Departments.Where(s=>s.ParentDepartment==null).ToList();
            List<DepartmentVM> vms = new List<DepartmentVM>();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }          
            ViewBag.DID = new SelectList(vms, "ID", "Dname",user.DID);       
            return View(user);
        }
        [HttpPost]
        public ActionResult UserEdit(User user)
        {


                
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("../../Page2/UsersList");
        }

        //查看用户信息
        public ActionResult UserView(Guid? id)
        {

            return View(db.Users.FirstOrDefault(s=>s.ID==id));
        }



        //组织结构设置
        public ActionResult OrganizationList()
        {
            return View();
        }





        //职位设置
        public ActionResult ZhiWeiList()
        {
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            List<DepartmentVM> vms = new List<DepartmentVM>();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            vms.Insert(0, new DepartmentVM() { Dname = "全部" });
            ViewBag.DID = new SelectList(vms, "ID", "Dname");
            return View();
        }
             //新增职位
        public ActionResult ZhiWeiCreate()
        {
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            List<DepartmentVM> vms = new List<DepartmentVM>();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            ViewBag.DID = new SelectList(vms, "ID", "Dname");
            ViewBag.ZWFLID = new SelectList(db.ZhiWeiFenLeis.ToList(), "ID", "ZWFLname");
            return View();
        }
        [HttpPost]
        public ActionResult ZhiWeiCreate(ZhiWei zhi)
        {
            zhi.ID = Guid.NewGuid();
            db.ZhiWeis.Add(zhi);
            db.SaveChanges();
            return Redirect("ZhiWeiList");
        }


        //修改职位信息
        public ActionResult ZhiWeiEdit(Guid? id)
        {
            ZhiWei zhi = db.ZhiWeis.FirstOrDefault(s => s.ID == id);
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            List<DepartmentVM> vms = new List<DepartmentVM>();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            ViewBag.DID = new SelectList(vms, "ID", "Dname",zhi.DID);
            ViewBag.ZWFLID = new SelectList(db.ZhiWeiFenLeis.ToList(), "ID", "ZWFLname",zhi.ZWFLID);
            return View(zhi);
        }
        [HttpPost]
        public ActionResult ZhiWeiEdit(ZhiWei zhi)
        {
            db.Entry(zhi).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("../ZhiWeiList");
        }

            //查看职位信息
        public ActionResult ZhiWeiView(Guid? id)
        {
            ZhiWei zhi = db.ZhiWeis.FirstOrDefault(s => s.ID == id);
            List<Department> deps = db.Departments.Where(s => s.ParentDepartment == null).ToList();
            List<DepartmentVM> vms = new List<DepartmentVM>();
            foreach (var item in deps)
            {
                vms.Add(new DepartmentVM() { ID = item.ID, Dname = "-" + item.Dname });
                vms.AddRange(digui(item, "--"));

            }
            ViewBag.DID = new SelectList(vms, "ID", "Dname", zhi.DID);
            ViewBag.ZWFLID = new SelectList(db.ZhiWeiFenLeis.ToList(), "ID", "ZWFLname", zhi.ZWFLID);
            return View(zhi);
        }

        public ActionResult deleteZhiWei(string id)
        {

            db.ZhiWeis.Remove(db.ZhiWeis.FirstOrDefault(s => s.ID.ToString() == id));
            db.SaveChanges();

            return Content("12345");
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