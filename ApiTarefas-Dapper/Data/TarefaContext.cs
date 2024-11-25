using System.Data;

namespace ApiTarefas_Dapper.Data;

public class TarefaContext
{
    public delegate Task<IDbConnection> GetConnection();
}
