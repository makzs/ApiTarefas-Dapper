using System.Data.SqlClient;
using static ApiTarefas_Dapper.Data.TarefaContext;

namespace ApiTarefas_Dapper.Extensions;

public static class ServiceCollectionsExtentions
{
    public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddScoped<GetConnection>(sp => 
        async () =>
        {
            var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        });
        return builder;
    }
}
