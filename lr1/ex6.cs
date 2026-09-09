using System;
class ex6
{
    static void Main()
    {
        Console.WriteLine("Введите R: ");
        double R = double.Parse(Console.ReadLine());

        double V = Math.Round(4.0 / 3 * Math.PI * Math.Pow(R, 3), 3);
        double S = Math.Round(4 * Math.PI * Math.Pow(R, 2), 3);
        Console.WriteLine($"Объём шара: {V}");
        Console.WriteLine($"Площадь поверхности: {S}");
    }
}