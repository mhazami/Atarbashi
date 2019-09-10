using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atarbashi.WebApp.Areas.Security.Controllers
{
    public class UserController : Controller
    {
        // GET: Security/User
        public ActionResult Index()
        {
            return View();
        }
    }
}