using Atarbashi.BLL;
using Atarbashi.WebApp.App_Start;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Atarbashi.WebApp.Areas.Security.Controllers
{
    public class MenuController : Controller
    {
        // GET: Security/Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAdminSubMenu(Guid menuId)
        {
            if (SessionParameters.User == null)
            {
                return Redirect("/Security/User/Login");
            }
            List<DataStructure.Menu> result = new MenuBO().GetMenuByParentId(menuId);
        }
    }
}