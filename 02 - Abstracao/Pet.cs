namespace _02___Abstracao
{
    /*Classe representa algo do mundo real*/
    public class Pet
    {
        /*Atributos/propriedades*/
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set;}

        /*É necessário um método construtor para acessar as propriedades e manipular elas*/
        public Pet(string nome, string raca, int idade)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
        }

        //Metodo para alimentar
        public void Alimentar()
        {

        }
    }
}
