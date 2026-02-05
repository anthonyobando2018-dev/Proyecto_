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
            lblCodigo.Location = new Point(40, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(40, 141);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(83, 20);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(103, 29);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(355, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 83);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(355, 27);
            txtNombre.TabIndex = 4;
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(122, 131);
            numCapacidad.Margin = new Padding(3, 4, 3, 4);
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(137, 27);
            numCapacidad.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(551, 83);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(82, 24);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Location = new Point(29, 245);
            dgvLaboratorios.Margin = new Padding(3, 4, 3, 4);
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.RowHeadersWidth = 51;
            dgvLaboratorios.Size = new Size(718, 271);
            dgvLaboratorios.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(122, 185);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 33);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(233, 187);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 35);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(367, 187);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 36);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(487, 188);
            btnListar.Margin = new Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(86, 35);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(608, 188);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 35);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // LaboratorioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 532);
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
            Margin = new Padding(3, 4, 3, 4);
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
