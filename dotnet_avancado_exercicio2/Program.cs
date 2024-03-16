using DotnetAvancadoExercicio1.Classes;
using DotnetAvancadoExercicio1.Exceptions;
using DotnetAvancadoExercicio1.Structs;

// QUESTÃO 1
try
{
    ContaBancaria conta1 = new ContaBancaria(100);
    ContaBancaria conta2 = new ContaBancaria(50);

    conta1.Depositar(50);
    Console.WriteLine(conta1.Saldo);
    conta1.Transferir(30, conta2);

    conta1.Depositar(15);
    Console.WriteLine(conta2.Saldo);
    conta2.Sacar(100);
}
catch (ValorInvalidoException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Valor: {ex.Valor}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Saldo Disponível: {ex.SaldoDisponivel}");
}

// QUESTÃO 2
try
{
    Object o = null;
    Console.WriteLine(o.ToString());
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro: {e}");
}

// QUESTÃO 3
foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
{
    Console.WriteLine($"{(int)exercicio}: {exercicio}");
}

Console.Write("Digite o número correspondente ao exercício desejado (1, 2 ou 3): ");
try
{
    int opcao = int.Parse(Console.ReadLine());

    if (Enum.IsDefined(typeof(Exercicio), opcao))
    {
        Exercicio exercicioEscolhido = (Exercicio)opcao;
        Console.WriteLine($"Você escolheu o exercício: {exercicioEscolhido}");
    }
    else
    {
        Console.WriteLine("Opção inválida. Por favor, escolha 1, 2 ou 3.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
}

//QUESTÃO 4
ServicoFabrica<MeuServico> fabrica = new ServicoFabrica<MeuServico>();
MeuServico instancia = fabrica.NovaInstancia();
instancia.Executar();

//QUESTÃO 5
Triangulo<int> trianguloInt = new Triangulo<int>(
            new Ponto<int>(0, 0, 0),
            new Ponto<int>(1, 0, 0),
            new Ponto<int>(0, 1, 0)
        );

Triangulo<double> trianguloDouble = new Triangulo<double>(
    new Ponto<double>(0.0, 0.0, 0.0),
    new Ponto<double>(1.5, 0.0, 0.0),
    new Ponto<double>(0.0, 1.5, 0.0)
);


Triangulo<string> trianguloString = new Triangulo<string>(
    new Ponto<string>("A", "B", "C"),
    new Ponto<string>("D", "E", "F"),
    new Ponto<string>("G", "H", "I")
);

Triangulo<float> trianguloFloat = new Triangulo<float>(
    new Ponto<float>(0.0f, 0.0f, 0.0f),
    new Ponto<float>(1.1f, 0.0f, 0.0f),
    new Ponto<float>(0.0f, 1.1f, 0.0f)
);

Console.WriteLine("\nInteiros:");
ExibirTriangulo(trianguloInt);

Console.WriteLine("\nDoubles:");
ExibirTriangulo(trianguloDouble);

Console.WriteLine("\nStrings:");
ExibirTriangulo(trianguloString);

Console.WriteLine("\nFloats:");
ExibirTriangulo(trianguloFloat);

static void ExibirTriangulo<T>(Triangulo<T> triangulo)
{
    Console.WriteLine($"Ponto 1: ({triangulo.P1.X}, {triangulo.P1.Y}, {triangulo.P1.Z})");
    Console.WriteLine($"Ponto 2: ({triangulo.P2.X}, {triangulo.P2.Y}, {triangulo.P2.Z})");
    Console.WriteLine($"Ponto 3: ({triangulo.P3.X}, {triangulo.P3.Y}, {triangulo.P3.Z})");
}

enum Exercicio
{
    Academia = 1,
    Luta = 2,
    Corrida = 3
}