using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRLCProyectoPOE.Administradoras;
using SRLCProyectoPOE.Entidades;

namespace SRLCForm.Formularios
{
    public partial class ReporteForm : Form
    {
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // obtenemos los datos del formulario
                DateOnly fechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value);
                DateOnly fechaFin = DateOnly.FromDateTime(dtpFechaFin.Value);

                if (fechaInicio > fechaFin)
                {
                    throw new ArgumentException("La fecha de inicio no puede ser mayor a la fecha de fin!");
                }

                // filtramos las reservas en el rango de fechas
                var listaReservas =  ReservaAdministradora.FiltrarPorFecha(fechaInicio, fechaFin, true);

                // instancia de StringBuilder para construir el reporte
                StringBuilder reporte = new StringBuilder();

                if (listaReservas.Count > 0)
                {
                    // agrupamos por laboratorio
                    var grupos = listaReservas.GroupBy((reserva) => reserva.IdLaboratorio);

                    // recorremos los grupos de reservas
                    foreach (var reservas in grupos)
                    {
                        Laboratorio laboratorio = LaboratorioAdministradora.GetListaLaboratorio()[LaboratorioAdministradora.BuscarLaboratorio(reservas.Key)];
                        reporte.AppendLine($"Reservas del {laboratorio.Nombre}\n");
                        var tiempoReservado = new TimeSpan(0);
                        // recorremos las reservas
                        foreach (var reserva in reservas)
                        {
                            
                            var duracionReserva = reserva.Horario.HoraFin - reserva.Horario.HoraInicio;
                            // mostramos los datos de cada reserva
                            Docente docente = DocenteAdministradora.BuscarDocente(reserva.IdDocente);
                            string reservaDatos = $"Reserva de ID: {reserva.IdReserva}\n" +
                                $"__Docente ocupante: {docente.Nombres}\n" +
                                $"__Asunto de reserva: {reserva.Asunto}\n" +
                                $"__Dia de reserva: {reserva.FechaReserva}\n" +
                                $"__Franja horaria: {reserva.Horario}\n";
                            reporte.AppendLine(reservaDatos);
                            tiempoReservado += duracionReserva;
                        }
                        reporte.AppendLine($"Tiempo total reservado: {tiempoReservado}");
                        reporte.AppendLine("------------------------------------------------");
                    }
                }
                else
                {
                    reporte.AppendLine("No hay reservas registras en ese rango de fechas.");
                }
                rtbReporte.Text = reporte.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error al generar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReporteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
