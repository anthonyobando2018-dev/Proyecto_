using SRLCModelos.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCModelos.Administradoras
{
    public class DocenteAdministradora : IAdministradora<Docente>
    {
        private static List<Docente> _docentesList = new List<Docente>();
        private static int _idActual = 0;

        // CRUD de docentes
        public void Agregar(Docente docente)
        {
            docente.IdDocente = _idActual;
            _docentesList.Add(docente);
            _idActual += 1;
        }

        public void Remover(Docente docente)
        {
            bool resultado = _docentesList.Remove(docente);
            if (!resultado) throw new ArgumentException("La docente que se intenta eliminar no existe!");
        }

        public Docente? Buscar(int docenteId)
        {
            foreach (Docente res in _docentesList)
            {
                if (res.IdDocente == docenteId) return res;
            }
            return null;
        }

        public void Actualizar(Docente docente)
        {
            Docente? docenteViejo = Buscar(docente.IdDocente);
            if (docenteViejo == null) throw new NullReferenceException($"La docente que se intenta actualizar no existe!");
            docenteViejo.Nombre = docente.Nombre;
            docenteViejo.Especialidad = docente.Especialidad;

        }

        public List<Docente> Listar()
        {
            return _docentesList;
        }
    }
}
