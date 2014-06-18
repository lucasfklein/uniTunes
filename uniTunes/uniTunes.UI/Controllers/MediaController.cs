using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;

namespace uniTunes.UI.Controllers
{
    [AuthFilter]
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Index()
        {
            return View();
        }

        // GET: Media/Upload
        public ActionResult Upload()
        {
            return View();
        }

        // GET: Media/Search
        public ActionResult Search()
        {
            return View();
        }

        public PartialViewResult ShoppingCart()
        {
            return PartialView();
        }
    }
}