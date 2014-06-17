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
                    new MenuItem("Comprar Créditos", "white", "/Home/Maintenance", "buy-credit.png" ),
                    new MenuItem("Pesquisar Mídias", "green", "/Home/Maintenance", "search.png"),
                    new MenuItem("Upload de Mídias", "blue", "/Home/Maintenance", "upload.png"),
                    new MenuItem("Gerenciar Acessos", "yellow", "/Home/Maintenance", "permissions.png"),
                    new MenuItem("Relatórios", "pink", "/Home/Maintenance", "reports.png"),
                    new MenuItem("Minhas Mídias", "white", "/Home/Maintenance", "media.png"),
                    new MenuItem("Configurações", "red", "/Home/Maintenance", "configuration.png")
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