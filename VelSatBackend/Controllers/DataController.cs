﻿using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace VelSatBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        private string _connection = @"server=localhost;port=3306;database=crudasp;uid=root;password=12345678";

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
