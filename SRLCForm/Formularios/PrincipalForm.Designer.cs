namespace SRLCForm.Formularios
{
    partial class PrincipalForm
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            laboratoriosToolStripMenuItem = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { laboratoriosToolStripMenuItem, docentesToolStripMenuItem, reservasToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(81, 24);
            toolStripMenuItem1.Text = "Modulos";
            // 
            // laboratoriosToolStripMenuItem
            // 
            laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            laboratoriosToolStripMenuItem.Size = new Size(224, 26);
            laboratoriosToolStripMenuItem.Text = "Laboratorios";
            laboratoriosToolStripMenuItem.Click += laboratoriosToolStripMenuItem_Click;
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(224, 26);
            docentesToolStripMenuItem.Text = "Docentes";
            docentesToolStripMenuItem.Click += docentesToolStripMenuItem_Click;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(224, 26);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(75, 24);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(151, 26);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(151, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem laboratoriosToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}