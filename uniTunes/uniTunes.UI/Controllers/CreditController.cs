using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniTunes.Services;

namespace uniTunes.UI.Controllers
{
    public class CreditController : Controller
    {
        private readonly ICreditService CreditService;
                
        // GET: Credit
        public ActionResult Index()
        {
            return View();
        }
    }
}