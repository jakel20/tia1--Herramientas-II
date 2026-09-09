using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos;

/// <summary>
/// Data access operations required by the login screen.
/// </summary>
public class DALLogin
{
    public bool ValidarUsuario(string usuario, string contrasena)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_VALIDAR_USUARIO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
        command.Parameters.Add("@contrasena", SqlDbType.VarChar, 250).Value = contrasena;

        connection.Open();
        object? result = command.ExecuteScalar();
        return Convert.ToInt32(result) > 0;
    }
}
