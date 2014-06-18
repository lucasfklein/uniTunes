using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
using System.Security;
using uniTunes.UI;

namespace uniMedia.UI.ActionFilters
{
    /// <summary>
    /// Filtro para validar se o usuário está autenticado.
    /// Deve ser utilizado nas Actions que necessitam de autorização
    /// </summary>
    public class AuthFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;

            Controller control = filterContext.Controller as Controller;

            if (control != null)
            {
                if (!UserContext.IsAuthenticated)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Auth" }, { "action", "Login" } });
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}