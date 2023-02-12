namespace SomarNumeroseParando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, sm;
            string parar = "s";

            while (parar == "s")
            {
                Console.WriteLine("Informe quatro números");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());

                sm = (a + b + c + d);
                Console.WriteLine("A soma dos números informados foram: " + sm);

                Console.WriteLine("Deseja continuar ?");
                parar = Console.ReadLine();
            }
            Console.Clear();
        }
    }
}