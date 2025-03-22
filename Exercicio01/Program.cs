using Exercicio01;

class Program
{
    public static void Main(string[] args)
    {
        Livro livro = new Livro();
        livro.setName("O Senhor dos Anéis");
        livro.setAuthor("J.R.R. Tolkien");

        Console.WriteLine("Nome do livro: " + livro.getName);
        Console.WriteLine("Autor do livro: " + livro.getAuthor);

    }
}