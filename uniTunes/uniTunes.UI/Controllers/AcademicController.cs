using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uniTunes.UI.Controllers
{
    public class AcademicController : Controller
    {
        // GET: Academic
        public ActionResult Manage()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Delete(int AcademicId)
        {
            return Json("Deletado com sucesso.");
        }
    }
}