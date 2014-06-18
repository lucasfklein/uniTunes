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
    [AuthFilter]
    public class CreditController : Controller
    {
        private readonly ICreditService CreditService;

        public CreditController(ICreditService creditService)
        {
            this.CreditService = creditService;
        }

        // GET: Credit
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Buy(BuyCreditViewModel model)
        {
            var credit = MapCredit(model);

            CreditService.AddCredit(credit);

            return RedirectToAction("Index", "Home", new { Message = "Créditos adquiridos com sucesso." });
        }

        #region View Model Mapping

        private Credit MapCredit(BuyCreditViewModel model)
        {
            return new Credit()
            {
                AcademicId = UserContext.Current.User.AcademicId,
                Status = CreditStatus.Processing,
                Type = model.CreditType,
                Value = model.Value
            };
        }

        #endregion
    }
}