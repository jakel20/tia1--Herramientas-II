namespace TIA1
{
    partial class frmSeguridad
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblIntentos = new Label();
            lblNivelSeg = new Label();
            lblFechaReg = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtIntentos = new TextBox();
            txtNivelSeg = new TextBox();
            dtpFechaReg = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(24, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de usuarios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F);
            lblUsuario.Location = new Point(28, 86);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9.75F);
            lblContrasena.Location = new Point(28, 148);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(94, 23);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Segoe UI", 9.75F);
            lblIntentos.Location = new Point(28, 210);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(68, 23);
            lblIntentos.TabIndex = 3;
            lblIntentos.Text = "Intentos";
            // 
            // lblNivelSeg
            // 
            lblNivelSeg.AutoSize = true;
            lblNivelSeg.Font = new Font("Segoe UI", 9.75F);
            lblNivelSeg.Location = new Point(28, 272);
            lblNivelSeg.Name = "lblNivelSeg";
            lblNivelSeg.Size = new Size(144, 23);
            lblNivelSeg.TabIndex = 4;
            lblNivelSeg.Text = "Nivel de seguridad";
            // 
            // lblFechaReg
            // 
            lblFechaReg.AutoSize = true;
            lblFechaReg.Font = new Font("Segoe UI", 9.75F);
            lblFechaReg.Location = new Point(28, 334);
            lblFechaReg.Name = "lblFechaReg";
            lblFechaReg.Size = new Size(140, 23);
            lblFechaReg.TabIndex = 5;
            lblFechaReg.Text = "Fecha de registro";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 112);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(28, 174);
            txtContrasena.MaxLength = 250;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(300, 27);
            txtContrasena.TabIndex = 7;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtIntentos
            // 
            txtIntentos.Location = new Point(28, 236);
            txtIntentos.Name = "txtIntentos";
            txtIntentos.Size = new Size(300, 27);
            txtIntentos.TabIndex = 8;
            // 
            // txtNivelSeg
            // 
            txtNivelSeg.Location = new Point(28, 298);
            txtNivelSeg.Name = "txtNivelSeg";
            txtNivelSeg.Size = new Size(300, 27);
            txtNivelSeg.TabIndex = 9;
            // 
            // dtpFechaReg
            // 
            dtpFechaReg.Format = DateTimePickerFormat.Short;
            dtpFechaReg.Location = new Point(28, 360);
            dtpFechaReg.Name = "dtpFechaReg";
            dtpFechaReg.Size = new Size(300, 27);
            dtpFechaReg.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(28, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 36);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 204, 113);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(188, 420);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 36);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(28, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 36);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(127, 140, 141);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(188, 474);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 36);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(364, 86);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(704, 424);
            dgvUsuarios.TabIndex = 15;
            // 
            // frmSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 554);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaReg);
            Controls.Add(txtNivelSeg);
            Controls.Add(txtIntentos);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblFechaReg);
            Controls.Add(lblNivelSeg);
            Controls.Add(lblIntentos);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "frmSeguridad";
            Text = "Seguridad - Usuarios";
            Load += frmSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContrasena;
        private Label lblIntentos;
        private Label lblNivelSeg;
        private Label lblFechaReg;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtIntentos;
        private TextBox txtNivelSeg;
        private DateTimePicker dtpFechaReg;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvUsuarios;
    }
}
