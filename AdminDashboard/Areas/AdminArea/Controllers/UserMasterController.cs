using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminDashboard.Areas.AdminArea.Controllers
{
    public class UserMasterController : Controller
    {
        // GET: AdminArea/UserMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }
        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult CreateCusCategory()
        {
            return View();
        }
    }
}