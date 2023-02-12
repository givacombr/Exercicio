namespace Praticando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Olá {name}! Seja bem vindo.");
            Console.Write("Digite o ano do seu nascimento: ");
            int year = int.Parse(Console.ReadLine());
            int age = 2023 - year;
            Console.Clear();
            Console.Write($"Você tem {age} ano(s).");

            // if (age >= 18) Console.WriteLine(" E é maior de idade.");
            if (age >= 18)
            {
                Console.WriteLine(" E é maior de idade.");
            }
            else
            {
                Console.WriteLine(" E é menor de idade");
            }
        }

    }
}