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



        private readonly IConfiguration _configuration;

        public OgrenciController(IConfiguration config)
        {
            this._configuration = config;
        }

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
           return View(ogrenciModels);  
        }
        public IActionResult OgrenciList()
        {
            return View();
        }

    }
}
