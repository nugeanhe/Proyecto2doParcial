using CapaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
    public class Cl_LN_Reportes
    {
        public List<Cl_DetallesReportes> detalle_reporte = new List<Cl_DetallesReportes>();

        public List<Cl_DetallesReportes> GenerarReporteReservas(List<Cl_Reserva> reservas, double horasTotalesDisponiblesPorLab)
        {
            var reporte = reservas
                .GroupBy(r => r.LaboratorioId)
                .Select(g =>
                {
                    double horasReservadas = g.Sum(r => (r.HoraFin - r.HoraInicio).TotalHours);
                    int cantidadReservas = g.Count();

                    return new Cl_DetallesReportes
                    {
                        LaboratorioId = g.Key,
                        CantidadReservas = cantidadReservas,
                        HorasReservadas = Math.Round(horasReservadas, 2),
                        PorcentajeUso = Math.Round(horasTotalesDisponiblesPorLab > 0
                            ? (horasReservadas / horasTotalesDisponiblesPorLab) * 100
                            : 0, 2)
                    };
                })
                .ToList();

            return reporte;
        }
    }
}
