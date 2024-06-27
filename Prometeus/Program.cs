using System.Text;
using Microsoft.IdentityModel.Tokens;
using Prometeus.Config;

var builder = WebApplication.CreateBuilder(args);

// Configurar servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configurar servicios
builder.Services.AddSingleton<Conn>();

// Configuración de JWT
var key = Encoding.ASCII.GetBytes("ortiz");


var app = builder.Build();

// Configurar middleware y endpoints
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // Habilitar controllers API

app.Run();