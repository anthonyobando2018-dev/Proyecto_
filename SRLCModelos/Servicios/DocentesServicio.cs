using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRLCModelos.Administradoras;
using SRLCModelos.Interfaces;
using SRLCModelos.Entidades;
using SRLCModelos.Utilidades;

namespace SRLCModelos.Servicios
{
    // El servicio de docentes se encargará de implementar la logica de negocio para este modelo
    public static class DocentesServicio
    {
        private static List<Docente> _listaDocentes = new List<Docente>();
        private static int _idActual = 0;

        public static void AgregarDocente(string nombre, string especialidad)
        {
            ValidarDocenteDatos(nombre, especialidad);
            Docente nuevoDocente = new Docente(nombre.Trim(), especialidad.Trim());
            nuevoDocente.IdDocente = _idActual;
            _listaDocentes.Add(nuevoDocente);
            _idActual++;
        }

        public static void EliminarDocente(int idDocente)
        {
            Docente docenteEncontrado = BuscarDocente(idDocente);
            _listaDocentes.Remove(docenteEncontrado);
        }

        public static List<Docente> ListarDocentes()
        {
            return _listaDocentes;
        }

        public static void ActualizarDatosDocente(int idDocente, string nombre, string especialidad)
        {
            ValidarDocenteDatos(nombre, especialidad);
            Docente docenteEncontrado = BuscarDocente(idDocente);
            // si el docente se encuentra, se actualizan sus datos
            docenteEncontrado.Nombre = nombre.Trim();
            docenteEncontrado.Especialidad = especialidad.Trim();
        }

        public static Docente BuscarDocente(int idDocente)
        {
            if (idDocente < 0) 
                throw new ArgumentException("Valores negativos para Id no validos!");
            Docente? docenteEncontrado = _listaDocentes.Find((docente) => docente.IdDocente == idDocente);
            if (docenteEncontrado == null)
                throw new NullReferenceException($"El docente de id: {idDocente} no existe!");
            return docenteEncontrado;
        }
        // metodo para validar los datos
        private static void ValidarDocenteDatos(string nombre, string especialidad)
        {
            Validaciones.ValidarCampoTexto(nombre, "nombre", 3, 75);
            Validaciones.ValidarCampoTexto(especialidad, "especialidad", 10, 75);
        }
        
        public static int GetIdActual()
        {
            return _idActual;
        }
    }
}
