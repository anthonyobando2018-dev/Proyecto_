
using SRLCModelos.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCModelos.Administradoras
{
    public class ReservasAdministradora : IAdministradora<Reserva>
    {
        private static List<Reserva> _reservasList = new List<Reserva>();
        private static int _idActual = 0;

        // CRUD de reservas
        public void Agregar(Reserva reserva)
        {
            reserva.IdReserva = _idActual;
            _reservasList.Add(reserva);
            _idActual += 1;
        }

        public void Remover(Reserva reserva)
        {
            bool resultado = _reservasList.Remove(reserva);
            if (!resultado) throw new ArgumentException("La reserva que se intenta eliminar no existe!"); 
        }

        public Reserva? Buscar(int reservaId)
        {
            foreach (Reserva res in _reservasList) {
                if (res.IdReserva == reservaId) return res;
            }
            return null;
        }

        public void Actualizar(Reserva reserva)
        {
            Reserva? reservaVieja = Buscar(reserva.IdReserva);
            if (reservaVieja == null) throw new NullReferenceException($"La reserva que se intenta actualizar no existe!");
            reservaVieja.IdLaboratorio = reserva.IdLaboratorio;
            reservaVieja.IdDocente = reserva.IdDocente;
            reservaVieja.CantidadEstudiantes = reserva.CantidadEstudiantes;
            reservaVieja.FechaReserva = reserva.FechaReserva;
        }

        public List<Reserva> Listar()
        {
            return _reservasList;
        }
    }
}
