using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Modelos
{
    public class Cl_DetallesReportes
    {
        public int LaboratorioId { get; set; }
        public int CantidadReservas { get; set; }
        public double HorasReservadas { get; set; }
        public double PorcentajeUso { get; set; }
        public Cl_DetallesReportes()
        {
            LaboratorioId = 0;
            CantidadReservas = 0;
            HorasReservadas = 0.0;
            PorcentajeUso = 0.0;
        }
        public Cl_DetallesReportes(int laboratorioId, int cantidadReservas,
                           double horasReservadas, double porcentajeUso)
        {
            LaboratorioId = laboratorioId;
            CantidadReservas = cantidadReservas;
            HorasReservadas = horasReservadas;
            PorcentajeUso = porcentajeUso;
        }
    }
}
