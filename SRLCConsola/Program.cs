using SRLCModelos.Interfaces;
using SRLCModelos.Entidades;
using SRLCModelos.Servicios;
using System.Collections;
using Microsoft.VisualBasic;
using SRLCModelos.Administradoras;


namespace SRLCConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeOnly tiempo1 = new TimeOnly(13, 0);
            TimeOnly tiempo2 = tiempo1.AddHours(2);
            Console.WriteLine($"Hora inicio: {tiempo1}, hora fin: {tiempo2}");

            int horaInicio = 8, horaFinal = 12, duracion = 60;

            Console.WriteLine("Horas de inicio seleccionable: ");
            var horariosInicio = GenerarHorarios(horaInicio, horaFinal, duracion);
            horariosInicio.ForEach(horario => Console.WriteLine(horario.HoraInicio));

            Console.WriteLine("Horas de fin seleccionable: ");
            horariosInicio.ForEach(horario => Console.WriteLine(horario.HoraFin));

        }

        /*
        public static void labs ()
        {
            var adDocente = new DocenteAdministradora();
            var adLaboratorio = new LaboratorioAdministradora();
            var adReservas = new ReservasAdministradora();
            cargarLaboratorios(new LaboratoriosServicio(adLaboratorio));
            cargarDocentes(new DocentesServicio(adDocente));
            /*
            Console.WriteLine("Hello, World!");
            // var labServicio = new ();
            var docenteServicio = new DocenteAdministradora();

            

            labServicio.Listar().ForEach((lab) => Console.WriteLine(lab.ToString()));
            docenteServicio.Listar().ForEach((docente) => Console.WriteLine(docente.ToString()));

            var reserva = new Reserva(1, 2, 3, 20, new DateOnly(2025, 11, 21), new TimeOnly(10, 0, 0), new TimeOnly(10, 30, 0));
            Console.WriteLine();
            Console.WriteLine("Fin del programa");
            
            var horaInicio = new TimeOnly(10, 0); 
            var horaFin = new TimeOnly(10, 30);
            ValidarFrajaHoraria(horaFin, horaInicio);
            
            int count = 0;
            var serviceReservas = new ReservasServicio(adReservas, adDocente, adLaboratorio);
            var labServicio = new LaboratoriosServicio(adLaboratorio);
            var docServicio = new DocentesServicio(adDocente);
            //cargarReservas(serviceReservas);
            labServicio.ListarLaboratorios().ForEach((lab) => Console.WriteLine(lab.ToString()));
            docServicio.ListarDocentes().ForEach((docente) => Console.WriteLine(docente.ToString()));
            do
            {
                try
                {

                    Reserva reservaNueva = SolicitarDatosReserva();

                    serviceReservas.AgregarReserva(reservaNueva);

                    count++;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Desea agregar una nueva reserva? (x para no): ");
                }
            } while ((Console.ReadLine()[0] != 'x'));


            Console.WriteLine("Listado de todos las reservas: ");
            serviceReservas.ListarTodasReservas().ForEach(res => Console.WriteLine(res.ToString()));

            Console.WriteLine("----------------------");
            // serviceReservas.FiltrarPorFechaOLaboratorio().ForEach(res => Console.WriteLine(res.ToString()));



        }
        public static Reserva SolicitarDatosReserva()
        {
            int idLab = SolicitarDato<int>("Ingrese el id de laboratorio");
            int idDoc = SolicitarDato<int>("Ingrese el id del docente");
            string asunto = SolicitarDato<string>("Ingrese el asunto de la reserva");
            int cantEst = SolicitarDato<int>("Ingrese cantidad de estudiantes");
            Console.WriteLine("Ingresar fecha de reserva: ");
            int mes = SolicitarDato<int>("   Ingrese mes");
            int dia = SolicitarDato<int>("   Ingrese dia");
            DateOnly fecha = new DateOnly(2025, mes, dia);
            Console.WriteLine("Ingresar franja horaria de la reserva:");
            Console.WriteLine("   Reserva desde...");
            TimeOnly horaInicio = SolicitarHoraReserva();
            Console.WriteLine("    Reserva hasta---");
            TimeOnly horaFin = SolicitarHoraReserva();
            return new Reserva(idDoc, idLab, asunto, cantEst, fecha,horaInicio, horaFin);
        }

        public static T SolicitarDato<T>(string message)
        {
            Console.Write($"{message}: ");
            Type tipoSolicitado = Type.GetType($"{typeof(T)}");
            T resultado = (T)Convert.ChangeType(Console.ReadLine(), tipoSolicitado);
            return resultado;
        }

        public static TimeOnly SolicitarHoraReserva()
        {
            int hora = SolicitarDato<int>("Ingrese la hora");
            int minuto = SolicitarDato<int>("Ingrese la minuto");
            return new TimeOnly(hora, minuto);
            
        }

        public static void cargarLaboratorios(LaboratoriosServicio adLaboratorio)
        {
            var lab1 = new Laboratorio("Laboratorio de Redes", 30);
            var lab2 = new Laboratorio("Laboratorio de POO", 18);
            var lab3 = new Laboratorio("Laboratorio de POE", 25);
            var lab4 = new Laboratorio("Laboratorio de Web Apps", 40);

            adLaboratorio.AgregarLaboratorio(lab1);
            adLaboratorio.AgregarLaboratorio(lab2);
            adLaboratorio.AgregarLaboratorio(lab3);
            adLaboratorio.AgregarLaboratorio(lab4);
        }

        public static void cargarDocentes(DocentesServicio adDocentes)
        {
            var doc1 = new Docente("Carlos Cedeño", "Ingeniero en Sistemas");
            var doc2 = new Docente("Fanny Abad", "Administradora de Bases de Datos");
            var doc3 = new Docente("Freddy Alvarez", "Licenciada en Redes");
            var doc4 = new Docente("Ally Hidalgo", "Ingeniera electrica");

            adDocentes.AgregarDocente(doc1);
            adDocentes.AgregarDocente(doc2);
            adDocentes.AgregarDocente(doc3);
            adDocentes.AgregarDocente(doc4);
        }
        /*
        public static void cargarReservas(ReservasServicio adReservas)
        {

            var fecha = new DateOnly(2025, 11, 20);
            var horaInicio = new TimeOnly(10, 0);
            var horaFin = new TimeOnly(10, 30);
            var res1 = new Reserva(1, 1, 6, 20, fecha, horaInicio, horaFin);

            adReservas.AgregarReserva(res1);
            
            var fecha2 = new DateOnly(2025, 11, 21);
            var horaInicio2 = new TimeOnly(9, 0);
            var horaFin2 = new TimeOnly(9, 30);
            var res2 = new Reserva(1, 1, 10, 20, fecha2, horaInicio2, horaFin2);

            adReservas.AgregarReserva(res2);

            var fecha3 = new DateOnly(2025, 11, 21);
            var horaInicio3 = new TimeOnly(9, 0);
            var horaFin3 = new TimeOnly(9, 30);
            var res3 = new Reserva(1, 1, 6, 20, fecha3, horaInicio3, horaFin3);

            adReservas.AgregarReserva(res3);
        }
        */
        public static void ValidarFrajaHoraria(TimeOnly horaInicio, TimeOnly horaFin)
        {
            int value = horaInicio.CompareTo(horaFin);
            Console.WriteLine(value);
        }


        public static List<TimeOnly> GenerarHorari(int horaInicial, int horaFinal, int duracion = 60)
        {
            if (duracion < 10) throw new ArgumentException("La duracion del turno no puede ser menor a 10 minutos!"); 

            var horarios = new List<TimeOnly>();
            var horarioActual = new TimeOnly(horaInicial, 0);
            // numero de horarios
            int bloquesHorarios = Convert.ToInt32(((horaFinal - horaInicial) / (duracion/60)));
            Console.WriteLine($"Tu numero de horarios es : {bloquesHorarios}");
            for (int i = 0; i < bloquesHorarios; i++)
            {
                horarios.Add(horarioActual);
                horarioActual = horarioActual.AddMinutes(duracion);
            }
            return horarios;
        }

        public static List<BloqueHorario> GenerarHorarios(int inicioJornada, int finJornada, double duracion = 60)
        {
            var bloquesHorarios = new List<BloqueHorario>();
            if (duracion < 10) throw new ArgumentException("La duracion del turno no puede ser menor a 10 minutos!");
            // numero de horarios
            int numBloques = Convert.ToInt32(((finJornada - inicioJornada) / (duracion / 60)));

            TimeOnly horaInicio, horaFin; 
            horaInicio = new TimeOnly(inicioJornada, 0);

            Console.WriteLine($"Tu numero de horarios es : {numBloques}");
            for (int i = 0; i < numBloques; i++)
            {                
                horaFin = horaInicio.AddMinutes(duracion);
                bloquesHorarios.Add(new BloqueHorario(horaInicio, horaFin));
                horaInicio = horaFin;
            }

            return bloquesHorarios;
        }
    }
}
