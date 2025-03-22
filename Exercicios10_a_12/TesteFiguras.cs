using Exercicios10_a_12;

class TesteFiguras
{
    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo(3.0);
        Esfera esfera = new Esfera(5.0);

        Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Volume da Esfera: {esfera.CalcularVolume()}");


    }
}