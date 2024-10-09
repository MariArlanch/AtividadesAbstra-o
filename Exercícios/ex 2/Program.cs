using ex_2;

Aluno aluno1 = new Aluno(12345, "Ana Souza", new DateTime(2001, 6, 15), "ana.souza@email.com");
Aluno aluno2 = new Aluno(67890, "Carlos Silva", new DateTime(2000, 11, 30), "carlos.silva@email.com");
Aluno aluno3 = new Aluno(54321, "Beatriz Oliveira", new DateTime(2002, 1, 22), "beatriz.oliveira@email.com");

aluno1.ExibirInfo();
aluno2.ExibirInfo();
aluno3.ExibirInfo();

Console.ReadKey();