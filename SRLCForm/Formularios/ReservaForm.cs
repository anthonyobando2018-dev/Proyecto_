using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRLCProyectoPOE.Administradoras;
using SRLCProyectoPOE.Entidades;

namespace SRLCForm
{
    public partial class ReservaForm : Form
    {
        private readonly int _jornadaHoraInicio = 8;
        private readonly int _jornadaHoraFin = 16;
        private readonly int _duracionHorario = 30;
        private List<TimeOnly> _horasInicio = new();
        private List<TimeOnly> _horasFin = new();

        public ReservaForm()
        {
            InitializeComponent();
        }

        // cargar los datos en el formulario cuando este se abra
        private void ReservaForm_Load(object sender, EventArgs e)
        {
            dtpDiaReserva.MinDate = DateTime.Today;
            dtpFechaBusqueda.MinDate = DateTime.Today;
            CargarHorariosAlComboBox();
            LimpiarControles();

        }

        // Permitir ingresar nueva reserva
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            LimpiarControles();
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
           
        }

        // Guardar / Actualizar reserva
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool habilitarGuardado = VerificarCampos();
            if (habilitarGuardado)
            {
                try
                {
                    Reserva reservaNueva = ObtenerReservaDelFormulario();
                    if (btnGuardar.Text == "Guardar")
                    {
                        ReservaAdministradora.AgregarReserva(reservaNueva);
                        MessageBox.Show("Reserva registrada con exito!");
                        LimpiarControles();
                        DesactivarControles();
                    }
                    else
                    {
                        reservaNueva.IdReserva = Convert.ToInt32(tbId.Text);
                        ReservaAdministradora.ActualizarDatosReserva(reservaNueva);
                        MessageBox.Show("Reserva actualizada con exito!");
                    }
                    btnNuevo.Enabled = true;
                    RefrescarTablaReservas();
                }
                catch (Exception ex)
                {
                    ErrorPersonalizado(ex);
                }
            }
        }

        // eliminar reserva mediante id
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idReserva = Convert.ToInt32(tbId.Text);
                ReservaAdministradora.EliminarReserva(idReserva);
                MessageBox.Show("Reserva eliminada con exito!");
                RefrescarTablaReservas();
                LimpiarControles();
                DesactivarControles();
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorPersonalizado(ex);
            }
        }

        // Reestablecer los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        // Cargar los datos de la fila seleccionada en la tabla
        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                var reservaDatos = dgvReservas.Rows[filaSeleccionada].Cells;
                CargarReservaAlFormulario(reservaDatos);
                btnGuardar.Text = "Actualizar";
                ActivarControles();
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }



        // Mostrar todas las reservas registradas
        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            RefrescarTablaReservas();
        }        
        
        // Mostrar las reservas activas
        private void btnMostrarActivas_Click(object sender, EventArgs e)
        {
            RefrescarTablaReservas(ReservaAdministradora.ListarReservas(true));
        }

        // Mostrar las reservas inactivas
        private void btnMostrarInactivas_Click(object sender, EventArgs e)
        {
            RefrescarTablaReservas(ReservaAdministradora.ListarReservas(false));
        }

        // Filtrar por fecha, id de laboratorio o ambos
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int laboratorioId = Convert.ToInt32(nudLaboratorioBusqueda.Value);
                DateOnly fechaBuscada = DateOnly.FromDateTime(dtpFechaBusqueda.Value);
                bool reservasEstado = chkbEstadoReservaFiltro.Checked;
                List<Reserva> reservasFiltradas = new List<Reserva>();
                if (chkbBuscarLaboratorio.Checked && chkbBuscarFecha.Checked)
                    reservasFiltradas = ReservaAdministradora.ListarReservas(reservasEstado).FindAll((reserva) => reserva.IdLaboratorio == laboratorioId && reserva.FechaReserva == fechaBuscada);
                else if (chkbBuscarLaboratorio.Checked)
                    reservasFiltradas = ReservaAdministradora.FiltrarPorLaboratorio(laboratorioId, reservasEstado);
                else if (chkbBuscarFecha.Checked)
                    reservasFiltradas = ReservaAdministradora.FiltrarPorFecha(fechaBuscada, estado: reservasEstado);

                RefrescarTablaReservas(reservasFiltradas);
            }
            catch (Exception ex)
            {
                ErrorPersonalizado(ex);
            }
        }

        // Habilitar campos de filtrado
        private void chkbBuscarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaBusqueda.Enabled = chkbBuscarFecha.Checked;
            HabilitarFiltrado();
        }

        private void chkbBuscarLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            nudLaboratorioBusqueda.Enabled = chkbBuscarLaboratorio.Checked;
            HabilitarFiltrado();
        }

        private void ReservaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        // Metodos utilitarios
        private void HabilitarFiltrado()
        {
            btnFiltrar.Enabled = (chkbBuscarFecha.Checked || chkbBuscarLaboratorio.Checked);
        }

        private void DesactivarControles()
        {
            cbDocente.Enabled = false;
            cbLaboratorio.Enabled = false;
            rtbMotivoReserva.Enabled = false;
            nudCantidadEstudiantes.Enabled = false;
            dtpDiaReserva.Enabled = false;
            cbHoraInicio.Enabled = false;
            cbHoraFin.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            chkbEstadoReserva.Enabled = false;
        }

        private void ActivarControles()
        {
            cbDocente.Enabled = true;
            cbLaboratorio.Enabled = true;
            rtbMotivoReserva.Enabled = true;
            nudCantidadEstudiantes.Enabled = true;
            dtpDiaReserva.Enabled = true;
            cbHoraInicio.Enabled = true;
            cbHoraFin.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
            chkbEstadoReserva.Enabled = true;
        }

        private void CargarReservaAlFormulario(DataGridViewCellCollection reservaSeleccionada)
        {
            tbId.Text = reservaSeleccionada["IdReserva"].Value.ToString();
            rtbMotivoReserva.Text = reservaSeleccionada["Asunto"].Value.ToString();
            nudCantidadEstudiantes.Value = Convert.ToInt32(reservaSeleccionada["CantidadEstudiantes"].Value);
            dtpDiaReserva.Value = DateTime.Parse(reservaSeleccionada["FechaReserva"].Value.ToString() ?? string.Empty);
            var horario = reservaSeleccionada["Horario"].Value.ToString()?.Split('-'); // separar la hora inicio y fin
            if (horario != null)
            {
                cbHoraInicio.SelectedIndex = _horasInicio.IndexOf(TimeOnly.Parse(horario[0]));
                cbHoraFin.SelectedIndex = _horasFin.IndexOf(TimeOnly.Parse(horario[1]));
            }

            // Encontrar y setear el docente y el laboratorio de la reserva al formulario, si no lo encuentra (eliminado) notifica por cuadro de mensaje
            Docente docenteSeleccionado = DocenteAdministradora.BuscarDocente(Convert.ToInt32(reservaSeleccionada["IdDocente"].Value));
            int docenteComboBoxId = cbDocente.Items.Cast<Docente>().ToList().IndexOf(docenteSeleccionado);

            Laboratorio laboratorioSeleccionado = LaboratorioAdministradora.GetListaLaboratorio()[LaboratorioAdministradora.BuscarLaboratorio(Convert.ToInt32(reservaSeleccionada["IdLaboratorio"].Value))];
            int laboratorioComboBoxId = cbLaboratorio.Items.Cast<Laboratorio>().ToList().IndexOf(laboratorioSeleccionado);

            StringBuilder datosEliminados = new StringBuilder();
            if (!docenteSeleccionado.Estado)
                datosEliminados.AppendLine($"> El docente de ID: '{docenteSeleccionado.IdDocente}' se encuentra inactivo actualmente.\n" +
                    $"Datos del docente inactivo:\n" +
                    $"Nombres: {docenteSeleccionado.Nombres} {docenteSeleccionado.Apellidos}\n" +
                    $"Cedula: {docenteSeleccionado.Cedula}\n");
            if (!laboratorioSeleccionado.Estado)
                datosEliminados.AppendLine($"> El laboratorio de ID: '{laboratorioSeleccionado.IdLaboratorio}' se encuentra inactivo actualmente.\n" +
                    $"Datos del laboratorio inactivo:\n" +
                    $"Nombres: {laboratorioSeleccionado.Nombre}\n" +
                    $"Capacidad maxima: {laboratorioSeleccionado.CapacidadMaxima}\n");

            if (datosEliminados.Length > 0)
                MessageBox.Show(datosEliminados.ToString(), "Datos inactivos encontrados");

            cbDocente.SelectedIndex = docenteComboBoxId;
            cbLaboratorio.SelectedIndex = laboratorioComboBoxId;

            chkbEstadoReserva.Checked = (reservaSeleccionada["Estado"].Value.ToString() ?? string.Empty).Equals("True");
        }

        private Reserva ObtenerReservaDelFormulario()
        {
            int idDocente = Convert.ToInt32(cbDocente.SelectedValue);
            int idLaboratorio = Convert.ToInt32(cbLaboratorio.SelectedValue);
            string asunto = rtbMotivoReserva.Text;
            int cantidadEstudiantes = Convert.ToInt32(nudCantidadEstudiantes.Value);
            DateOnly fecha = DateOnly.FromDateTime(dtpDiaReserva.Value); // extraer solo la fecha del objeto DateTime devuelto
            TimeOnly horaInicio = TimeOnly.Parse(cbHoraInicio.SelectedValue?.ToString() ?? string.Empty);
            TimeOnly horaFin = TimeOnly.Parse(cbHoraFin.SelectedValue?.ToString() ?? string.Empty);
            bool estado = chkbEstadoReserva.Checked;
            Reserva reservaNueva = new Reserva(
                idDocente,
                idLaboratorio,
                asunto,
                cantidadEstudiantes,
                fecha,
                new BloqueHorario(horaInicio, horaFin)
            );
            reservaNueva.Estado = estado;
            return reservaNueva;
        }

        public bool VerificarCampos()
        {
            bool docenteSeleccionado = cbDocente.SelectedIndex != -1;
            bool laboratorioSeleccionado = cbLaboratorio.SelectedIndex != -1;
            bool horaSeleccionada = cbHoraInicio.SelectedIndex != -1 && cbHoraFin.SelectedIndex != -1;
            bool motivoEscrito = rtbMotivoReserva.Text.Length > 0;

            StringBuilder sb = new StringBuilder();
            if (!docenteSeleccionado) sb.AppendLine("Docente no seleccionado.");
            if (!laboratorioSeleccionado) sb.AppendLine("Laboratorio no seleccionado.");
            if (!horaSeleccionada) sb.AppendLine("Hora de reserva no establecida.");
            if (!motivoEscrito) sb.AppendLine("Motivo no especificado.");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LimpiarControles()
        {
            cbDocente.SelectedIndex = -1;
            cbLaboratorio.SelectedIndex = -1;
            cbHoraInicio.SelectedIndex = -1;
            cbHoraFin.SelectedIndex = -1;
            rtbMotivoReserva.Text = string.Empty;
            tbId.Text = ReservaAdministradora.GetIdActual().ToString();
            dtpDiaReserva.Value = DateTime.Today;
            nudCantidadEstudiantes.Value = 0;
            btnGuardar.Text = "Guardar";
        }

        private void ErrorPersonalizado(Exception ex)
        {
            string titulo = string.Empty;
            if (ex is ArgumentNullException)
                titulo = "Valor inexistente";
            else if (ex is ArgumentException)
                titulo = "Valor ingresado no valido";
            else
                titulo = "Algo salio mal";
            MessageBox.Show($"Error: {ex.Message}", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefrescarTablaReservas(List<Reserva>? reservas = null)
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservas ?? ReservaAdministradora.ListarReservas();
        }


        // Cargar datos a los controles
        private void CargarHorariosAlComboBox()
        {
            var bloquesHorarios = ReservaAdministradora.GenerarHorarios(_jornadaHoraInicio, _jornadaHoraFin, _duracionHorario);

            bloquesHorarios.ForEach(bloque =>
            {
                _horasInicio.Add(bloque.HoraInicio);
                _horasFin.Add(bloque.HoraFin);
            });
            cbHoraInicio.DataSource = _horasInicio;
            cbHoraFin.DataSource = _horasFin;
        }

        private void CargarDocentesAlComboBox()
        {
            cbDocente.DataSource = null;
            cbDocente.DataSource = DocenteAdministradora.ListarDocente().FindAll(docente => docente.Estado);
            cbDocente.DisplayMember = "NombreCompleto";
            cbDocente.ValueMember = "IdDocente";
        }

        private void CargarLaboratoriosAlComboBox()
        {
            cbLaboratorio.DataSource = null;
            cbLaboratorio.DataSource = LaboratorioAdministradora.GetListaLaboratorio().FindAll(laboratorio => laboratorio.Estado);
            cbLaboratorio.DisplayMember = "Nombre";
            cbLaboratorio.ValueMember = "IdLaboratorio";
        }

        private void ReservaForm_Activated(object sender, EventArgs e)
        {
            CargarDocentesAlComboBox();
            CargarLaboratoriosAlComboBox();
            LimpiarControles();
        }

        private void chkbEstadoReserva_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
