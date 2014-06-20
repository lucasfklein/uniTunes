using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uniTunes.UI.Controllers
{
    public class PermissionsController : Controller
    {
        // GET: Permissions
        public ActionResult Manage()
        {
            return View();
        }
    }
}