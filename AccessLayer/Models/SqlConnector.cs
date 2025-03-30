

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace RezervariAPI.AccessLayer.Models;

public class SqlConnector
{
    public SqlConnection DbConnection { get; private set; }


    public SqlConnector(IConfiguration configuration)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string connString = configuration.GetConnectionString("Default");
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        if (string.IsNullOrEmpty(connString))
        {
            throw new NullReferenceException("MenuMateDB connectionString is empty!");
        }

        DbConnection = new SqlConnection(connString);
    }
}