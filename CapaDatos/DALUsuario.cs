using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos;

/// <summary>
/// Data access operations for the USUARIO table.
/// </summary>
public class DALUsuario
{
    public DataTable ReadAllUsuario()
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_SELECCIONAR_ALL_USUARIO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        using SqlDataAdapter adapter = new(command);

        DataTable table = new();
        adapter.Fill(table);
        return table;
    }

    public void CreateUsuario(string usuario, string contrasena, int intentos, decimal nivelSeg, DateTime fechaReg)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_INSERTAR_USUARIO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        AddUsuarioParameters(command, usuario, contrasena, intentos, nivelSeg, fechaReg);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void UpdateUsuario(int id, string usuario, string contrasena, int intentos, decimal nivelSeg, DateTime fechaReg)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ACTUALIZAR_USUARIO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        AddUsuarioParameters(command, usuario, contrasena, intentos, nivelSeg, fechaReg);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void DeleteUsuario(int id)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ELIMINAR_USUARIO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

        connection.Open();
        command.ExecuteNonQuery();
    }

    private static void AddUsuarioParameters(
        SqlCommand command,
        string usuario,
        string contrasena,
        int intentos,
        decimal nivelSeg,
        DateTime fechaReg)
    {
        command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
        command.Parameters.Add("@contrasena", SqlDbType.VarChar, 250).Value = contrasena;
        command.Parameters.Add("@intentos", SqlDbType.Int).Value = intentos;
        command.Parameters.Add("@nivelSeg", SqlDbType.Decimal).Value = nivelSeg;
        command.Parameters["@nivelSeg"].Precision = 18;
        command.Parameters["@nivelSeg"].Scale = 0;
        command.Parameters.Add("@fechaReg", SqlDbType.Date).Value = fechaReg.Date;
    }
}
