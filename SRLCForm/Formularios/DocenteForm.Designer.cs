namespace SRLCForm.Formularios
{
    partial class DocenteForm
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
            chkEstado = new CheckBox();
            txtEspecialidad = new TextBox();
            txtApellidos = new TextBox();
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            txtId_Docente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnListar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            dgvDocente = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtId_Docente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(566, 312);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Docente";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(280, 269);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(87, 24);
            chkEstado.TabIndex = 11;
            chkEstado.Text = "¿Activo?";
            chkEstado.TextAlign = ContentAlignment.MiddleCenter;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(222, 217);
            txtEspecialidad.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(221, 27);
            txtEspecialidad.TabIndex = 10;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(222, 170);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(221, 27);
            txtApellidos.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(222, 90);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(221, 27);
            txtCedula.TabIndex = 8;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(222, 127);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(221, 27);
            txtNombres.TabIndex = 7;
            // 
            // txtId_Docente
            // 
            txtId_Docente.Location = new Point(222, 46);
            txtId_Docente.Margin = new Padding(3, 4, 3, 4);
            txtId_Docente.Name = "txtId_Docente";
            txtId_Docente.ReadOnly = true;
            txtId_Docente.Size = new Size(221, 27);
            txtId_Docente.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 221);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 5;
            label6.Text = "Especialidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 174);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 131);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "IdDocente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 63);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnListar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(586, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(222, 312);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones ";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 200);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(27, 141);
            btnListar.Margin = new Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(166, 45);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 91);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 43);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(27, 36);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(163, 47);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvDocente
            // 
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocente.Location = new Point(14, 349);
            dgvDocente.Margin = new Padding(3, 4, 3, 4);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.Size = new Size(794, 159);
            dgvDocente.TabIndex = 2;
            dgvDocente.CellClick += dgvDocente_CellClick;
            // 
            // DocenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 521);
            Controls.Add(dgvDocente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DocenteForm";
            Text = "DocenteForm";
            FormClosing += DocenteForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvDocente;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEspecialidad;
        private TextBox txtApellidos;
        private TextBox txtCedula;
        private TextBox txtNombres;
        private TextBox txtId_Docente;
        private Button btnEliminar;
        private Button btnListar;
        private Button btnAgregar;
        private Button btnNuevo;
        private CheckBox chkEstado;
    }
}