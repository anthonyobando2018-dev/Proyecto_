using SRLCDAO.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCDAO
{
    public class DocenteAdministradora : IAdministradora<Docente>
    {
        private static List<Docente> _docentesList = new List<Docente>();

        // CRUD de docentes
        public void Agregar(Docente docente)
        {
            _docentesList.Add(docente);
        }

        public bool Remover(Docente docente)
        {
            return _docentesList.Remove(docente);
        }

        public Docente? Buscar(int docenteId)
        {
            foreach (var docente in _docentesList)
            {
                if (docente.IdDocente == docenteId)
                {
                    return docente;
                }
            }
            return null;
        }

        public void Actualizar(Docente docente)
        {
            var docenteViejo = Buscar(docente.IdDocente);
            if (docenteViejo != null)
            {
                docenteViejo = docente;
            }
        }

        public List<Docente> Listar()
        {
            return _docentesList;
        }
    }
}
