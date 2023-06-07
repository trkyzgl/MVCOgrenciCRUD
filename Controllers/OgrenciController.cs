using Microsoft.AspNetCore.Mvc;
using MVCProjem.Models;
using System.Data;
using System.Data.SqlClient;

namespace MVCProjem.Controllers
{
    public class OgrenciController : Controller
    {

        private readonly IConfiguration _configuration;

        public OgrenciController(IConfiguration config)
        {
            this._configuration = config;
        }

        public IActionResult Index()
        {
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
        }
        public IActionResult OgrenciList()
        {
            return View();
        }

    }
}
