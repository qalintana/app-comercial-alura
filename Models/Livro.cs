namespace Ecomerce.Models;

public class Livro
{
    public Livro(int codigo, string nome, decimal preco)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
    }

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}