using CapaNegocio;

namespace TIA1
{
    public partial class frmCategorias : Form
    {
        private readonly BLLCategoria _categoriaService = new();
        private int _selectedCategoriaId;
        private bool _editMode;

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object? sender, EventArgs e)
        {
            LoadCategorias();
            ClearControls();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre de la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                if (_editMode)
                {
                    _categoriaService.Actualizar(_selectedCategoriaId, nombre, descripcion);
                    MessageBox.Show("Categoría actualizada correctamente.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _categoriaService.Crear(nombre, descripcion);
                    MessageBox.Show("Categoría guardada correctamente.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadCategorias();
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
                MessageBox.Show("Debe seleccionar una categoría en la tabla.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedCategoriaId = Convert.ToInt32(row.Cells["id"].Value);
            txtNombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            txtDescripcion.Text = Convert.ToString(row.Cells["descripcion"].Value);
            _editMode = true;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = GetSelectedRow();
            if (row is null)
            {
                MessageBox.Show("Debe seleccionar una categoría en la tabla.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string nombre = Convert.ToString(row.Cells["nombre"].Value) ?? string.Empty;

            DialogResult confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar la categoría '{nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _categoriaService.Eliminar(id);
                MessageBox.Show("Categoría eliminada correctamente.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategorias();
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

        private void LoadCategorias()
        {
            try
            {
                dgvCategorias.DataSource = _categoriaService.ObtenerTodas();
                ConfigureGridHeaders();
            }
            catch (Exception ex)
            {
                ShowError("No se pudieron cargar las categorías desde SQL Server.\n\n" + ex.Message);
            }
        }

        private void ConfigureGridHeaders()
        {
            SetGridHeader("id", "ID");
            SetGridHeader("nombre", "Nombre");
            SetGridHeader("descripcion", "Descripción");
        }

        private void SetGridHeader(string columnName, string headerText)
        {
            if (dgvCategorias.Columns[columnName] is DataGridViewColumn column)
            {
                column.HeaderText = headerText;
            }
        }

        private DataGridViewRow? GetSelectedRow()
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvCategorias.SelectedRows[0];
        }

        private void ClearControls()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            _selectedCategoriaId = 0;
            _editMode = false;
            btnGuardar.Text = "Guardar";
            txtNombre.Focus();
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
