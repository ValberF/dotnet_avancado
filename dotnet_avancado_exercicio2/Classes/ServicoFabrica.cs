using DotnetAvancadoExercicio1.Interfaces;

namespace DotnetAvancadoExercicio1.Classes;

public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}