using System.Collections;
using SRLCModelos.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCModelos.Administradoras
{
    public class LaboratorioAdministradora : IAdministradora<Laboratorio>
    {
        private static List<Laboratorio> _laboratoriosList = new List<Laboratorio>();
        private static int _idActual = 0;

        // CRUD de laboratorios
        public void Agregar(Laboratorio laboratorio)
        {
            laboratorio.IdLaboratorio = _idActual;
            _laboratoriosList.Add(laboratorio);
            _idActual += 1;
        }

        public void Remover(Laboratorio laboratorio)
        {
            bool resultado = _laboratoriosList.Remove(laboratorio);
            if (!resultado) throw new ArgumentException("La laboratorio que se intenta eliminar no existe!");
        }

        public Laboratorio? Buscar(int laboratorioId)
        {
            foreach (Laboratorio res in _laboratoriosList)
            {
                if (res.IdLaboratorio == laboratorioId) return res;
            }
            return null;
        }

        public void Actualizar(Laboratorio laboratorio)
        {
            Laboratorio? laboratorioVieja = Buscar(laboratorio.IdLaboratorio);
            if (laboratorioVieja == null) throw new NullReferenceException($"La laboratorio que se intenta actualizar no existe!");
            laboratorioVieja.CapacidadMaxima = laboratorio.CapacidadMaxima;
            laboratorioVieja.Nombre = laboratorio.Nombre;
        }

        public List<Laboratorio> Listar()
        {
            return _laboratoriosList;
        }
    }
}
