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

            Console.WriteLine("A soma dos números digitados de " + n1 + " mais " + n2 + " são: " + (n1 + n2));
            Console.WriteLine("A subtração dos números digitados de " + n1 + " menos " + n2 + " são: " + (n1 - n2));
            Console.WriteLine("A multiplicação dos números digitados de " + n1 + " vezes " + n2 + " são: " + (n1 * n2));
            Console.WriteLine("A divisão dos números digitados de " + n1 + " dividido " + n2 + " são: " + (n1 / n2));
            Console.WriteLine("O resto de uma divisão dos números digitados de " + n1 + " e " + n2 + " são: " + (n1 % n2));

        }
    }
}