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
        public PartialViewResult Register()
        {
            return PartialView();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var academic = MapAcademic(model);
                AuthService.Register(academic);
                return View();
            }
            else
            {
                return View(model);
            }
            
        }

        // POST: Auth/Login
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var academic = AuthService.Auth(model.User, model.Password);

            if (academic != null)
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
            return new Academic()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Link = model.Link,
                Login = model.Login,
                Password = model.Password
            };
        }

        #endregion
    }
}