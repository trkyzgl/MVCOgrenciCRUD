using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MVCProjem.Models;
using MVCProjem.Data;
using Microsoft.EntityFrameworkCore;

namespace MVCProjem.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public HomeController(AppDbContext config)
        {
            this._dbcontext = config;
        }
        public IActionResult Index()
        {
            /*
            //string connectString = _dbcontext.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectString);
            //sql.Open();
            ////SqlCommand cmdName = new SqlCommand("select ad from ogrenci", sql);
            ////SqlCommand cmdSurname = new SqlCommand("select soyad from ogrenci", sql);
            ////var name = (string)cmdName.ExecuteScalar();
            ////var surname = (string)cmdSurname.ExecuteScalar();
            ////ViewData["ad"] = name;
            ////ViewData["soyad"] = surname;
            //sql.Close();
            //ViewData["Ad"] = "Gençay Yıldız";
*/
            return View();

            //return RedirectToAction("Ogrenciler", "Home");//return View();return View();
        }

     
        public IActionResult Privacy()
        {
            return View();
        }


    }
}