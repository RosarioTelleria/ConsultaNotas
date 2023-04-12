using ConsultaNotas.Data;
using ConsultaNotas.Models;

namespace ConsultaNotas.Contrato
{
    public interface IEstadistica
    {
        public List<Calificaciones> ObtenerCalificaciones();
        public List<Calificaciones> ObtenerCalificacionPorAlumno(string codigoAlumna);
    }
}
