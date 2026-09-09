using System.Data;
using CapaDatos;

namespace CapaNegocio;

/// <summary>
/// Business rules for category management.
/// </summary>
public class BLLCategoria
{
    private readonly DALCategoria _categoriaData = new();

    public DataTable ObtenerTodas()
    {
        return _categoriaData.ReadAllCategoria();
    }

    public void Crear(string nombre, string descripcion)
    {
        ValidarCategoria(nombre);
        _categoriaData.CreateCategoria(nombre.Trim(), descripcion.Trim());
    }

    public void Actualizar(int id, string nombre, string descripcion)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar una categoría válida para actualizar.", nameof(id));
        }

        ValidarCategoria(nombre);
        _categoriaData.UpdateCategoria(id, nombre.Trim(), descripcion.Trim());
    }

    public void Eliminar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar una categoría válida para eliminar.", nameof(id));
        }

        _categoriaData.DeleteCategoria(id);
    }

    private static void ValidarCategoria(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("Debe ingresar el nombre de la categoría.", nameof(nombre));
        }
    }
}
