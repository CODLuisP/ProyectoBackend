using Microsoft.AspNetCore.Mvc;
using VelSatBackend.Models;
using VelSatBackend.Data;

namespace VelSatBackend.Controllers
{
    public class AccesoController : Controller
    {
        private readonly DA_Logica _daUser;
        public AccesoController(DA_Logica daUser) { 
            _daUser = daUser;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User _user)
        {
            var user = _daUser.ValidarUser(_user.Email, _user.Password);
            if (user != null) { 
                return RedirectToAction("Index","Home");
            }
            else{
                return View();

                }
             }
        }
    }

