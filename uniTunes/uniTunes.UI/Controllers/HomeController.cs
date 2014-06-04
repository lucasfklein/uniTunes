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
        [AllowAnonymous]
        public ActionResult Index()
        {
            //TODO: Em um futuro, persistir os Menus no banco vinculando com acessos do usuário

            var model = new HomeViewModel()
            {
                Menus = new List<MenuItem>() 
                { 
                    new MenuItem("buy-credit","Comprar Créditos", "white", "#"),
                    new MenuItem("search-media","Pesquisar Mídias", "green", "#"),
                    new MenuItem("upload-media","Upload de Mídias", "blue", "#"),
                    new MenuItem("permissions-panel","Gerenciar Acessos", "yellow", "#"),
                    new MenuItem("reports","Relatórios", "pink", "#"),
                    new MenuItem("my-medias","Minhas Mídias", "white", "#"),
                    new MenuItem("config","Configurações", "red", "#")
                }
            };
            return View(model);
        }

        // GET: Home/Home
        [AuthFilter]
        public ActionResult Home()
        {
            return View();
        }
    }
}