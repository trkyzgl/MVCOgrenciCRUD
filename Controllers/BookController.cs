using Microsoft.AspNetCore.Mvc;
using MVCProjem.Data;
using MVCProjem.Models;

namespace MVCProjem.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public BookController(AppDbContext config)
        {
            this._dbcontext = config;
        }
        public IActionResult Index()
        {
            if (5>= _dbcontext.Books.Take(5).ToList().Count)
            {

            List<Book> kitapModels = _dbcontext.Books.Take(5).ToList();
            var lastFiveEntities = _dbcontext.Books
            .OrderByDescending(e => e.Id) // Varsayılan olarak Id'ye göre sıralama, değiştirilebilir
            //.Take(5)  // kaç tane ğrencinin çekileceğini...
            .ToList();
            kitapModels = lastFiveEntities;
            return View("Index", kitapModels);
            }
            return View("Index");   
        }


    }
}
