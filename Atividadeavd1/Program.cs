using Atividadeavd1.Model;

Carro carro1 = new Carro(1, "Nissan", "Versa", 2016);
Cliente cliente1 = new Cliente(1, "Diego", 23, carro1);

Console.WriteLine("Pessoa: {0} \nCarro: {1} {2} ({3})", cliente1.nome, cliente1.carro.marca, cliente1.carro.modelo, cliente1.carro.anoFabricacao);


Carro carro2 = new Carro(1, "BMW", "320i", 2023);
Cliente cliente2 = new Cliente(2, "carlos", 23, carro2);

Console.WriteLine("Pessoa: {0} \nCarro: {1} {2} ({3})", cliente2.nome, cliente2.carro.marca, cliente2.carro.modelo, cliente2.carro.anoFabricacao);


Console.WriteLine("Total de carros criados: {0}", Carro.totalCarros);
