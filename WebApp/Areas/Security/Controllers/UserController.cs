﻿using Atarbashi.BLL;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Atarbashi.WebApp.Areas.Security.Controllers
{
    public class UserController : Controller
    {
        // GET: Security/User
        public ActionResult Index()
        {
            List<DataStructure.User> users = new UserBO().Where(x => x.Username != "host");
            return View(users);
        }
    }
}