namespace SRLCForm.Formularios
{
    partial class LaboratorioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            lblCapacidad = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            numCapacidad = new NumericUpDown();
            chkActivo = new CheckBox();
            dgvLaboratorios = new DataGridView();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnListar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(35, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(35, 106);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 22);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(311, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(311, 23);
            txtNombre.TabIndex = 4;
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(107, 98);
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(120, 23);
            numCapacidad.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(482, 62);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(67, 19);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Location = new Point(25, 184);
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.RowHeadersWidth = 51;
            dgvLaboratorios.Size = new Size(628, 203);
            dgvLaboratorios.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(107, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 25);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(213, 140);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(78, 26);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(321, 140);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 27);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(426, 141);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 26);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(532, 141);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 26);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // LaboratorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 399);
            Controls.Add(btnActualizar);
            Controls.Add(btnListar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLaboratorios);
            Controls.Add(chkActivo);
            Controls.Add(numCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LaboratorioForm";
            Text = "LABORATORIOS";
            FormClosing += LaboratorioForm_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCapacidad;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private NumericUpDown numCapacidad;
        private CheckBox chkActivo;
        private DataGridView dgvLaboratorios;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnListar;
        private Button btnActualizar;
    }
}
