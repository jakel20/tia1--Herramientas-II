using Microsoft.Data.SqlClient;

namespace CapaDatos;

/// <summary>
/// Centralizes SQL Server connection creation for the data access layer.
/// </summary>
public static class DALConexion
{
    private const string DefaultConnectionString =
        "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

    /// <summary>
    /// Allows the local machine connection to be overridden without recompiling.
    /// Example environment variable: TIA1_CONNECTION_STRING.
    /// </summary>
    public static string ConnectionString =>
        Environment.GetEnvironmentVariable("TIA1_CONNECTION_STRING") ?? DefaultConnectionString;

    public static SqlConnection CreateConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}
