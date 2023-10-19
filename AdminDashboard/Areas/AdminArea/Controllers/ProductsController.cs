using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminDashboard.Areas.AdminArea.Controllers
{
    public class ProductsController : Controller
    {
        // GET: AdminArea/Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult ProductType()
        {
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }
        public ActionResult DeleteCategory()
        {
            return View();
        }
    }
}