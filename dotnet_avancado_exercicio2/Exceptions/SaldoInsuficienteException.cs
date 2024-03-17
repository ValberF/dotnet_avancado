namespace DotnetAvancadoExercicio2.Exceptions;

public class SaldoInsuficienteException : Exception
{
    public double SaldoDisponivel { get; }

    public SaldoInsuficienteException(double saldoDisponivel) : base($"Saldo insuficiente. Saldo disponível: {saldoDisponivel}")
    {
        SaldoDisponivel = saldoDisponivel;
    }
}