using DotnetAvancadoExercicio2.Interfaces;

namespace DotnetAvancadoExercicio2.Classes;

public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}