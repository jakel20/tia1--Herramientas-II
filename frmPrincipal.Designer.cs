namespace TIA1
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            formularioClientesToolStripMenuItem = new ToolStripMenuItem();
            formularioProductosToolStripMenuItem = new ToolStripMenuItem();
            formularioCategoriasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            formularioFacturasToolStripMenuItem = new ToolStripMenuItem();
            formularioInformesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            formularioEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            formularioRolesToolStripMenuItem = new ToolStripMenuItem();
            formularioSeguridadToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(236, 240, 241);
            menuStrip1.Font = new Font("Segoe UI", 9.75F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturaciónToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 4, 0, 4);
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(66, 25);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(101, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioClientesToolStripMenuItem, formularioProductosToolStripMenuItem, formularioCategoriasToolStripMenuItem });
            tablasToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(57, 25);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // formularioClientesToolStripMenuItem
            // 
            formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            formularioClientesToolStripMenuItem.Size = new Size(137, 26);
            formularioClientesToolStripMenuItem.Text = "Clientes";
            formularioClientesToolStripMenuItem.Click += formularioClientesToolStripMenuItem_Click;
            // 
            // formularioProductosToolStripMenuItem
            // 
            formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            formularioProductosToolStripMenuItem.Size = new Size(137, 26);
            formularioProductosToolStripMenuItem.Text = "Productos";
            formularioProductosToolStripMenuItem.Click += formularioProductosToolStripMenuItem_Click;
            // 
            // formularioCategoriasToolStripMenuItem
            // 
            formularioCategoriasToolStripMenuItem.Name = "formularioCategoriasToolStripMenuItem";
            formularioCategoriasToolStripMenuItem.Size = new Size(137, 26);
            formularioCategoriasToolStripMenuItem.Text = "Categorias";
            formularioCategoriasToolStripMenuItem.Click += formularioCategoriasToolStripMenuItem_Click;
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFacturasToolStripMenuItem, formularioInformesToolStripMenuItem });
            facturaciónToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(90, 25);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // formularioFacturasToolStripMenuItem
            // 
            formularioFacturasToolStripMenuItem.Name = "formularioFacturasToolStripMenuItem";
            formularioFacturasToolStripMenuItem.Size = new Size(128, 26);
            formularioFacturasToolStripMenuItem.Text = "Facturas";
            formularioFacturasToolStripMenuItem.Click += formularioFacturasToolStripMenuItem_Click;
            // 
            // formularioInformesToolStripMenuItem
            // 
            formularioInformesToolStripMenuItem.Name = "formularioInformesToolStripMenuItem";
            formularioInformesToolStripMenuItem.Size = new Size(128, 26);
            formularioInformesToolStripMenuItem.Text = "Informes";
            formularioInformesToolStripMenuItem.Click += formularioInformesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioEmpleadosToolStripMenuItem, formularioRolesToolStripMenuItem, formularioSeguridadToolStripMenuItem });
            seguridadToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(80, 25);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // formularioEmpleadosToolStripMenuItem
            // 
            formularioEmpleadosToolStripMenuItem.Name = "formularioEmpleadosToolStripMenuItem";
            formularioEmpleadosToolStripMenuItem.Size = new Size(139, 26);
            formularioEmpleadosToolStripMenuItem.Text = "Empleados";
            formularioEmpleadosToolStripMenuItem.Click += formularioEmpleadosToolStripMenuItem_Click;
            // 
            // formularioRolesToolStripMenuItem
            // 
            formularioRolesToolStripMenuItem.Name = "formularioRolesToolStripMenuItem";
            formularioRolesToolStripMenuItem.Size = new Size(139, 26);
            formularioRolesToolStripMenuItem.Text = "Roles";
            formularioRolesToolStripMenuItem.Click += formularioRolesToolStripMenuItem_Click;
            // 
            // formularioSeguridadToolStripMenuItem
            // 
            formularioSeguridadToolStripMenuItem.Name = "formularioSeguridadToolStripMenuItem";
            formularioSeguridadToolStripMenuItem.Size = new Size(139, 26);
            formularioSeguridadToolStripMenuItem.Text = "Seguridad";
            formularioSeguridadToolStripMenuItem.Click += formularioSeguridadToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(59, 25);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(140, 26);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(140, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Sistema de Gestión TIA1 — Principal";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem formularioClientesToolStripMenuItem;
        private ToolStripMenuItem formularioProductosToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem formularioCategoriasToolStripMenuItem;
        private ToolStripMenuItem formularioFacturasToolStripMenuItem;
        private ToolStripMenuItem formularioInformesToolStripMenuItem;
        private ToolStripMenuItem formularioEmpleadosToolStripMenuItem;
        private ToolStripMenuItem formularioRolesToolStripMenuItem;
        private ToolStripMenuItem formularioSeguridadToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
