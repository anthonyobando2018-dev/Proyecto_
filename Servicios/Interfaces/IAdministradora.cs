using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLCDAO.Interfaces
{
    // interface para obligar a las DAO a implementar el CRUD
    internal interface IAdministradora<T> where T : class
    {
        void Agregar(T elemento);
        T? Buscar(int idElemento);
        bool Remover(T elemento);
        List<T> Listar();
        void Actualizar(T elemento);
    }
}
