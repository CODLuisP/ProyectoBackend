using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace VelSatBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {


        //[HttpGet]
        //public IActionResult Get() {

           // IEnumerable<Models.Estudiante> lst = null;

           // using(var db = new MySqlConnection(_connection) )
          //  {
            //    var sql = "select * from estudiantes";
               // lst = db.Query<Models.Estudiante>(sql);
           // }

            //return Ok(lst);
          
        //}
    }
}
