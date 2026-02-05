using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRLCModelos.Entidades;
using SRLCModelos.Interfaces;
using SRLCModelos.Utilidades;

namespace SRLCModelos.Servicios
{
    public static class LaboratoriosServicio
    {
        private static List<Laboratorio> _listaLaboratorios = new List<Laboratorio>();
        private static int _idActual = 0;

        public static void AgregarLaboratorio(string nombre, int capacidadMaxima)
        {
            ValidarLaboratorioDatos(nombre, capacidadMaxima);
            Laboratorio nuevoLaboratorio = new Laboratorio(nombre.Trim(), capacidadMaxima);
            nuevoLaboratorio.IdLaboratorio = _idActual;
            _listaLaboratorios.Add(nuevoLaboratorio);
            _idActual++;
        }

        public static void EliminarLaboratorio(int idLaboratorio)
        {
            Laboratorio LaboratorioEncontrado = BuscarLaboratorio(idLaboratorio);
            _listaLaboratorios.Remove(LaboratorioEncontrado);
        }

        public static List<Laboratorio> ListarLaboratorios()
        {
            return _listaLaboratorios;
        }

        public static void ActualizarDatosLaboratorio(int idLaboratorio, string nombre, int capacidadMaxima)
        {
            ValidarLaboratorioDatos(nombre, capacidadMaxima);
            Laboratorio LaboratorioEncontrado = BuscarLaboratorio(idLaboratorio);
            // si el Laboratorio se encuentra, se actualizan sus datos
            LaboratorioEncontrado.Nombre = nombre.Trim();
            LaboratorioEncontrado.CapacidadMaxima = capacidadMaxima;
        }

        public static Laboratorio BuscarLaboratorio(int idLaboratorio)
        {
            if (idLaboratorio < 0)
                throw new ArgumentException("Valores negativos para Id no validos!");
            Laboratorio? LaboratorioEncontrado = _listaLaboratorios.Find((Laboratorio) => Laboratorio.IdLaboratorio == idLaboratorio);
            if (LaboratorioEncontrado == null)
                throw new NullReferenceException($"El Laboratorio de id: {idLaboratorio} no existe!");
            return LaboratorioEncontrado;
        }
        // metodo para validar los datos
        private static void ValidarLaboratorioDatos(string nombre, int capacidadMaxima)
        {
            Validaciones.ValidarCampoTexto(nombre, "nombre", 3, 75);
            Validaciones.ValidarRangoNumerico(capacidadMaxima, "especialidad", 10, 50);
        }

        public static int GetIdActual()
        {
            return _idActual;
        }
    }
}
