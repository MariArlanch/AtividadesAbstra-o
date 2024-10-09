namespace ex_3
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public double ValorEstoque()
        {
            return Preco * Estoque;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Estoque: {Estoque}");
            Console.WriteLine($"Valor em Estoque: {ValorEstoque():C}");
        }
    }
}
