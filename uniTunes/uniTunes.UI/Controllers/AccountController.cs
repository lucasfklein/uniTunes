using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;

namespace uniTunes.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Unregister
        [HttpPost]
        [AuthFilter]
        public ActionResult Unregister()
        {
            return View();
        }

        // GET: Account/RecoverPassword
        [AllowAnonymous]
        public ActionResult RecoverPassword()
        {
            return View();
        }
    }
}