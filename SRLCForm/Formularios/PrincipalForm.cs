using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRLCProyectoPOE.Entidades;

namespace SRLCForm.Formularios
{
    public partial class PrincipalForm : Form
    {
        // formularios estaticos
        private static ReservaForm _reservaForm = new ReservaForm();
        private static ReporteForm _reporteForm = new ReporteForm();
        private static DocenteForm _docenteForm = new DocenteForm();
        private static LaboratorioForm _laboratorioForm = new LaboratorioForm();

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formulario reservas contenido en formulario principal
            _reservaForm.MdiParent = this;
            _reservaForm.Show();

            _reservaForm.Activate();
            CentrarFormulario(this, _reservaForm);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar el formulario de reportes y ponerle foco
            _reporteForm.MdiParent = this;
            _reporteForm.Show();

            _reporteForm.Activate();
            CentrarFormulario(this, _reporteForm);
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar formulario de laboratorio y ponerle foco
            _laboratorioForm.MdiParent = this;
            _laboratorioForm.Show();

            _laboratorioForm.Activate();
            CentrarFormulario(this, _laboratorioForm);

        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar formulario de docente y ponerle foco
            _docenteForm.MdiParent = this;
            _docenteForm.Show();

            _docenteForm.Activate();
            CentrarFormulario(this, _docenteForm);
        }

        // centrar el formulario
        private void CentrarFormulario(Form contenedor, Form hijo)
        {
            int centroHorizontal = (contenedor.ClientSize.Width - hijo.ClientSize.Width) / 2;
            int centroVertical = (contenedor.ClientSize.Height - hijo.ClientSize.Height) / 2;
            hijo.Left = centroHorizontal;
            hijo.Top = centroVertical;
        }

        // ocultar la ventana en lugar de cerrar
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
