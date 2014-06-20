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
    [AuthFilter]
    public class CreditController : Controller
    {
        private readonly ICreditService CreditService;

        public CreditController(ICreditService creditService)
        {
            this.CreditService = creditService;
        }

        // GET: Credit
        public ActionResult Buy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buy(BuyCreditViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var credit = MapCredit(model);
                    var academic = CreditService.AddCredit(credit);
                    
                    UserContext.Initialize(academic); 

                    TempData["message"] = "Créditos adquiridos com sucesso.";
                }
                catch
                {
                    TempData["message"] = "Ocorreu um erro na compra de créditos.";
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        #region View Model Mapping

        private Credit MapCredit(BuyCreditViewModel model)
        {
            return new Credit()
            {
                AcademicId = UserContext.Current.User.AcademicId,
                Status = CreditStatus.Processing,
                Type = model.CreditType,
                Value = model.Price
            };
        }

        #endregion
    }
}