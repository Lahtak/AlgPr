using System;
class ex3
{
    static void Main()
    {
        Console.WriteLine("Введите R: ");
        double R = double.Parse(Console.ReadLine());
        double V = 4.0 / 3 * Math.PI * Math.Pow(R, 3);
        double S = Math.PI * Math.Pow(R, 2);
        double r = V / S;

        Console.WriteLine($"Объём шара: {V}");
        Console.WriteLine($"Площадь круга: {S}");
        Console.WriteLine($"Соотношение = {r}");
    }
}