using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uniTunes.UI.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile/Preferences
        public PartialViewResult Preferences()
        {
            return PartialView();
        }

    }
}