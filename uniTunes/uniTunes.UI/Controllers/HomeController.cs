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
    
    public class HomeController : Controller
    {
        // GET: Home
        [AuthFilter]
        public ActionResult Index()
        {
            //TODO: Em um futuro, persistir os Menus no banco vinculando com acessos do usuário

            var model = new HomeViewModel()
            {
                Menus = new List<MenuItem>() 
                { 
                    new MenuItem("Comprar Créditos", "white", "Index", "Credit", "buy-credit.png" ),
                    new MenuItem("Pesquisar Mídias", "green", "Maintenance", "Home", "search.png"),
                    new MenuItem("Upload de Mídias", "blue", "Maintenance", "Home", "upload.png"),
                    new MenuItem("Gerenciar Acessos", "yellow", "Maintenance", "Home", "permissions.png"),
                    new MenuItem("Relatórios", "pink", "Maintenance", "Home", "reports.png"),
                    new MenuItem("Minhas Mídias", "white", "Maintenance", "Home", "media.png"),
                    new MenuItem("Configurações", "red", "Maintenance", "Home", "configuration.png")
                }
            };
            return View(model);
        }

        // GET: Home/Maintenance
        public ActionResult Maintenance()
        {
            return View();
        }
    }
}