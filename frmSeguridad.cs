using CapaNegocio;

namespace TIA1
{
    public partial class frmSeguridad : Form
    {
        private readonly BLLUsuario _usuarioService = new();
        private int _selectedUserId;
        private bool _editMode;

        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void frmSeguridad_Load(object? sender, EventArgs e)
        {
            LoadUsuarios();
            ClearControls();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!TryReadForm(out string usuario, out string contrasena, out int intentos, out decimal nivelSeg))
            {
                return;
            }

            try
            {
                if (_editMode)
                {
                    _usuarioService.Actualizar(_selectedUserId, usuario, contrasena, intentos, nivelSeg, dtpFechaReg.Value);
                    MessageBox.Show("Usuario actualizado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _usuarioService.Crear(usuario, contrasena, intentos, nivelSeg, dtpFechaReg.Value);
                    MessageBox.Show("Usuario guardado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadUsuarios();
                ClearControls();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = GetSelectedRow();
            if (row is null)
            {
                MessageBox.Show("Debe seleccionar un usuario en la tabla.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
            txtUsuario.Text = Convert.ToString(row.Cells["usuario"].Value);
            txtContrasena.Text = Convert.ToString(row.Cells["contrasena"].Value);
            txtIntentos.Text = Convert.ToString(row.Cells["intentos"].Value);
            txtNivelSeg.Text = Convert.ToString(row.Cells["nivelSeg"].Value);

            if (DateTime.TryParse(Convert.ToString(row.Cells["fechaReg"].Value), out DateTime fechaReg))
            {
                dtpFechaReg.Value = fechaReg;
            }

            _editMode = true;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = GetSelectedRow();
            if (row is null)
            {
                MessageBox.Show("Debe seleccionar un usuario en la tabla.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string usuario = Convert.ToString(row.Cells["usuario"].Value) ?? string.Empty;

            DialogResult confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar el usuario '{usuario}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _usuarioService.Eliminar(id);
                MessageBox.Show("Usuario eliminado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsuarios();
                ClearControls();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            ClearControls();
        }

        private void LoadUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = _usuarioService.ObtenerTodos();
                ConfigureGridHeaders();
            }
            catch (Exception ex)
            {
                ShowError("No se pudieron cargar los usuarios desde SQL Server.\n\n" + ex.Message);
            }
        }

        private void ConfigureGridHeaders()
        {
            if (dgvUsuarios.Columns.Count == 0)
            {
                return;
            }

            SetGridHeader("id", "ID");
            SetGridHeader("usuario", "Usuario");
            SetGridHeader("contrasena", "Contraseña");
            SetGridHeader("intentos", "Intentos");
            SetGridHeader("nivelSeg", "Nivel");
            SetGridHeader("fechaReg", "Fecha registro");
        }

        private void SetGridHeader(string columnName, string headerText)
        {
            if (dgvUsuarios.Columns[columnName] is DataGridViewColumn column)
            {
                column.HeaderText = headerText;
            }
        }

        private bool TryReadForm(out string usuario, out string contrasena, out int intentos, out decimal nivelSeg)
        {
            usuario = txtUsuario.Text.Trim();
            contrasena = txtContrasena.Text.Trim();
            intentos = 0;
            nivelSeg = 0;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Debe ingresar el usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Debe ingresar la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            if (!int.TryParse(txtIntentos.Text.Trim(), out intentos) || intentos < 0)
            {
                MessageBox.Show("Los intentos deben ser un número entero mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntentos.Focus();
                return false;
            }

            if (!decimal.TryParse(txtNivelSeg.Text.Trim(), out nivelSeg) || nivelSeg < 0)
            {
                MessageBox.Show("El nivel de seguridad debe ser un número mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNivelSeg.Focus();
                return false;
            }

            return true;
        }

        private DataGridViewRow? GetSelectedRow()
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvUsuarios.SelectedRows[0];
        }

        private void ClearControls()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtIntentos.Text = "0";
            txtNivelSeg.Text = "1";
            dtpFechaReg.Value = DateTime.Today;
            _selectedUserId = 0;
            _editMode = false;
            btnGuardar.Text = "Guardar";
            txtUsuario.Focus();
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
