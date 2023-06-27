

namespace Ecomerce;

public class Relatorio
{
    private readonly Catalogo catalogo;


    public Relatorio(Catalogo catalogo)
    {
        this.catalogo = catalogo;
    }

    public async Task Imprimir(HttpContext context)
    {
        foreach (var livro in catalogo.GetLivros())
        {
            await context.Response.WriteAsync($"{livro.Nome} \n");
        }
    }
}