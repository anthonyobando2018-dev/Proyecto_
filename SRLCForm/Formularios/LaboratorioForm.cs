using SRLCProyectoPOE.Administradoras;
using SRLCProyectoPOE.Entidades;
using SRLCProyectoPOE.Utilidades;

namespace SRLCForm.Formularios
{
    public partial class LaboratorioForm : Form
    {
        // private LaboratorioAdministradora LaboratorioAdministradora = new LaboratorioAdministradora();

        public LaboratorioForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Laboratorio lab = new Laboratorio
                {
                    // IdLaboratorio = LaboratorioAdministradora.GetNextCodigo(),
                    Nombre = txtNombre.Text.Trim(),
                    CapacidadMaxima = (int)numCapacidad.Value,
                    Estado = chkActivo.Checked
                };

                LaboratorioAdministradora.CrearLaboratorio(lab);
                MessageBox.Show("Laboratorio agregado correctamente.");
                LimpiarCampos();
                ListarLaboratorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un codigo valido para buscar.");
                return;
            }

            var lab = LaboratorioAdministradora.GetListaLaboratorio()
                                   .Find(l => l.IdLaboratorio == codigo);

            if (lab == null)
            {
                MessageBox.Show("Laboratorio no encontrado.");
                return;
            }

            txtNombre.Text = lab.Nombre;
            numCapacidad.Value = lab.CapacidadMaxima;
            chkActivo.Checked = lab.Estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {



            try
                {
                
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese un codigo valido para eliminar.");
                    return;
                }
                LaboratorioAdministradora.EliminarLaboratorio(codigo);
                MessageBox.Show("Laboratorio eliminado correctamente.");
                LimpiarCampos();
                ListarLaboratorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarLaboratorios();
        }

        private void ListarLaboratorios()
        {
            dgvLaboratorios.DataSource = null;
            dgvLaboratorios.DataSource = LaboratorioAdministradora.GetListaLaboratorio();
            dgvLaboratorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            numCapacidad.Value = 0;
            // chkActivo.Checked = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese un codigo valido para actualizar.");
                    return;
                }

                Laboratorio lab = new Laboratorio
                {
                    IdLaboratorio = codigo,
                    Nombre = txtNombre.Text.Trim(),
                    CapacidadMaxima = (int)numCapacidad.Value,
                    Estado = chkActivo.Checked
                };

                LaboratorioAdministradora.ActualizarLaboratorio(lab);
                MessageBox.Show("Laboratorio actualizado correctamente.");
                LimpiarCampos();
                ListarLaboratorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // ocultar la ventana cuando se clickee en boton cerrar
        private void LaboratorioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}

