using Ecomerce;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddTransient<ICatalogo, Catalogo>();

var catalogo = app.Services.GetService<ICatalogo>();
var relatorio = new Relatorio(catalogo);



app.MapGet("/", relatorio.Imprimir);

app.Run();
