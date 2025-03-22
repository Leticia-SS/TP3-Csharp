using Exercicios07_a_09;

class TesteMatricula
{
    public static void Main(string[] args)
    {
        Matricula aluno = new Matricula("Lara Saraiva", "Engenharia de Software", 123456, "Ativa", "29/06/2023");
        aluno.ExibirInformacoes();

        Console.WriteLine("\n"); // Pulando linha
        aluno.Trancar();
        aluno.ExibirInformacoes();

        Console.WriteLine("\n"); // Pulando linha
        aluno.Reativar();
        aluno.ExibirInformacoes();

    }
}