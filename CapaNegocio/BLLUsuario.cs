using System.Data;
using CapaDatos;

namespace CapaNegocio;

/// <summary>
/// Business rules for user management.
/// </summary>
public class BLLUsuario
{
    private readonly DALUsuario _usuarioData = new();

    public DataTable ObtenerTodos()
    {
        return _usuarioData.ReadAllUsuario();
    }

    public void Crear(string usuario, string contrasena, int intentos, decimal nivelSeg, DateTime fechaReg)
    {
        ValidarUsuario(usuario, contrasena, intentos, nivelSeg);
        _usuarioData.CreateUsuario(usuario.Trim(), contrasena.Trim(), intentos, nivelSeg, fechaReg);
    }

    public void Actualizar(int id, string usuario, string contrasena, int intentos, decimal nivelSeg, DateTime fechaReg)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar un usuario válido para actualizar.", nameof(id));
        }

        ValidarUsuario(usuario, contrasena, intentos, nivelSeg);
        _usuarioData.UpdateUsuario(id, usuario.Trim(), contrasena.Trim(), intentos, nivelSeg, fechaReg);
    }

    public void Eliminar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Debe seleccionar un usuario válido para eliminar.", nameof(id));
        }

        _usuarioData.DeleteUsuario(id);
    }

    private static void ValidarUsuario(string usuario, string contrasena, int intentos, decimal nivelSeg)
    {
        if (string.IsNullOrWhiteSpace(usuario))
        {
            throw new ArgumentException("Debe ingresar el usuario.", nameof(usuario));
        }

        if (string.IsNullOrWhiteSpace(contrasena))
        {
            throw new ArgumentException("Debe ingresar la contraseña.", nameof(contrasena));
        }

        if (intentos < 0)
        {
            throw new ArgumentException("Los intentos no pueden ser negativos.", nameof(intentos));
        }

        if (nivelSeg < 0)
        {
            throw new ArgumentException("El nivel de seguridad no puede ser negativo.", nameof(nivelSeg));
        }
    }
}
