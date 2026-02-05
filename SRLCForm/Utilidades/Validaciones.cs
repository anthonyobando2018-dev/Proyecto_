using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLCProyectoPOE.Utilidades
{
    // en esta clase definiré metodos para validar valores entrantes
    // Definido como una clase aparte para poder reutilizarse en cualquier parte del proyecto
    public static class Validaciones
    {
        public static void ValidarCampoTexto(string texto, string campoNombre, int longitudMinima, int longitudMaxima)
        {
            int longitud = texto.Trim().Length;

            if (longitud == 0) throw new ArgumentException($"Valor de {campoNombre} no valido!");
            if (longitud < longitudMinima) throw new ArgumentException($"El valor de {campoNombre} debe tener como minimo {longitudMinima} caracteres!");
            if (longitud > longitudMaxima) throw new ArgumentException($"El valor de {campoNombre} no debe superar los {longitudMaxima} caracteres!");
        }

        public static void ValidarRangoNumerico(int numero, string campoNombre, int valorMinimo, int valorMaximo)
        {
            if (numero < valorMinimo) throw new ArgumentException($"El valor de {campoNombre} debe ser como minimo {valorMinimo}!");
            if (numero > valorMaximo) throw new ArgumentException($"El valor de {campoNombre} tiene que ser mayor que {valorMaximo}!");
        }

        public static void ValidarCampoNumerico(string valor, string campoNombre)
        {
            bool numeroValido = long.TryParse(valor, out long resultado);
            if (!numeroValido) throw new ArgumentException($"El campo {campoNombre} solo puede contener valores numericos.");
        }
    }
}
