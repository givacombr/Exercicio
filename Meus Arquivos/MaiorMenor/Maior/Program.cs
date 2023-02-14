internal class Program
{
    private static void Main(string[] args)
    {
        int n = 0, maior = 0;
        Console.WriteLine("Determine o maior valor:");
        Console.WriteLine("Informe o 1º valor: ");
        n = Convert.ToInt32(Console.ReadLine());
        maior = n;

        Console.WriteLine("Informe o 2º valor: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > maior)
        {
            maior = n;
        }

        Console.WriteLine("Informe o 3º valor: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > maior)
        {
            maior = n;
        }

        Console.WriteLine("Informe o 4º valor: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > maior)
        {
            maior = n;
        }

        Console.WriteLine("O maior valor informado é: " + maior);
        Console.ReadKey();
    }
}