using System.Collections;
using SRLCDAO.Interfaces;
using SRLCModelos.Entidades;

namespace SRLCDAO
{
    public class LaboratorioAdministradora : IAdministradora<Laboratorio>

    {
        // Coleccion con los objetos Laboratorios - Solo accesible dentro de esta clase
        private static List<Laboratorio> _LaboratorioList = new List<Laboratorio>();
        
        // CRUD de laboratorio
        public void Agregar(Laboratorio lab)
        {
            _LaboratorioList.Add(lab);
        }

        public bool Remover (Laboratorio lab)
        {
            return _LaboratorioList.Remove(lab);
        }

        public Laboratorio? Buscar(int labId)
        {
            foreach (var lab in _LaboratorioList)
            {
                if (lab.IdLaboratorio == labId)
                {
                    return lab;
                }
            }
            return null;
        }

        public void Actualizar(Laboratorio lab)   
        {
            var labViejo = Buscar(lab.IdLaboratorio);
            if (labViejo != null)
            {
                labViejo = lab;
            }
        }

        public List<Laboratorio> Listar() 
        {
            return _LaboratorioList;
        }


    }
}
