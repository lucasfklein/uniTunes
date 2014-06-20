using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;
using uniTunes.Models;
using uniTunes.Services;
using uniTunes.Services.Contracts;
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

        // GET: Auth/Login
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            if (UserContext.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            else
                return View();
        }

        // POST: Auth/Login
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (UserContext.IsAuthenticated)
                RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                var academic = AuthService.Auth(model.User, model.Password);

                if (academic != null)
                {
                    UserContext.Initialize(academic);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("wrong-pass", "Usuário ou senha incorretos.");
                    return View(model);
                }
            }
            return View(model);
        }

        // GET: Auth/Register
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult Register()
        {
            return PartialView();
        }

        // POST: Auth/Register
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var academic = MapAcademic(model);
                AuthService.Register(academic);
                TempData["message"] = "Usuário cadastrado com sucesso.";
            }
            return RedirectToAction("Login");

        }

        // POST: Auth/Logoff
        [AllowAnonymous]
        public ActionResult Logout()
        {
            UserContext.Abandon();
            return RedirectToAction("Login");
        }

        // POST: Auth/Unregister
        [HttpPost]
        public ActionResult Unregister()
        {
            AuthService.Unregister(UserContext.Current.User);
            return RedirectToAction("Logoff");
        }

        // GET: Auth/RecoverPassword
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult RecoverPassword()
        {
            return PartialView();
        }

        // GET: Auth/GetSecretQuestion
        public JsonResult GetSecretQuestion(string email)
        {
            return Json(AuthService.GetSecretQuestion(email));
        }
        
        // GET: Auth/RecoverPassword
        [AllowAnonymous]
        [HttpPost]
        public ActionResult RecoverPassword(RecoverPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                AuthService.RecoverPassword(model.Email);

                return View();
            }
            else
            {
                return View(model);
            }
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
                Password = model.Password,
                Question = model.Question,
                Answer = model.Answer
            };
        }

        #endregion
    }
}