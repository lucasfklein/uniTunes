using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniTunes.UI.Filters;

namespace uniTunes.UI.Controllers
{
    [LogFilter]
    public abstract class ControllerBase : Controller
    {
    }
}