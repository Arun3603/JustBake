using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminDashboard.Areas.AdminArea.Controllers
{
    public class OrdersController : Controller
    {
        // GET: AdminArea/Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}