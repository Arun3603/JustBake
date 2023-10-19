using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminDashboard.Areas.AdminArea.Controllers
{
    public class SuperAdminController : Controller
    {
        // GET: AdminArea/SuperAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoardAdmin()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult ForgetPassword()
        {
            return View();
        }

        public ActionResult OTPValidation()
        {
            return View();
        }

        public ActionResult ResetPassword()
        {
            return View();
        }

        public ActionResult SignUpOTP()
        {
            return View();
        }

    }
}