namespace DotnetAvancadoExercicio1.Classes;
public class Date
{
    private readonly int day;
    private readonly int month;
    private readonly int year;
    private readonly int hour;
    private readonly int minute;
    private readonly int second;
    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;

    public Date (int day, int month, int year) {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public Date (int day, int month, int year, int hour, int minute, int second) : this(day, month, year) {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public int Day { get; private set; }
    public int Month { get; private set;}
    public int Year { get; private set;}
    public int Hour { get; private set;}
    public int Minute { get; private set;}
    public int Second { get; private set; }

    public void PrintDate(int typeDate) {
        if (typeDate != FORMATO_12H && typeDate != FORMATO_24H)
        {
            throw new ArgumentException("Formato de hora inválido. Use FORMATO_12H ou FORMATO_24H.");
        }

        if (this.hour != 0 || this.minute != 0 || this.second != 0)
        {
            if (typeDate == FORMATO_12H)
            {
                string amPm = this.hour < 12 ? "AM" : "PM";
                int hour12h = this.hour % 12 == 0 ? 12 : this.hour % 12;
                Console.WriteLine($"{this.day}/{this.month}/{this.year} {hour12h}:{this.minute}:{this.second} {amPm}");
            }
            else
            {
                Console.WriteLine($"{this.day}/{this.month}/{this.year} {this.hour}:{this.minute}:{this.second}");
            }
        }
    }
    
}
