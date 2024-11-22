using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o CORS para permitir requisições de qualquer origem (ajuste conforme necessário)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()  // Permite qualquer origem
                          .AllowAnyMethod()  // Permite qualquer método HTTP (GET, POST, etc.)
                          .AllowAnyHeader());  // Permite qualquer cabeçalho
});

// Adiciona os serviços necessários para controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Se estiver em ambiente de desenvolvimento, habilita o Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Aplica o CORS antes de qualquer outra configuração de middleware
app.UseCors("AllowAll");

// Configuração de redirecionamento para HTTPS (se necessário)
app.UseHttpsRedirection();

// Habilita o middleware de autorização (se necessário)
app.UseAuthorization();

// Mapear as controllers
app.MapControllers();

// Inicia a aplicação
app.Run();
