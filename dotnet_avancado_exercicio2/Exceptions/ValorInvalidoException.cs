namespace DotnetAvancadoExercicio2.Exceptions;

public class ValorInvalidoException : Exception
{
    public double Valor { get; }
    
    public ValorInvalidoException(double valor) : base($"O valor {valor} é inválido.")
    {
        Valor = valor;
    }
}