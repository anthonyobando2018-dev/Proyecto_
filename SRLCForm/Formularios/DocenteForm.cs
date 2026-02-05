using SRLCProyectoPOE.Entidades;
using SRLCProyectoPOE.Utilidades;
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

namespace SRLCForm.Formularios
{
    public partial class DocenteForm : Form
    {
        //creando un objeto para refernciar a la lista y metodos 

        //crear bandera
        bool is_docente_nuevo = false;
        public DocenteForm()
        {
            InitializeComponent();            
            DeshabilitarCampos();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //setear los controles
            setearControles();
            HabilitarCampos();
            //activar la bandera
            is_docente_nuevo = true;
            //en el campo codigo poner un nuevo codigo
            txtId_Docente.Text = DocenteAdministradora.GetNextCodigo().ToString();
            //control de botones
            btnNuevo.Enabled = false;
            btnAgregar.Enabled = true;
            btnListar.Enabled = false;
            btnEliminar.Enabled = false;
            //darle el focus a la cedula
            txtCedula.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crear un ojeto de tipo docente 
                Docente docente = new Docente();

                //llenar los datos de los docentes
                docente.Cedula = txtCedula.Text;
                docente.Nombres = txtNombres.Text;
                docente.Apellidos = txtApellidos.Text;
                docente.Especialidad = txtEspecialidad.Text;
                docente.Estado = chkEstado.Checked;

                if (is_docente_nuevo)
                {
                    //crear el docente
                    DocenteAdministradora.AgregarDocente(docente);
                    //Enviar mensaje
                    MessageBox.Show("Docente Agregado");
                    //setear la bandera
                    is_docente_nuevo = false;
                    //setear 
                    setearControles();
                    DeshabilitarCampos();
                }
                else
                {
                    docente.IdDocente = Convert.ToInt32(txtId_Docente.Text);
                    //actualizar el docente
                    DocenteAdministradora.ActualizarDocente(docente);
                    //Actualizar estado del Boton
                    btnAgregar.Text = "Guardar";
                    //Mandar un mensaje 
                    MessageBox.Show("Docente Actualizado");
                }
                //setear los botones
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnListar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            LlenarGridDocentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtId_Docente.Text);
                DocenteAdministradora.EliminarDocente(codigo);

                //setear botones
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
                btnNuevo.Enabled = true;
                btnAgregar.Text = "Guardar";
                dgvDocente.CurrentCell = null;
                setearControles();
                DeshabilitarCampos();
                LlenarGridDocentes();
                MessageBox.Show("Docente eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
        }

        private void dgvDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgvDocente.Rows.Count)
                    return;
                HabilitarCampos();
                //MessageBox.Show("Valor de rowIndex -> " + dgvDocente.Rows[e.RowIndex].ToString());
                DataGridViewRow fila = dgvDocente.Rows[e.RowIndex];

                txtId_Docente.Text = fila.Cells["IdDocente"].Value?.ToString() ?? "";
                txtCedula.Text = fila.Cells["Cedula"].Value?.ToString() ?? "";
                txtNombres.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellidos.Text = fila.Cells["Apellidos"].Value?.ToString() ?? "";
                txtEspecialidad.Text = fila.Cells["Especialidad"].Value?.ToString() ?? "";
                chkEstado.Checked = (fila.Cells["Estado"].Value.ToString() ?? string.Empty).Equals("True");

                // Configurar botones
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                txtCedula.Enabled = false;
                btnAgregar.Text = "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
        }

        private void setearControles()
        {
            txtId_Docente.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
            chkEstado.Checked = false;

        }
        public void LlenarGridDocentes()
        {
            try
            {
                dgvDocente.DataSource = null;
                //asignar la lista
                dgvDocente.DataSource = DocenteAdministradora.ListarDocente();
                //validaciones
                dgvDocente.ClearSelection();
                dgvDocente.CurrentCell = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
        }

        // ocultar la ventana cuando se clickee en boton cerrar
        private void DocenteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void DeshabilitarCampos()
        {
            txtEspecialidad.Enabled = false;
            txtApellidos.Enabled = false;
            txtCedula.Enabled = false;
            txtNombres.Enabled = false;
            chkEstado.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtEspecialidad.Enabled = true;
            txtApellidos.Enabled = true;
            txtCedula.Enabled = true;
            txtNombres.Enabled = true;
            chkEstado.Enabled = true;
        }
    }
}
