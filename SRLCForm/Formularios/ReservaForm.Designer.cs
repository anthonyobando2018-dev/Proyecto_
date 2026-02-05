namespace SRLCForm
{
    partial class ReservaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkbEstadoReserva = new CheckBox();
            nudCantidadEstudiantes = new NumericUpDown();
            label8 = new Label();
            tbId = new TextBox();
            label9 = new Label();
            dtpDiaReserva = new DateTimePicker();
            cbLaboratorio = new ComboBox();
            cbDocente = new ComboBox();
            rtbMotivoReserva = new RichTextBox();
            groupBox4 = new GroupBox();
            cbHoraFin = new ComboBox();
            cbHoraInicio = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            dgvReservas = new DataGridView();
            groupBox3 = new GroupBox();
            chkbEstadoReservaFiltro = new CheckBox();
            btnMostrarInactivas = new Button();
            btnMostrarActivas = new Button();
            chkbBuscarLaboratorio = new CheckBox();
            chkbBuscarFecha = new CheckBox();
            nudLaboratorioBusqueda = new NumericUpDown();
            btnMostrarTodas = new Button();
            dtpFechaBusqueda = new DateTimePicker();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEstudiantes).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLaboratorioBusqueda).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkbEstadoReserva);
            groupBox1.Controls.Add(nudCantidadEstudiantes);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtpDiaReserva);
            groupBox1.Controls.Add(cbLaboratorio);
            groupBox1.Controls.Add(cbDocente);
            groupBox1.Controls.Add(rtbMotivoReserva);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(832, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la reserva";
            // 
            // chkbEstadoReserva
            // 
            chkbEstadoReserva.AutoSize = true;
            chkbEstadoReserva.Checked = true;
            chkbEstadoReserva.CheckState = CheckState.Checked;
            chkbEstadoReserva.Enabled = false;
            chkbEstadoReserva.Location = new Point(461, 285);
            chkbEstadoReserva.Name = "chkbEstadoReserva";
            chkbEstadoReserva.Size = new Size(139, 24);
            chkbEstadoReserva.TabIndex = 13;
            chkbEstadoReserva.Text = "¿Reserva activa?";
            chkbEstadoReserva.UseVisualStyleBackColor = true;
            chkbEstadoReserva.CheckedChanged += chkbEstadoReserva_CheckedChanged;
            // 
            // nudCantidadEstudiantes
            // 
            nudCantidadEstudiantes.Enabled = false;
            nudCantidadEstudiantes.Location = new Point(182, 285);
            nudCantidadEstudiantes.Margin = new Padding(3, 4, 3, 4);
            nudCantidadEstudiantes.Name = "nudCantidadEstudiantes";
            nudCantidadEstudiantes.Size = new Size(219, 27);
            nudCantidadEstudiantes.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 285);
            label8.Name = "label8";
            label8.Size = new Size(172, 20);
            label8.TabIndex = 11;
            label8.Text = "Cantidad de estudiantes:";
            // 
            // tbId
            // 
            tbId.Location = new Point(182, 56);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(219, 27);
            tbId.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 60);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 9;
            label9.Text = "Reserva ID:";
            // 
            // dtpDiaReserva
            // 
            dtpDiaReserva.CustomFormat = "dd/MM/yyyy";
            dtpDiaReserva.Enabled = false;
            dtpDiaReserva.Format = DateTimePickerFormat.Custom;
            dtpDiaReserva.Location = new Point(564, 64);
            dtpDiaReserva.Margin = new Padding(3, 4, 3, 4);
            dtpDiaReserva.Name = "dtpDiaReserva";
            dtpDiaReserva.Size = new Size(228, 27);
            dtpDiaReserva.TabIndex = 8;
            // 
            // cbLaboratorio
            // 
            cbLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLaboratorio.Enabled = false;
            cbLaboratorio.FormattingEnabled = true;
            cbLaboratorio.Items.AddRange(new object[] { "NO ESPECIFICADO" });
            cbLaboratorio.Location = new Point(182, 133);
            cbLaboratorio.Margin = new Padding(3, 4, 3, 4);
            cbLaboratorio.Name = "cbLaboratorio";
            cbLaboratorio.Size = new Size(219, 28);
            cbLaboratorio.TabIndex = 7;
            // 
            // cbDocente
            // 
            cbDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDocente.Enabled = false;
            cbDocente.FormattingEnabled = true;
            cbDocente.Items.AddRange(new object[] { "NO ESPECIFICADO" });
            cbDocente.Location = new Point(182, 93);
            cbDocente.Margin = new Padding(3, 4, 3, 4);
            cbDocente.Name = "cbDocente";
            cbDocente.Size = new Size(219, 28);
            cbDocente.TabIndex = 6;
            // 
            // rtbMotivoReserva
            // 
            rtbMotivoReserva.Enabled = false;
            rtbMotivoReserva.Location = new Point(182, 175);
            rtbMotivoReserva.Margin = new Padding(3, 4, 3, 4);
            rtbMotivoReserva.Name = "rtbMotivoReserva";
            rtbMotivoReserva.Size = new Size(219, 103);
            rtbMotivoReserva.TabIndex = 5;
            rtbMotivoReserva.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbHoraFin);
            groupBox4.Controls.Add(cbHoraInicio);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(451, 115);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(342, 144);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hora programada";
            // 
            // cbHoraFin
            // 
            cbHoraFin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHoraFin.Enabled = false;
            cbHoraFin.FormattingEnabled = true;
            cbHoraFin.Items.AddRange(new object[] { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00" });
            cbHoraFin.Location = new Point(97, 81);
            cbHoraFin.Margin = new Padding(3, 4, 3, 4);
            cbHoraFin.Name = "cbHoraFin";
            cbHoraFin.Size = new Size(221, 28);
            cbHoraFin.TabIndex = 9;
            // 
            // cbHoraInicio
            // 
            cbHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHoraInicio.Enabled = false;
            cbHoraInicio.FormattingEnabled = true;
            cbHoraInicio.Items.AddRange(new object[] { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00" });
            cbHoraInicio.Location = new Point(97, 41);
            cbHoraInicio.Margin = new Padding(3, 4, 3, 4);
            cbHoraInicio.Name = "cbHoraInicio";
            cbHoraInicio.Size = new Size(221, 28);
            cbHoraInicio.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 80);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Hasta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 97);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 45);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 68);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Dia de reserva:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 180);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Motivo de reserva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 139);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 1;
            label2.Text = "Laboratorio solicitado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 97);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Docente solicitante:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Location = new Point(873, 29);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(245, 337);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(49, 48);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(157, 45);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(49, 163);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 45);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(49, 105);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Enabled = false;
            btnLimpiar.Location = new Point(49, 216);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 45);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Enabled = false;
            btnFiltrar.Location = new Point(92, 199);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(157, 46);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar reservas";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(25, 383);
            dgvReservas.Margin = new Padding(3, 4, 3, 4);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(1067, 401);
            dgvReservas.TabIndex = 3;
            dgvReservas.CellClick += dgvReservas_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkbEstadoReservaFiltro);
            groupBox3.Controls.Add(btnMostrarInactivas);
            groupBox3.Controls.Add(btnMostrarActivas);
            groupBox3.Controls.Add(chkbBuscarLaboratorio);
            groupBox3.Controls.Add(chkbBuscarFecha);
            groupBox3.Controls.Add(nudLaboratorioBusqueda);
            groupBox3.Controls.Add(btnMostrarTodas);
            groupBox3.Controls.Add(dtpFechaBusqueda);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Location = new Point(1133, 29);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(330, 755);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros";
            // 
            // chkbEstadoReservaFiltro
            // 
            chkbEstadoReservaFiltro.AutoSize = true;
            chkbEstadoReservaFiltro.Checked = true;
            chkbEstadoReservaFiltro.CheckState = CheckState.Checked;
            chkbEstadoReservaFiltro.Location = new Point(49, 149);
            chkbEstadoReservaFiltro.Margin = new Padding(3, 4, 3, 4);
            chkbEstadoReservaFiltro.Name = "chkbEstadoReservaFiltro";
            chkbEstadoReservaFiltro.Size = new Size(87, 24);
            chkbEstadoReservaFiltro.TabIndex = 20;
            chkbEstadoReservaFiltro.Text = "¿Activo?";
            chkbEstadoReservaFiltro.UseVisualStyleBackColor = true;
            // 
            // btnMostrarInactivas
            // 
            btnMostrarInactivas.Location = new Point(64, 376);
            btnMostrarInactivas.Margin = new Padding(3, 4, 3, 4);
            btnMostrarInactivas.Name = "btnMostrarInactivas";
            btnMostrarInactivas.Size = new Size(223, 43);
            btnMostrarInactivas.TabIndex = 19;
            btnMostrarInactivas.Text = "Mostrar reservas inactivas";
            btnMostrarInactivas.UseVisualStyleBackColor = true;
            btnMostrarInactivas.Click += btnMostrarInactivas_Click;
            // 
            // btnMostrarActivas
            // 
            btnMostrarActivas.Location = new Point(64, 325);
            btnMostrarActivas.Margin = new Padding(3, 4, 3, 4);
            btnMostrarActivas.Name = "btnMostrarActivas";
            btnMostrarActivas.Size = new Size(223, 43);
            btnMostrarActivas.TabIndex = 18;
            btnMostrarActivas.Text = "Mostrar reservas activas";
            btnMostrarActivas.UseVisualStyleBackColor = true;
            btnMostrarActivas.Click += btnMostrarActivas_Click;
            // 
            // chkbBuscarLaboratorio
            // 
            chkbBuscarLaboratorio.AutoSize = true;
            chkbBuscarLaboratorio.Location = new Point(49, 111);
            chkbBuscarLaboratorio.Margin = new Padding(3, 4, 3, 4);
            chkbBuscarLaboratorio.Name = "chkbBuscarLaboratorio";
            chkbBuscarLaboratorio.Size = new Size(128, 24);
            chkbBuscarLaboratorio.TabIndex = 17;
            chkbBuscarLaboratorio.Text = "Laboratorio ID";
            chkbBuscarLaboratorio.UseVisualStyleBackColor = true;
            chkbBuscarLaboratorio.CheckedChanged += chkbBuscarLaboratorio_CheckedChanged;
            // 
            // chkbBuscarFecha
            // 
            chkbBuscarFecha.AutoSize = true;
            chkbBuscarFecha.Location = new Point(49, 71);
            chkbBuscarFecha.Margin = new Padding(3, 4, 3, 4);
            chkbBuscarFecha.Name = "chkbBuscarFecha";
            chkbBuscarFecha.Size = new Size(69, 24);
            chkbBuscarFecha.TabIndex = 16;
            chkbBuscarFecha.Text = "Fecha";
            chkbBuscarFecha.UseVisualStyleBackColor = true;
            chkbBuscarFecha.CheckedChanged += chkbBuscarFecha_CheckedChanged;
            // 
            // nudLaboratorioBusqueda
            // 
            nudLaboratorioBusqueda.Enabled = false;
            nudLaboratorioBusqueda.Location = new Point(193, 111);
            nudLaboratorioBusqueda.Margin = new Padding(3, 4, 3, 4);
            nudLaboratorioBusqueda.Name = "nudLaboratorioBusqueda";
            nudLaboratorioBusqueda.Size = new Size(104, 27);
            nudLaboratorioBusqueda.TabIndex = 15;
            // 
            // btnMostrarTodas
            // 
            btnMostrarTodas.Location = new Point(64, 273);
            btnMostrarTodas.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTodas.Name = "btnMostrarTodas";
            btnMostrarTodas.Size = new Size(223, 44);
            btnMostrarTodas.TabIndex = 14;
            btnMostrarTodas.Text = "Mostrar todas las reservas";
            btnMostrarTodas.UseVisualStyleBackColor = true;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            // 
            // dtpFechaBusqueda
            // 
            dtpFechaBusqueda.CustomFormat = "";
            dtpFechaBusqueda.Enabled = false;
            dtpFechaBusqueda.Format = DateTimePickerFormat.Custom;
            dtpFechaBusqueda.Location = new Point(165, 71);
            dtpFechaBusqueda.Margin = new Padding(3, 4, 3, 4);
            dtpFechaBusqueda.MinDate = new DateTime(2025, 11, 27, 0, 0, 0, 0);
            dtpFechaBusqueda.Name = "dtpFechaBusqueda";
            dtpFechaBusqueda.Size = new Size(132, 27);
            dtpFechaBusqueda.TabIndex = 13;
            dtpFechaBusqueda.Value = new DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 34);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 4;
            label10.Text = "Buscar por:";
            // 
            // ReservaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 797);
            Controls.Add(groupBox3);
            Controls.Add(dgvReservas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservaForm";
            Text = "ReservaForm";
            Activated += ReservaForm_Activated;
            FormClosing += ReservaForm_FormClosing;
            Load += ReservaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEstudiantes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLaboratorioBusqueda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvReservas;
        private Label label1;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLimpiar;
        private RichTextBox rtbMotivoReserva;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox cbLaboratorio;
        private ComboBox cbDocente;
        private DateTimePicker dtpDiaReserva;
        private ComboBox cbHoraFin;
        private ComboBox cbHoraInicio;
        private Label label9;
        private Button btnFiltrar;
        private TextBox tbId;
        private NumericUpDown nudCantidadEstudiantes;
        private Label label8;
        private GroupBox groupBox3;
        private DateTimePicker dtpFechaBusqueda;
        private Label label10;
        private Button btnMostrarTodas;
        private NumericUpDown nudLaboratorioBusqueda;
        private CheckBox chkbBuscarLaboratorio;
        private CheckBox chkbBuscarFecha;
        private Button btnNuevo;
        private CheckBox chkbEstadoReserva;
        private Button btnMostrarInactivas;
        private Button btnMostrarActivas;
        private CheckBox chkbEstadoReservaFiltro;
    }
}