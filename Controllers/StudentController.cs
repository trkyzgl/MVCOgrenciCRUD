using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using MVCProjem.Data;
using MVCProjem.Models;
using System.Data;
using System.Data.SqlClient;
namespace MVCProjem.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public StudentController(AppDbContext config)
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
            List<Student> studentModels = _dbcontext.Students.Take(5).ToList();
            var lastFiveEntities = _dbcontext.Students
            .OrderByDescending(e => e.Id) // Varsayılan olarak Id'ye göre sıralama, değiştirilebilir
            //.Take(5)  // kaç tane ğrencinin çekileceğini...
            .ToList();

            studentModels = lastFiveEntities;    
            /*
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sorgu = "select top 10 * from student";
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
            return View("Index", studentModels);
        }
        public IActionResult OgrenciList()
        {
            return View();
        }
        public IActionResult Create(Student studentModel)
        {
            _dbcontext.Students.Add(studentModel);
            _dbcontext.SaveChanges();
            //klasik yöntem
            //string t = Convert.ToDateTime(studentModel.dtarih).ToString("dd.MM.yyyy");
            //string connectionString = _configuration.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectionString);
            //sql.Open();
            //string sorgu = "insert into  Students(ad,soyad,dtarih,cinsiyet,sinif,puan) values(" +
            //"'"+studentModel.ad.ToString()+ "','" + studentModel.soyad.ToString() + "' ,'" + studentModel.dtarih+ "'  , '" + studentModel.cinsiyet.ToString() + "', '" + studentModel.sinif.ToString()+ 
            //"'," +studentModel.puan+")";
            // SqlCommand cmd = new SqlCommand(sorgu,sql);
            // cmd.ExecuteNonQuery();
            // sql.Close();
            //SqlConnection sql = new SqlConnection();
            //AppDbContext context = new AppDbContext();
            //context.Students.Add(studentModel);
            //context.SaveChanges();
            return RedirectToAction("Index", "Student");//return View();
        }
        int count;
        public IActionResult Search(Student studentModel)
        {
            List<Student> list = _dbcontext.Students.Where(x => (x.Name + " " + x.Surname).Contains(studentModel.Name)).ToList();
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
        public IActionResult Remove(int id)
        {

            var student = _dbcontext.Students.FirstOrDefault(p => p.Id == id);

            _dbcontext.Students.Remove(student);
            _dbcontext.SaveChanges();
            //string connectionString = _configuration.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectionString);
            //sql.Open();
            //string sorgu = "delete from Students where ogrno = "+studentModel.ogrno+"";
            //SqlCommand cmd = new SqlCommand(sorgu,sql);
            //cmd.ExecuteNonQuery();
            //sql.Close();
            return RedirectToAction("Index", "Student");//return View();
        }


        public IActionResult Update(int id)
        {

            //var student = _dbcontext.Students.Where(q => q.Id.Contains(Students.Id)).Take(1);
            var student = _dbcontext.Students.FirstOrDefault(p => p.Id == id);

            return View(); //Students();
        }
        [HttpPost]
        public IActionResult Update(Student studentModel)
        {

            var student = _dbcontext.Students.AsNoTracking().FirstOrDefault(q => q.Id == studentModel.Id);
            if (student != null)
            {
                student.Name = studentModel.Name;
                student.Surname = studentModel.Surname;
            }
            _dbcontext.Students.Update(student);
            _dbcontext.SaveChanges();

            var temp = _dbcontext.Students.Where(q => q.Name.Contains(studentModel.Name)).Take(10).ToList();
            #region
            //if (studentModel.ogrno == null || string.IsNullOrEmpty(studentModel.ad) || string.IsNullOrEmpty(studentModel.soyad))
            //{
            //    return BadRequest();
            //}
            //string ad = studentModel.ad;
            //string soyad = studentModel.soyad;
            //int ogrno = studentModel.ogrno;
            //string connectString = _dbcontext.GetConnectionString("DefaultConnection");
            //SqlConnection sql = new SqlConnection(connectString);
            //sql.Open();
            //string sorgum = "update Students set ad='" + ad.ToString() + "', soyad='" + soyad.ToString() + "'  where ogrno =" + ogrno + "";
            //SqlCommand command = new SqlCommand(sorgum, sql);
            //command.ExecuteNonQuery();
            ////SqlDataAdapter adptr = new SqlDataAdapter(sorgum, sql);
            //sql.Close();
            #endregion

            return RedirectToAction("Index", "Student");
            //return View(); //Students();   // revize edilecek
        }






    }
}
