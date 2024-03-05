using Microsoft.AspNetCore.Mvc;
using MVCProjem.Data;
using MVCProjem.Models;

namespace MVCProjem.Controllers
{
    public class KitapController : Controller
    {
        private readonly MVCProjemContext _dbcontext;
        public KitapController(MVCProjemContext config)
        {
            this._dbcontext = config;
        }
        public IActionResult Index()
        {
            if (5>= _dbcontext.Kitaplar.Take(5).ToList().Count)
            {

         
            List<KitapModel> kitapModels = _dbcontext.Kitaplar.Take(5).ToList();
            var lastFiveEntities = _dbcontext.Kitaplar
            .OrderByDescending(e => e.kitapno) // Varsayılan olarak Id'ye göre sıralama, değiştirilebilir
            //.Take(5)  // kaç tane ğrencinin çekileceğini...
            .ToList();
            kitapModels = lastFiveEntities;
            return View("Index", kitapModels);

            }
            return View("Index");   
        }
    }
}
