namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            
            Console.WriteLine("Digite um valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma dos números digitados são: " + (n1 + n2));
            Console.WriteLine("A subtração dos números digitados são: " + (n1 - n2));
            Console.WriteLine("A multiplicação dos números digitados são: " + (n1 * n2));
            Console.WriteLine("A divisão dos números digitados são: " + (n1 / n2));
            Console.WriteLine("O resto dos números digitados são: " + (n1 % n2));

        }
    }
}