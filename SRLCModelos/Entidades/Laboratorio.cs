namespace SRLCModelos.Entidades
{
    public class Laboratorio
    {
        // Propiedades de la clase Laboratorio
        public int IdLaboratorio { get; set; }
        public string Nombre { get; set; } = "No especificado";
        public int CapacidadMaxima { get; set; }
        public bool EstaActivo { get; set; } = true;

        // Constructor parametrizado
        public Laboratorio(string nombre, int capacidadMaxima)
        {
            Nombre = nombre;
            CapacidadMaxima = capacidadMaxima;
        }

        // Cadena con los datos relevantes del laboratorio
        public override string ToString()
        {
            return $"{IdLaboratorio};{Nombre};{CapacidadMaxima};{EstaActivo}";
        }
    }
}
