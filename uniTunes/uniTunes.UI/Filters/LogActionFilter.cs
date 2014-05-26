using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using uniTunes.Data.Repositories;
using uniTunes.Models;
using uniTunes.Services;

namespace uniTunes.UI.Filters
{
    /// <summary>
    /// Filtro para logar Actions/Controller disparadas por um usuário
    /// </summary>
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            //var controllerName = routeData.Values["controller"];
            //var actionName = routeData.Values["action"];
            //var message = String.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);
            //(new Log()
            //    {
            //        Controller = controllerName.ToString(),
            //        Action = actionName.ToString(),
            //        Message = message,
            //        User = UserContext.Current.User
            //    }
            //);
        }
    }
}