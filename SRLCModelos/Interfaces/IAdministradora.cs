using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLCModelos.Interfaces
{
    // interface para obligar a las DAO a implementar el CRUD
    public interface IAdministradora<T> where T : class
    {
        void Agregar(T elemento);
        T? Buscar(int idElemento);
        void Remover(T elemento);
        List<T> Listar();
        void Actualizar(T elemento);
    }
}
