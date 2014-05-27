using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;
using uniTunes.Models;
using uniTunes.Services;
using uniTunes.UI.ViewModels;

namespace uniTunes.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService AuthService;
        
        public AuthController(IAuthService authService)
        {
            this.AuthService = authService;
        }

        // GET: Auth/Register
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            var academic = MapAcademic(model);

            AuthService.Register(academic);
            
            return View();
        }

        // POST: Auth/Login
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var academic = AuthService.Auth(0, "");

            if(academic != null)
            {
                UserContext.Initialize(academic);
                return RedirectToAction("Home", "Home");
            }
            else
            {
                return RedirectToAction("AccessDenied");
            }
        }

        // POST: Auth/Logoff
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Logoff()
        {
            UserContext.Abandon();
            return RedirectToAction("Index", "Home");
        }

        // POST: Auth/Unregister
        [HttpPost]
        public ActionResult Unregister()
        {
            AuthService.Unregister(UserContext.Current.User);

            return RedirectToAction("Index", "Home");
        }

        // GET: Auth/RecoverPassword
        [AllowAnonymous]
        [HttpGet]
        public ActionResult RecoverPassword()
        {
            return View();
        }

        // GET: Auth/RecoverPassword
        [AllowAnonymous]
        [HttpPost]
        public ActionResult RecoverPassword(RecoverPasswordViewModel model)
        {
            AuthService.RecoverPassword(string.Empty);
            return View();
        }

        #region View Model Mapping
        
        private Academic MapAcademic(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}