namespace DotnetAvancadoExercicio3.Classes;

public class Worker
{
    private int workerId;

    public Worker(int id)
    {
        workerId = id;
    }

    public void Work()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Trabalhador {workerId} está realizando o passo {i} do trabalho.");
            Thread.Sleep(1000);
        }
    }
}