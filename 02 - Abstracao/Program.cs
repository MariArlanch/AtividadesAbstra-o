/*Instanciar a classe e os nomes*/
using _02___Abstracao;

Pet pet1 = new Pet("Gohan", "Pug", 12);

Console.WriteLine("O nome do seu cachorro é: " + pet1.Nome);
Console.WriteLine("A raça do seu cachorro é: " + pet1.Raca);
Console.WriteLine("A idade do seu cachorro é: " + pet1.Idade);
pet1.Alimentar();

Console.ReadKey();