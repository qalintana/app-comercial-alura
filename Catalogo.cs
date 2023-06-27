using Ecomerce.Models;

namespace Ecomerce;

public class Catalogo : ICatalogo
{
    public List<Livro> GetLivros()
    {
        var livros = new List<Livro>
                {
                    new Livro(1, "Quem mexeu", 100),
                    new Livro(2, "Quem Bateu", 300),
                    new Livro(3, "Ele Bateu", 300),
                };
        return livros;
    }
}