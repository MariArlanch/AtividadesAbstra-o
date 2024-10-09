using ex_4;

Carro carro1 = new Carro("Toyota", "Corolla");
Carro carro2 = new Carro("Ford", "Mustang");
Carro carro3 = new Carro("Chevrolet", "Camaro");

carro1.Acelerar(50);
carro1.Desacelerar(20);
carro1.ExibirInfo();

carro2.Acelerar(100);
carro2.Desacelerar(40);
carro2.ExibirInfo();

carro3.Acelerar(70);
carro3.Desacelerar(30);
carro3.ExibirInfo();
