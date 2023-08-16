using Microsoft.AspNetCore.Mvc;
using VelSatBackend.Data;

namespace VelSatBackend.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly EstudianteRepository _estudianteRepository;

        public EstudianteController(EstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public IActionResult Index()
        {
            var estudiantes = _estudianteRepository.ObtenerTodos();
            return View(estudiantes);
        }
    }
}

