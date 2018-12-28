using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class HelperController : Controller
    {
        public List<DepartmentVM> digui(Department dep, string gang)
        {

            
            List<DepartmentVM> list = new List<DepartmentVM>();
            if (dep.Departments1.Count != 0)
            {
                foreach (var item in dep.Departments1)
                {
                    list.Add(new DepartmentVM() { ID = item.ID, Dname = gang + item.Dname }); ;
                    list.AddRange(digui(item, "-" + gang));
                }
            }

            return list;

        }
        Models.Model1 db = new Model1();
        // GET: Helper
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult GetZhiWei() {

            List<ZhiWei> list = db.ZhiWeis.ToList();

            List<ZhiWeiViewModel> vms = new List<ZhiWeiViewModel>();
            foreach (var item in list)
            {

                vms.Add(new ZhiWeiViewModel()
                {
                    ID = item.ID,
                    Zname = item.ZName,
                    LID = item.ZWFLID,
                    BID = item.DID,
                    Bname = item.Department.Dname,
                    Lname = item.ZhiWeiFenLei.ZWFLName,
                    edithtml= "/Page2/ZhiWeiEdit/"+item.ID,
                    viewhtml= "/Page2/ZhiWeiView/" + item.ID

                });
            }
            return Json(vms, JsonRequestBehavior.AllowGet);
        }
    }
}