

namespace Ecomerce;

public class Relatorio
{
    private readonly ICatalogo catalogo;


    public Relatorio(ICatalogo catalogo)
    {
        this.catalogo = catalogo;
    }

    public async Task Imprimir(HttpContext context)
    {
        foreach (var livro in catalogo.GetLivros())
        {
            await context.Response.WriteAsync($"{livro.Nome} mais \n");
        }
    }
}