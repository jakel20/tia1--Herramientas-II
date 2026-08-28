namespace TIA1
{
    partial class frmAyuda
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
            lblTituloAyuda = new Label();
            lblContenidoAyuda = new Label();
            SuspendLayout();
            // 
            // lblTituloAyuda
            // 
            lblTituloAyuda.AutoSize = true;
            lblTituloAyuda.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloAyuda.ForeColor = Color.FromArgb(44, 62, 80);
            lblTituloAyuda.Location = new Point(30, 25);
            lblTituloAyuda.Name = "lblTituloAyuda";
            lblTituloAyuda.Size = new Size(75, 25);
            lblTituloAyuda.TabIndex = 0;
            lblTituloAyuda.Text = "Ayuda";
            // 
            // lblContenidoAyuda
            // 
            lblContenidoAyuda.AutoSize = true;
            lblContenidoAyuda.Font = new Font("Segoe UI", 9.75F);
            lblContenidoAyuda.ForeColor = Color.FromArgb(44, 62, 80);
            lblContenidoAyuda.Location = new Point(32, 70);
            lblContenidoAyuda.Name = "lblContenidoAyuda";
            lblContenidoAyuda.Size = new Size(420, 119);
            lblContenidoAyuda.TabIndex = 1;
            lblContenidoAyuda.Text = "Guía rápida de los menús de la aplicación:\n\n•  Archivo  >  Salir:  cierra la aplicación.\n•  Tablas:  formularios de Clientes, Productos y Categorías.\n•  Facturación:  formularios de Facturas e Informes.\n•  Seguridad:  formularios de Empleados, Roles y Seguridad.\n•  Ayuda  >  Acerca de:  información de la aplicación.";
            // 
            // frmAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloAyuda);
            Controls.Add(lblContenidoAyuda);
            Name = "frmAyuda";
            Text = "Ayuda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAyuda;
        private Label lblContenidoAyuda;
    }
}
