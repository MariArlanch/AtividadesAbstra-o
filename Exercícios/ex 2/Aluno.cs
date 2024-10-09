namespace ex_2
{
    internal class Aluno
    {
        public int RM { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }

        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"RM: {RM}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de Nascimento: {Nascimento.ToShortDateString()}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
