using Exercicio02_a_06;

class Program
{
    public static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso("Turnê da Ado", 250, 357);
        //ingresso.ExibirInformacoes();

        //Console.WriteLine("\n"); // Pulando linha

        ingresso.AlterarQuantidade(300);
        ingresso.AlterarPreco(650);
        
        //ingresso.ExibirInformacoes();

        Ingresso ingresso2 = new Ingresso("My Chemical Romance", 150, 529);
        //ingresso2.ExibirInformacoes();

        ingresso2.SetPreco = 300;
        ingresso2.SetNomeDoShow = "Turnê do My Chemical Romance";
        ingresso2.SetQuantidadeDisponivel = 100;
        //ingresso2.ExibirInformacoes();

        Ingresso ingresso3 = new Ingresso("Turnê da Lady Gaga", 1200, 15);
        ingresso3.ExibirInformacoes();
    }
}