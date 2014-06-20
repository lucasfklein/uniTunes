using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniTunes.UI.ViewModels;
using uniTunes.UI.ViewModels.Classes;

namespace uniTunes.UI.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            //TODO: Em um futuro, persistir os Menus no banco vinculando com acessos do usuário

            var model = new AdministrationViewModel()
            {
                Menus = new List<MenuItem>() 
                { 
                    new MenuItem("Gerenciar Acessos", "#3BA89B", "Manage", "Permissions", "permissions.png"),
                    new MenuItem("Gerenciar Mídias", "#3BA89B", "Manage", "Media", "permissions.png"),
                    new MenuItem("Gerenciar Cadastros", "#3BA89B", "Manage", "Academic", "permissions.png")
                }
            };
            return View(model);
        }
    }
}