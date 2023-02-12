namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, sm;
            Console.WriteLine("Digite o valor do seu salário: R$ ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de sua dívida: R$ ");
            x2 = Convert.ToInt32(Console.ReadLine());

            sm = x1 - x2;

            Console.WriteLine("Seu saldo é: R$ " + sm);
        }
    }
}