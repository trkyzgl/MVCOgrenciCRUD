using Microsoft.AspNetCore.Mvc;
using MVCProjem.Data;
using MVCProjem.Models;

namespace MVCProjem.Controllers
{



    public class YazarController : Controller
    {

        private readonly MVCProjemContext _dbcontext;

        public YazarController(MVCProjemContext config)
        {
            this._dbcontext = config;
        }

        public IActionResult Index()
        {
            List<YazarModel> list = _dbcontext.Yazarlar.OrderByDescending(q=>q.yazarno).ToList();
            ViewData["Ad"] = "Gençay Yıldız";
            TempData["Ad"] = "Gençay Yıldız";
            return View(list);//Ogrenciler();
        }

        public IActionResult Create(YazarModel yazarModel)
        {
            _dbcontext.Yazarlar.Add(yazarModel);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index", "Yazar");//Ogrenciler();
        }
        public IActionResult Yazar(YazarModel yazarModel)
        {
            List<YazarModel> list = _dbcontext.Yazarlar.ToList();
            return View(list);//Ogrenciler();
        }
        public IActionResult Delete(YazarModel yazarModel)
        {
            _dbcontext.Yazarlar.Remove(yazarModel);
            _dbcontext.SaveChanges();
            //return RedirectToAction("Yazarlar","Home");
            return RedirectToAction("Index");
        }




    }
}
