
using SRLCDAO.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCDAO
{
    public class ReservasAdministradora : IAdministradora<Reserva>
    {
        private static List<Reserva> _reservasList = new List<Reserva>();
        // CRUD de reservas
        public void Agregar(Reserva reserva)
        {
            _reservasList.Add(reserva);
        }

        public bool Remover(Reserva reserva)
        {
            return _reservasList.Remove(reserva);
        }

        public Reserva? Buscar(int reservaId)
        {
            foreach (var reserva in _reservasList)
            {
                if (reserva.IdReserva == reservaId)
                {
                    return reserva;
                }
            }
            return null;
        }

        public void Actualizar(Reserva reserva)
        {
            var reservaViejo = Buscar(reserva.IdReserva);
            if (reservaViejo != null)
            {
                reservaViejo = reserva;
            }
        }

        public List<Reserva> Listar()
        {
            return _reservasList;
        }



    }
}
