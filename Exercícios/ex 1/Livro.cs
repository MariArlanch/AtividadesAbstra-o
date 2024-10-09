namespace ex_1
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoLancamento { get; set; }

        public Livro(string titulo, string autor, string editora, int anolancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoLancamento = anolancamento;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Editora: {Editora}");
            Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        }
    }

}
