using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;

namespace uniTunes.UI.Controllers
{
    [AuthFilter]
    public class ProfileController : Controller
    {
        // GET: Profile/Preferences
        public PartialViewResult Preferences()
        {
            return PartialView();
        }

        // GET: Profile/Messages
        public PartialViewResult Messages()
        {
            return PartialView();
        }

        public HttpStatusCodeResult Read()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}