using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;
using uniTunes.Models;
using uniTunes.Services;
using uniTunes.UI.ViewModels;
using uniTunes.UI.ViewModels.Classes;

namespace uniTunes.UI.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //TODO: Em um futuro, persistir os Menus no banco vinculando com acessos do usuário

            var model = new HomeViewModel()
            {
                Menus = new List<MenuItem>() 
                { 
                    new MenuItem("Comprar Créditos", "#3BA89B", "Buy", "Credit", "buy-credit.png" ),
                    new MenuItem("Pesquisar Mídias", "#3BA89B", "Search", "Media", "search.png"),
                    new MenuItem("Upload de Mídias", "#3BA89B", "Upload", "Media", "upload.png"),
                    new MenuItem("Relatórios", "#3BA89B", "Index", "Reports", "reports.png"),
                    new MenuItem("Minhas Mídias", "#3BA89B", "Maintenance", "Home", "media.png"),
                    new MenuItem("Configurações", "#3BA89B", "Maintenance", "Home", "configuration.png")
                }
            };

            return View(model);
        }

        // GET: Home/Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        // GET: Home/Maintenance
        public ActionResult Maintenance()
        {
            return View();
        }
    }
}