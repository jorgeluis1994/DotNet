using Npgsql;
using System.Data;

namespace Prometeus.Config
{
    public class Conn
    {
        private readonly string _connectionString;

        public Conn(IConfiguration  configuration){
            _connectionString = configuration.GetConnectionString("DefaultConnection");

        }

    public DataTable ExecuteQuery(string query)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var cmd = new NpgsqlCommand(query, connection);
        using var reader = cmd.ExecuteReader();

        var dataTable = new DataTable();
        dataTable.Load(reader);

        return dataTable;
    }

    public void ExecuteNonQuery(string query)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var cmd = new NpgsqlCommand(query, connection);
        cmd.ExecuteNonQuery();
    }

        
    }
}