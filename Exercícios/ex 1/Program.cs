using ex_1;

Livro livro1 = new Livro("1984", "George Orwell", "Companhia das Letras", 1949);
Livro livro2 = new Livro("Dom Quixote", "Miguel de Cervantes", "Editora 34", 1605);
Livro livro3 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "Martins Fontes", 1954);

livro1.ExibirInfo();
livro2.ExibirInfo();
livro3.ExibirInfo();

Console.ReadKey();