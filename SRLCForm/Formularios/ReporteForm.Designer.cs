namespace SRLCForm.Formularios
{
    partial class ReporteForm
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
            dtpFechaFin = new DateTimePicker();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            rtbReporte = new RichTextBox();
            btnGenerarReporte = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaFin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(541, 162);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuracion del reporte";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(382, 64);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(127, 27);
            dtpFechaFin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 72);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "hasta";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(183, 65);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(127, 27);
            dtpFechaInicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 71);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Con fecha desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Reporte de reservas...";
            // 
            // rtbReporte
            // 
            rtbReporte.Location = new Point(14, 186);
            rtbReporte.Margin = new Padding(3, 4, 3, 4);
            rtbReporte.Name = "rtbReporte";
            rtbReporte.ReadOnly = true;
            rtbReporte.Size = new Size(714, 296);
            rtbReporte.TabIndex = 2;
            rtbReporte.Text = "";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(581, 64);
            btnGenerarReporte.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(137, 47);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 123);
            label4.Name = "label4";
            label4.Size = new Size(438, 20);
            label4.TabIndex = 5;
            label4.Text = "Nota: Los reportes generados son en base a las reservas ACTIVAS";
            // 
            // ReporteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 499);
            Controls.Add(btnGenerarReporte);
            Controls.Add(rtbReporte);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReporteForm";
            Text = "ReporteForm";
            FormClosing += ReporteForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private RichTextBox rtbReporte;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label label3;
        private Button btnGenerarReporte;
        private Label label4;
    }
}