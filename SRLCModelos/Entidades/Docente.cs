namespace SRLCModelos.Entidades
{
    public class Docente
    {
        // Propiedades de la clase Docente
        public int IdDocente { get; set; }
        public string Nombre { get; set; } = "No especificado";
        public string Especialidad { get; set; } = "No especificado";

        // Contructor parametrizado 
        public Docente(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
        }

        // Cadena con los datos del docente
        public override string ToString()
        {
            return $"{IdDocente};{Nombre};{Especialidad}";
        }
    }
}
