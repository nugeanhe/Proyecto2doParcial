using APPreservaLabUI.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPreservaLabUI.LogicaNegocio
{
    public class Cl_LN_Reserva
    {
        public List<Cl_Reserva> lista_reservas = new List<Cl_Reserva>();
        // Obtener siguiente ID
        public int GetNextId()
        {
            if (lista_reservas.Count == 0)
                return 1;
            return lista_reservas[lista_reservas.Count - 1].Id + 1;
        }
        public int GetIndiceLista(int id)
        {
            for (int i = 0; i < lista_reservas.Count; i++)
            {
                if (lista_reservas[i].Id == id)
                    return i;
            }
            return -1;
        }
        public List<Cl_Reserva> GetLista()
        {
            return lista_reservas;
        }

        public List<Cl_Reserva> GetReservasEnIntervalo(DateTime fechaInicio, DateTime fechaFin)
        {
            return lista_reservas.Where(reserva => reserva.Fecha.Date >= fechaInicio.Date && reserva.Fecha.Date <= fechaFin.Date).ToList();
        }

        public List<Cl_Reserva> GetReservasPorLaboratorio(int laboratorioId)
        {
            return lista_reservas.Where(reserva => reserva.LaboratorioId == laboratorioId).ToList();
        }

        public double ObtenerHorasTotales(List<Cl_Reserva> reservas)
        {
            double totalHoras = 0;
            foreach (var reserva in reservas)
            {
                totalHoras += (int)(reserva.HoraFin - reserva.HoraInicio).TotalHours;
            }
            return Math.Round(totalHoras, 2);
        }

        public void CrearReserva(Cl_Reserva res)
        {
            try
            {
                lista_reservas.Add(res);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void ModificarReserva(Cl_Reserva res)
        {
            try
            {
                int indice = GetIndiceLista(res.Id);
                if (indice == -1)
                    throw new ArgumentException("La reserva no existe");
                else
                    lista_reservas[indice] = res;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void EliminarReserva(int id)
        {
            try
            {
                int indice = GetIndiceLista(id);
                if (indice == -1)
                    throw new ArgumentException("La reserva no existe");
                else
                    lista_reservas.RemoveAt(indice);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        // validar fechas y horas de reserva
        public bool ValidarDisponibilidad(Cl_Reserva nueva_reserva)
        {
            foreach (var reserva in lista_reservas)
            {
                if (reserva.Id == nueva_reserva.Id) return true;
                if (reserva.LaboratorioId == nueva_reserva.LaboratorioId &&
                    reserva.Fecha.Date == nueva_reserva.Fecha.Date)
                {
                    if ((nueva_reserva.HoraInicio < reserva.HoraFin) && (nueva_reserva.HoraFin > reserva.HoraInicio))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // validar que el laboratorio tenga capacidad suficiente
        public bool ValidarCapacidad(Cl_Reserva nueva_reserva, int capacidad_laboratorio)
        {
            return nueva_reserva.CantEstudiantes <= capacidad_laboratorio;
        }

    }
}
