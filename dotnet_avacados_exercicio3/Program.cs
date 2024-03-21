using DotnetAvancadoExercicio3.Classes;
using DotnetAvancadoExercicio3.Enums;

// QUESTÃO 1
Console.WriteLine("QUESTÃO 1:\n");
List<double> listaOriginal = new List<double> { 3, 7, 2, 4, 6 };
List<double> novaLista = listaOriginal.ConvertAll(element => element / 2);
novaLista.ForEach(element => Console.WriteLine(element));

// QUESTÃO 2
Console.WriteLine("\nQUESTÃO 2:");
List<ItemMercado> listaItens = new List<ItemMercado>
        {
            new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
            new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
            new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
            new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
            new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
            new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
            new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
            new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
            new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 }
        };

var itensHigieneOrdenados = listaItens.Where(item => item.Tipo == Tipo.Higiene)
                                      .OrderByDescending(item => item.Preco)
                                      .ToList();
Console.WriteLine("\nItens de Higiene ordenados por preço decrescente:");
foreach (var item in itensHigieneOrdenados)
{
    Console.WriteLine($"Nome: {item.Nome}, Preço: {item.Preco}");
}

var itensPrecoMaiorOuIgual5 = listaItens.Where(item => item.Preco >= 5.00)
                                          .OrderBy(item => item.Preco)
                                          .ToList();
Console.WriteLine("\nItens com preço maior ou igual a R$ 5,00 ordenados por preço crescente:");
foreach (var item in itensPrecoMaiorOuIgual5)
{
    Console.WriteLine($"Nome: {item.Nome}, Preço: {item.Preco}");
}

var itensComidaBebidaOrdenados = listaItens.Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida)
                                           .OrderBy(item => item.Nome)
                                           .ToList();
Console.WriteLine("\nItens de Comida ou Bebida ordenados por nome:");
foreach (var item in itensComidaBebidaOrdenados)
{
    Console.WriteLine($"Nome: {item.Nome}, Tipo: {item.Tipo}");
}

var quantidadePorTipo = listaItens.GroupBy(item => item.Tipo)
                                  .Select(g => new { Tipo = g.Key, Quantidade = g.Count() })
                                  .ToList();
Console.WriteLine("\nQuantidade de itens por tipo:");
foreach (var tipo in quantidadePorTipo)
{
    Console.WriteLine($"Tipo: {tipo.Tipo}, Quantidade: {tipo.Quantidade}");
}

var estatisticasPorTipo = listaItens.GroupBy(item => item.Tipo)
                                    .Select(g => new
                                    {
                                        Tipo = g.Key,
                                        PrecoMaximo = g.Max(item => item.Preco),
                                        PrecoMinimo = g.Min(item => item.Preco),
                                        PrecoMedio = g.Average(item => item.Preco).ToString("F2")
                                    })
                                    .ToList();
Console.WriteLine("\nEstatísticas de preço por tipo:");
foreach (var estatistica in estatisticasPorTipo)
{
    Console.WriteLine($"Tipo: {estatistica.Tipo}, Preço Máximo: {estatistica.PrecoMaximo}, Preço Mínimo: {estatistica.PrecoMinimo}, Preço Médio: {estatistica.PrecoMedio}");
}

// QUESTÃO 3
Worker worker1 = new Worker(1);
Worker worker2 = new Worker(2);

Thread thread1 = new Thread(new ThreadStart(worker1.Work));
Thread thread2 = new Thread(new ThreadStart(worker2.Work));

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

// QUESTÂO 4
Console.WriteLine($"\n");
Task task1 = DoWorkAsync("Tarefa 1");
Task task2 = DoWorkAsync("Tarefa 2");

await Task.WhenAll(task1, task2);

Console.WriteLine("Ambas as tarefas foram concluídas.");


static async Task DoWorkAsync(string taskName)
{
    Console.WriteLine($"Iniciando {taskName}");

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{taskName} em progresso... ({i}/5)");
        await Task.Delay(1000);

        Console.WriteLine($"{taskName} concluída.");
    }
}
