namespace TIA1
{
    partial class frmAcercade
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
            lblTituloAcerca = new Label();
            lblNombreApp = new Label();
            lblVersion = new Label();
            lblAutor = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblTituloAcerca
            // 
            lblTituloAcerca.AutoSize = true;
            lblTituloAcerca.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloAcerca.ForeColor = Color.FromArgb(44, 62, 80);
            lblTituloAcerca.Location = new Point(34, 33);
            lblTituloAcerca.Name = "lblTituloAcerca";
            lblTituloAcerca.Size = new Size(126, 32);
            lblTituloAcerca.TabIndex = 0;
            lblTituloAcerca.Text = "Acerca de";
            // 
            // lblNombreApp
            // 
            lblNombreApp.AutoSize = true;
            lblNombreApp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombreApp.ForeColor = Color.FromArgb(52, 152, 219);
            lblNombreApp.Location = new Point(37, 93);
            lblNombreApp.Name = "lblNombreApp";
            lblNombreApp.Size = new Size(226, 25);
            lblNombreApp.TabIndex = 1;
            lblNombreApp.Text = "Sistema de Gestión TIA1";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 9.75F);
            lblVersion.ForeColor = Color.FromArgb(44, 62, 80);
            lblVersion.Location = new Point(37, 133);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(93, 23);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Versión 1.0";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9.75F);
            lblAutor.ForeColor = Color.FromArgb(44, 62, 80);
            lblAutor.Location = new Point(37, 167);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(261, 23);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Desarrollado por: Jakeline Rios A.";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F);
            lblDescripcion.ForeColor = Color.FromArgb(127, 140, 141);
            lblDescripcion.Location = new Point(37, 220);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(557, 46);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Aplicación de escritorio desarrollada en C# con Windows Forms (.NET 9)\ncomo ejercicio académico de gestión con menús y ventanas MDI.";
            // 
            // frmAcercade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(lblTituloAcerca);
            Controls.Add(lblNombreApp);
            Controls.Add(lblVersion);
            Controls.Add(lblAutor);
            Controls.Add(lblDescripcion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAcercade";
            Text = "Acerca de";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAcerca;
        private Label lblNombreApp;
        private Label lblVersion;
        private Label lblAutor;
        private Label lblDescripcion;
    }
}
