using DotnetAvancadoExercicio1.Exceptions;

namespace DotnetAvancadoExercicio1.Classes;

public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public double Saldo { get; set; }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException(valor);
        }

        if (valor > Saldo)
        {
            throw new SaldoInsuficienteException(Saldo);
        }

        Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException(valor);
        }

        Saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria contaDestino)
    {
        Sacar(valor);
        contaDestino.Depositar(valor);
    }
}
