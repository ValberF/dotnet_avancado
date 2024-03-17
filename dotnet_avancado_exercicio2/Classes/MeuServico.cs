
using DotnetAvancadoExercicio2.Interfaces;

namespace DotnetAvancadoExercicio2.Classes;

public class MeuServico : IServico
{
    public void Executar()
    {
        Console.WriteLine("\nServiço executado!");
    }
}