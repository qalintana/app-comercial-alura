using Ecomerce;
using Ecomerce.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var catalogo = new Catalogo();
var relatorio = new Relatorio(catalogo);

app.MapGet("/", relatorio.Imprimir);

app.Run();
