
using DotnetAvancadoExercicio1.Interfaces;

namespace DotnetAvancadoExercicio1.Classes;

public class MeuServico : IServico
{
    public void Executar()
    {
        Console.WriteLine("\nServiço executado!");
    }
}