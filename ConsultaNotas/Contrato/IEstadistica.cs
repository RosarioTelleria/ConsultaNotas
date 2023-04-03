using ConsultaNotas.Data;

namespace ConsultaNotas.Contrato
{
    public interface IEstadistica
    {
        public List<Calificaciones> ObtenerCalificaciones();
        public List<Calificaciones> ObtenerCalificacionPorAlumno(string codigoAlumna);
    }
}
