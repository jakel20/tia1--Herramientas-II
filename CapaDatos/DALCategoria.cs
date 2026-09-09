using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos;

/// <summary>
/// Data access operations for the CATEGORIA table.
/// </summary>
public class DALCategoria
{
    public DataTable ReadAllCategoria()
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_SELECCIONAR_ALL_CATEGORIA", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        using SqlDataAdapter adapter = new(command);

        DataTable table = new();
        adapter.Fill(table);
        return table;
    }

    public void CreateCategoria(string nombre, string descripcion)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_INSERTAR_CATEGORIA", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        AddCategoriaParameters(command, nombre, descripcion);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void UpdateCategoria(int id, string nombre, string descripcion)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ACTUALIZAR_CATEGORIA", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        AddCategoriaParameters(command, nombre, descripcion);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void DeleteCategoria(int id)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ELIMINAR_CATEGORIA", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

        connection.Open();
        command.ExecuteNonQuery();
    }

    private static void AddCategoriaParameters(SqlCommand command, string nombre, string descripcion)
    {
        command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre;
        command.Parameters.Add("@descripcion", SqlDbType.VarChar, 250).Value = descripcion;
    }
}
