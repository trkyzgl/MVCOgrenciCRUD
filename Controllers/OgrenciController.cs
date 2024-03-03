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
            var lastFiveEntities = _dbcontext.Ogrenciler
            .OrderByDescending(e => e.ogrno) // Varsayılan olarak Id'ye göre sıralama, değiştirilebilir
            .Take(5)
            .ToList();
            ogrenciModels = lastFiveEntities;
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
            return View();   
            */
            return View("Index", ogrenciModels);
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
            return RedirectToAction("Index", "Ogrenci");//return View();
        }
        [HttpPost]
        public IActionResult Update(OgrenciModel ogrenciModel)
        {

            var ogrenci = _dbcontext.Ogrenciler.AsNoTracking().FirstOrDefault(q => q.ogrno == ogrenciModel.ogrno);
            if (ogrenci != null)
            {
                ogrenci.ad = ogrenciModel.ad;
                ogrenci.soyad = ogrenciModel.soyad;
                ogrenci.dtarih = ogrenciModel.dtarih;
                ogrenci.cinsiyet = ogrenciModel.cinsiyet;
                ogrenci.sinif = ogrenciModel.sinif;
                ogrenci.puan = ogrenciModel.puan;
            }
            _dbcontext.Ogrenciler.Update(ogrenci);
            _dbcontext.SaveChanges();

            var temp = _dbcontext.Ogrenciler.Where(q => q.ad.Contains(ogrenciModel.ad)).Take(10).ToList();
            #region
            //if (ogrenciModel.ogrno == null || string.IsNullOrEmpty(ogrenciModel.ad) || string.IsNullOrEmpty(ogrenciModel.soyad))
            //{
            //    return BadRequest();
            //}
            //string ad = ogrenciModel.ad;
            //string soyad = ogrenciModel.soyad;
            //int ogrno = ogrenciModel.ogrno;
            //string connectString = _dbcontext.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectString);
            //sql.Open();
            //string sorgum = "update Ogrenciler set ad='" + ad.ToString() + "', soyad='" + soyad.ToString() + "'  where ogrno =" + ogrno + "";
            //SqlCommand command = new SqlCommand(sorgum, sql);
            //command.ExecuteNonQuery();
            ////SqlDataAdapter adptr = new SqlDataAdapter(sorgum, sql);
            //sql.Close();
            #endregion
            return RedirectToAction("Index", "Ogrenci");//Ogrenciler();
        }


    }
}
