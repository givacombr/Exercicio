namespace Models
{
    public class Pneu
    {
        /// <summary>
        /// Criação dos Atributos (PROP)
        /// </summary>
        public string Marca { get; set; }
        public int Aro { get; set; }
        public string Cor { get; set; }
        public bool Furado { get; set; }
        public bool Estourado { get; set; }
        public int PercentualBorracha { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }


        /// <summary>
        /// Criaçao dos construtores (CTOR)
        /// </summary>
        public Pneu(string _marca, int _aro, int _velocidadeMaxima, string _cor = "Preto")
        {
            Marca = _marca;
            Aro = _aro;
            Cor = _cor;
            VelocidadeMaxima = _velocidadeMaxima;
            Furado = false;
            Estourado = false;
            PercentualBorracha = 100;
            VelocidadeAtual = 0;
        }



        /// <summary>
        /// Criação dos métodos (digitados)
        /// </summary>
        /// <param name="_impulso"></param>
        public void Girar(int _impulso)
        {
            if (Estourado == true)
            {
                Console.WriteLine("O pneu está estourado.");
                return;
            }

            VelocidadeAtual = VelocidadeAtual + _impulso;
            PercentualBorracha = PercentualBorracha - 3;
            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <= 30)
            {
                Estourar();
            }
        }
        public void Parar()
        {
            VelocidadeAtual = 0;
        }
        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (PercentualBorracha < 0)
            {
                PercentualBorracha = 0;
            }

            if (PercentualBorracha <= 30)
            {
                Estourar();
            }
        }
        public void Estourar()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }
        public void Furar()
        {
            Furado = true;
        }
        public void Remendar()
        {
            Furado = false;
        }
        public  void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Velocidade Maxima: " + VelocidadeMaxima);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Percentual Borracha: " + PercentualBorracha);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
        }

    }
}