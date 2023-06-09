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
            List<YazarModel> list = _dbcontext.Yazarlar.ToList();
            return View(list);//Ogrenciler();

        }

        public IActionResult Create(YazarModel yazarModel)
        {
            _dbcontext.Yazarlar.Add(yazarModel);
            _dbcontext.SaveChanges();

            return RedirectToAction("Ogrenciler", "Home");//Ogrenciler();
        }

        public IActionResult Yazar(YazarModel yazarModel)
        {
            List<YazarModel> list = _dbcontext.Yazarlar.ToList();
            return View(list);//Ogrenciler();
        }



    }
}
