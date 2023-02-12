namespace Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int Odometro { get; set; }
        public int PercentualCombustivel { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuDeEstepe { get; set; }

        public Carro(string _marca, int _ano, string _modelo, int _velocidadeMaxima)
        {
            Marca = _marca;
            Ano = _ano;
            Modelo = _modelo;
            VelocidadeMaxima = _velocidadeMaxima;
            PneuDianteiroEsquerdo = new Pneu("Firestone", 16, 150);
            PneuDianteiroDireito = new Pneu("Firestone", 16, 150);
            PneuTraseiroEsquerdo = new Pneu("Firestone", 16, 150);
            PneuTraseiroDireito = new Pneu("Firestone", 16, 150);
            PneuDeEstepe = new Pneu("Pirelli", 16, 70);
            Odometro = 0;
            PercentualCombustivel = 0;
        }

        public void Acelerar()
        {

        }
        public void Ligar()
        {

        }
        public void Desligar()
        {

        }
        public void Frear()
        {

        }
        public void Parar()
        {

        }
        public void Abastecer()
        {

        }
    }
}
