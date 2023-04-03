using ConsultaNotas.Contrato;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaNotas.Areas.Estadistica.Controllers
{
    [Area("Estadistica")]
    public class EstadisticaController : Controller
    {
        private readonly IEstadistica _estadistica;

        public EstadisticaController(IEstadistica estadistica)
        {

            _estadistica = estadistica;
        }
        public IActionResult Index()
        {
            var model = _estadistica.ObtenerCalificacionPorAlumno("1942");

            return View(model);
        }
    }
}
