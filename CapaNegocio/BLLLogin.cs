using CapaDatos;

namespace CapaNegocio;

/// <summary>
/// Business rules for application authentication.
/// </summary>
public class BLLLogin
{
    private readonly DALLogin _loginData = new();

    public bool ValidarUsuario(string usuario, string contrasena)
    {
        usuario = usuario.Trim();
        contrasena = contrasena.Trim();

        if (string.IsNullOrWhiteSpace(usuario))
        {
            throw new ArgumentException("Debe ingresar el usuario.", nameof(usuario));
        }

        if (string.IsNullOrWhiteSpace(contrasena))
        {
            throw new ArgumentException("Debe ingresar la contraseña.", nameof(contrasena));
        }

        return _loginData.ValidarUsuario(usuario, contrasena);
    }
}
