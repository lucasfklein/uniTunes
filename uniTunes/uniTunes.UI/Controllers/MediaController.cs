using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uniMedia.UI.ActionFilters;
using uniTunes.Models;
using uniTunes.Services.Contracts;
using uniTunes.UI.ViewModels;

namespace uniTunes.UI.Controllers
{
    [AuthFilter]
    public class MediaController : Controller
    {
        private readonly IMediaService MediaService;

        public MediaController(IMediaService mediaService)
        {
            this.MediaService = mediaService;
        }

        // GET: Media
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Manage()
        {
            return View();
        }

        // GET: Media/Upload
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(MediaUploadViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MemoryStream target = new MemoryStream();
                    model.File.InputStream.CopyTo(target);
                    byte[] data = target.ToArray();

                    var media = new Media()
                    {
                        Author = UserContext.Current.User,
                        CreatedOn = DateTime.Now,
                        Description = model.Description,
                        File = data,
                        Length = model.Length,
                        MediaType = model.MediaType,
                        Name = model.Name,
                        Price = model.Price
                    };

                    MediaService.Save(media);
                    TempData["message"] = "Mídia cadastrada com sucesso.";
                }
                catch
                {
                    TempData["message"] = "Ocorreu um erro ao salvar a mídia.";
                }
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: Media/Search
        public ActionResult Search()
        {
            var model = new MediaListViewModel();
            model.Medias = MediaService.GetAll();

            return View(model);
        }

        public PartialViewResult ShoppingCart()
        {
            return PartialView();
        }

        public JsonResult AddToCart(int id)
        {
            try
            {
                if (!UserContext.Current.ShoppingCart.Exists(x => x == id))
                {
                    UserContext.Current.AddMedia(id);
                    return Json("Mídia adicionada com sucesso.", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Mídia já existente no Carrinho.", JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json("Ocorreu um erro ao adicionar no carrinho.", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Favorite(int id)
        {
            return Json("Em implementação", JsonRequestBehavior.AllowGet);
        }
    }
}