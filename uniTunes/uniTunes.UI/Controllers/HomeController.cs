using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;
using uniTunes.Models.Models;
using uniTunes.Services;

namespace uniTunes.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        
        // POST: Home/Login
        [HttpPost]
        public ActionResult Login()
        {
            UserContext.Initialize(new Academic());

            return null;
        }

        // GET: Home/Home
        [AuthFilter]
        public ActionResult Home()
        {
            return View();
        }
    }
}