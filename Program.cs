using Microsoft.EntityFrameworkCore;
using MeuServidorCRUD.Data;
using Microsoft.OpenApi.Models;
using MeuServidorCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDatabase"));

// Adiciona controllers ao serviço
builder.Services.AddControllers();

// Adiciona Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MeuServidorCRUD", Version = "v1" });
});

// Configuração do Kestrel para usar HTTP/2
// builder.WebHost.ConfigureKestrel(serverOptions =>
// {
//     serverOptions.ConfigureEndpointDefaults(listenOptions =>
//     {
//         // Forçando o uso de HTTP/2
//         listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
//     });
// });

var app = builder.Build();

// Desabilita o redirecionamento HTTPS para evitar o problema de não encontrar a porta HTTPS
//app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MeuServidorCRUD v1"));

app.UseAuthorization();

app.MapControllers();

app.Run();
