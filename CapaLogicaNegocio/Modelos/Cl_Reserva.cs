using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Modelos
{
    public class Cl_Reserva
    {
        public int Id { get; set; }
        public string Docente { get; set; }
        public string Asignatura { get; set; }
        public int LaboratorioId { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CantEstudiantes { get; set; }

        public Cl_Reserva()
        {
            Id = 0;
            Docente = string.Empty;
            Asignatura = string.Empty;
            LaboratorioId = 0;
            Fecha = DateTime.MinValue;
            HoraInicio = TimeSpan.Zero;
            HoraFin = TimeSpan.Zero;
            CantEstudiantes = 0;
            Estado = "Activa";
        }

        public Cl_Reserva(int id, string docente, string asignatura,
                          int labId, DateTime fecha,
                          TimeSpan horaInicio, TimeSpan horaFin,
                          int cantEstudiantes)
        {
            Id = id;
            Docente = docente;
            Asignatura = asignatura;
            LaboratorioId = labId;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            CantEstudiantes = cantEstudiantes;
        }

        public string ToString()
        {
            return $"Reserva ID: {Id}, Docente: {Docente}, Asignatura: {Asignatura}, " +
                   $"Laboratorio: {LaboratorioId}, Fecha: {Fecha.ToShortDateString()}, " +
                   $"Hora Inicio: {HoraInicio}, Hora Fin: {HoraFin}, " +
                   $"Cantidad Estudiantes: {CantEstudiantes}";
        }
    }
}

