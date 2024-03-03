using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProjem.Data;
using MVCProjem.Models;
using System.Data;
using System.Data.SqlClient;

namespace MVCProjem.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly MVCProjemContext _dbcontext;
        public OgrenciController(MVCProjemContext config)
        {
            this._dbcontext = config;
        }
        //private readonly IConfiguration _configuration;
        /*
         public OgrenciController(IConfiguration config)
         {
             this._configuration = config;
         }
        */
        public IActionResult Index()
        {
            List<OgrenciModel> ogrenciModels = _dbcontext.Ogrenciler.Take(5).ToList();
            /*
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sorgu = "select top 10 * from ogrenci";
            SqlCommand command = new SqlCommand(sorgu, sqlConnection);
            command.ExecuteNonQuery();
            List<OgrenciModel> list = new List<OgrenciModel>();
            //DataTable dt = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, sqlConnection);
            DataTable dt = new DataTable(sorgu);
            adptr.Fill(dt);
            list.Add(new OgrenciModel() { });
            sqlConnection.Close(); 
            */  
            // return View();
            return View("Index",ogrenciModels);
        }
        public IActionResult OgrenciList()
        {
            return View();
        }
        public IActionResult Create(OgrenciModel ogrenciModel)
        {
            _dbcontext.Ogrenciler.Add(ogrenciModel);
            _dbcontext.SaveChanges();
            //klasik yöntem
            //string t = Convert.ToDateTime(ogrenciModel.dtarih).ToString("dd.MM.yyyy");
            //string connectionString = _configuration.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectionString);
            //sql.Open();
            //string sorgu = "insert into  Ogrenciler(ad,soyad,dtarih,cinsiyet,sinif,puan) values(" +
            //"'"+ogrenciModel.ad.ToString()+ "','" + ogrenciModel.soyad.ToString() + "' ,'" + ogrenciModel.dtarih+ "'  , '" + ogrenciModel.cinsiyet.ToString() + "', '" + ogrenciModel.sinif.ToString()+ 
            //"'," +ogrenciModel.puan+")";
            // SqlCommand cmd = new SqlCommand(sorgu,sql);
            // cmd.ExecuteNonQuery();
            // sql.Close();
            //SqlConnection sql = new SqlConnection();
            //MVCProjemContext context = new MVCProjemContext();
            //context.Ogrenciler.Add(ogrenciModel);
            //context.SaveChanges();
            return RedirectToAction("Index", "Ogrenci");//return View();
        }
        int count;
        public IActionResult Search(OgrenciModel ogrenciModel)
        {
            List<OgrenciModel> list = _dbcontext.Ogrenciler.Where(x => (x.ad + " " + x.soyad).Contains(ogrenciModel.ad)).ToList();
            count = list.Count();
            /*
            ViewData["say"] = count;
            ViewBag.FirstName = "Yusuf";
            ViewBag.LastName = "SEZER";
            ViewData["Ad"] = "Gençay Yıldız";
            */
            TempData["Ad"] = "Gençay Yıldız";
            TempData["say"] = count;

            return RedirectToAction("Index", "Ogrenci");
        }
        public IActionResult Delete(OgrenciModel ogrenciModel)
        {
            _dbcontext.Ogrenciler.Remove(ogrenciModel);
            _dbcontext.SaveChanges();
            //string connectionString = _configuration.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectionString);
            //sql.Open();
            //string sorgu = "delete from Ogrenciler where ogrno = "+ogrenciModel.ogrno+"";
            //SqlCommand cmd = new SqlCommand(sorgu,sql);
            //cmd.ExecuteNonQuery();
            //sql.Close();
            return RedirectToAction("Ogrenciler", "Ogrenci");//return View();
        }


    }
}
