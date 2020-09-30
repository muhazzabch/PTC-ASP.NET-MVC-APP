using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_User_Interface_.Areas.Security.Controllers
{
    public class RegisterUserController : Controller
    {
        // GET: Security/RegisterUser
        public ActionResult Register()
        {
            return View();
        }
    }
}