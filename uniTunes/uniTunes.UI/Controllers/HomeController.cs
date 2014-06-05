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
                    new MenuItem("buy-credit","Comprar Créditos", "white", "/Home/Maintenance"),
                    new MenuItem("search-media","Pesquisar Mídias", "green", "/Home/Maintenance"),
                    new MenuItem("upload-media","Upload de Mídias", "blue", "/Home/Maintenance"),
                    new MenuItem("permissions-panel","Gerenciar Acessos", "yellow", "/Home/Maintenance"),
                    new MenuItem("reports","Relatórios", "pink", "/Home/Maintenance"),
                    new MenuItem("my-medias","Minhas Mídias", "white", "/Home/Maintenance"),
                    new MenuItem("config","Configurações", "red", "/Home/Maintenance")
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