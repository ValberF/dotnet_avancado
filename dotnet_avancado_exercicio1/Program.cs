using DotnetAvancadoExercicio1.Classes;

var lamp1 = new Lamp();

Console.WriteLine($"Lâmpada {lamp1.PrintState()}");
lamp1.TurnOn();
Console.WriteLine($"Lâmpada {lamp1.PrintState()}");
lamp1.TurnOff();
Console.WriteLine($"Lâmpada {lamp1.PrintState()}");
lamp1.TurnOff();
Console.WriteLine($"Lâmpada {lamp1.PrintState()}");
lamp1.TurnOn();
Console.WriteLine($"Lâmpada {lamp1.PrintState()}");

var d1 = new Date(10, 03, 2000, 23, 30, 10);
d1.PrintDate(Date.FORMATO_12H);
d1.PrintDate(Date.FORMATO_24H);