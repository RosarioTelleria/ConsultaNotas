using ConsultaNotas.Areas.Estadistica.Controllers;
using ConsultaNotas.Contrato;
using ConsultaNotas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsultaNotas.Areas.Estadistica.DataAccess
{
    public class EstadisticaDataAccess : IEstadistica
    {
        private readonly ApplicationDbContext _dbcontex;
        
        public EstadisticaDataAccess(ApplicationDbContext dbcontex)
        {
            _dbcontex = dbcontex;
        }

        public List<Calificaciones> ObtenerCalificaciones() => _dbcontex.Calificaciones.ToList();

        public List<Calificaciones> ObtenerCalificacionPorAlumno(string codigoAlumna = "")
            => _dbcontex.Calificaciones.Where(x => x.CodigoAlumna == Convert.ToDecimal(codigoAlumna)).ToList() ?? new List<Calificaciones>();
    }
}
