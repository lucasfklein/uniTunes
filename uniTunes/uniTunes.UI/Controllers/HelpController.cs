using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uniTunes.UI.Controllers
{
    public class HelpController : Controller
    {
        // GET: Help/Support
        public PartialViewResult Support()
        {
            return PartialView();
        }

        // GET: Help/Support
        public PartialViewResult Contact()
        {
            return PartialView();
        }
    }
}