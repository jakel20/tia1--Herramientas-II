using System.Data;
using CapaDatos;

namespace CapaNegocio;

/// <summary>
/// Business rules for product management.
/// </summary>
public class BLLProducto
{
    private readonly DALProducto _productoData = new();

    public DataTable ObtenerTodos()
    {
        return _productoData.ReadAllProducto();
    }

    public void Crear(string nombre, int cantidad, decimal precio)
    {
        ValidarProducto(nombre, cantidad, precio);
        _productoData.CreateProducto(nombre.Trim(), cantidad, precio);
    }

    public void Actualizar(int id, string nombre, int cantidad, decimal precio)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar un producto válido para actualizar.", nameof(id));
        }

        ValidarProducto(nombre, cantidad, precio);
        _productoData.UpdateProducto(id, nombre.Trim(), cantidad, precio);
    }

    public void Eliminar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar un producto válido para eliminar.", nameof(id));
        }

        _productoData.DeleteProducto(id);
    }

    private static void ValidarProducto(string nombre, int cantidad, decimal precio)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("Debe ingresar el nombre del producto.", nameof(nombre));
        }

        if (cantidad < 0)
        {
            throw new ArgumentException("La cantidad no puede ser negativa.", nameof(cantidad));
        }

        if (precio < 0)
        {
            throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));
        }
    }
}
