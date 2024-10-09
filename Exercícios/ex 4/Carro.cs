namespace ex_4
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; private set; }

        public Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = 0;  
        }

        public void Acelerar(int valor)
        {
            Velocidade += valor;
            Console.WriteLine($"{Marca} {Modelo} acelerou para {Velocidade} km/h.");
        }

        public void Desacelerar(int valor)
        {
            Velocidade -= valor;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"{Marca} {Modelo} desacelerou para {Velocidade} km/h.");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Velocidade Atual: {Velocidade} km/h");
        }
    }
}
