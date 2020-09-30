using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_User_Interface_.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/AdminDashboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}