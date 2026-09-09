using CapaNegocio;

namespace TIA1
{
    public partial class frmProductos : Form
    {
        private readonly BLLProducto _productoService = new();
        private int _selectedProductoId;
        private bool _editMode;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object? sender, EventArgs e)
        {
            LoadProductos();
            ClearControls();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!TryReadForm(out string nombre, out int cantidad, out decimal precio))
            {
                return;
            }

            try
            {
                if (_editMode)
                {
                    _productoService.Actualizar(_selectedProductoId, nombre, cantidad, precio);
                    MessageBox.Show("Producto actualizado correctamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _productoService.Crear(nombre, cantidad, precio);
                    MessageBox.Show("Producto guardado correctamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadProductos();
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
                MessageBox.Show("Debe seleccionar un producto en la tabla.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedProductoId = Convert.ToInt32(row.Cells["id"].Value);
            txtNombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            txtCantidad.Text = Convert.ToString(row.Cells["cantidad"].Value);
            txtPrecio.Text = Convert.ToString(row.Cells["precio"].Value);
            _editMode = true;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = GetSelectedRow();
            if (row is null)
            {
                MessageBox.Show("Debe seleccionar un producto en la tabla.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string nombre = Convert.ToString(row.Cells["nombre"].Value) ?? string.Empty;

            DialogResult confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar el producto '{nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _productoService.Eliminar(id);
                MessageBox.Show("Producto eliminado correctamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductos();
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

        private void LoadProductos()
        {
            try
            {
                dgvProductos.DataSource = _productoService.ObtenerTodos();
                ConfigureGridHeaders();
            }
            catch (Exception ex)
            {
                ShowError("No se pudieron cargar los productos desde SQL Server.\n\n" + ex.Message);
            }
        }

        private void ConfigureGridHeaders()
        {
            SetGridHeader("id", "ID");
            SetGridHeader("nombre", "Nombre");
            SetGridHeader("cantidad", "Cantidad");
            SetGridHeader("precio", "Precio");
        }

        private void SetGridHeader(string columnName, string headerText)
        {
            if (dgvProductos.Columns[columnName] is DataGridViewColumn column)
            {
                column.HeaderText = headerText;
            }
        }

        private bool TryReadForm(out string nombre, out int cantidad, out decimal precio)
        {
            nombre = txtNombre.Text.Trim();
            cantidad = 0;
            precio = 0;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            return true;
        }

        private DataGridViewRow? GetSelectedRow()
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvProductos.SelectedRows[0];
        }

        private void ClearControls()
        {
            txtNombre.Clear();
            txtCantidad.Text = "0";
            txtPrecio.Text = "0";
            _selectedProductoId = 0;
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
