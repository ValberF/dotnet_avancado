namespace DotnetAvancadoExercicio1.Classes;
public class Lamp
{
    private string state;

    public Lamp () {
        this.state = "ligada";
    }

    public void TurnOn() {
        this.state = "ligada";
    }

    public void TurnOff() {
        this.state = "desligada";
    }

    public string PrintState() {
        return this.state;
    }
}
