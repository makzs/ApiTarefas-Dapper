using ApiTarefas_Dapper.Endpoints;
using ApiTarefas_Dapper.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddPersistence();
var app = builder.Build();

app.MapTarefasEndpoints();

app.Run();
