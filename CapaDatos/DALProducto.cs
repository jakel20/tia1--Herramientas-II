using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos;

/// <summary>
/// Data access operations for the PRODUCTO table.
/// </summary>
public class DALProducto
{
    public DataTable ReadAllProducto()
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_SELECCIONAR_ALL_PRODUCTO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        using SqlDataAdapter adapter = new(command);

        DataTable table = new();
        adapter.Fill(table);
        return table;
    }

    public void CreateProducto(string nombre, int cantidad, decimal precio)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_INSERTAR_PRODUCTO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        AddProductoParameters(command, nombre, cantidad, precio);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void UpdateProducto(int id, string nombre, int cantidad, decimal precio)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ACTUALIZAR_PRODUCTO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        AddProductoParameters(command, nombre, cantidad, precio);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void DeleteProducto(int id)
    {
        using SqlConnection connection = DALConexion.CreateConnection();
        using SqlCommand command = new("SP_ELIMINAR_PRODUCTO", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

        connection.Open();
        command.ExecuteNonQuery();
    }

    private static void AddProductoParameters(SqlCommand command, string nombre, int cantidad, decimal precio)
    {
        command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre;
        command.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
        command.Parameters.Add("@precio", SqlDbType.Decimal).Value = precio;
        command.Parameters["@precio"].Precision = 18;
        command.Parameters["@precio"].Scale = 2;
    }
}
