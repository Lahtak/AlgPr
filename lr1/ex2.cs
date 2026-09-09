using System;
class ex2
{
    static void Main()
    {
        Console.Write("Введите a b h: ");
        string[] abh = Console.ReadLine().Split();
        double a = double.Parse(abh[0]);
        double b = double.Parse(abh[1]);
        double h = double.Parse(abh[2]);

        double S = (a + b) / 2 * h;
        double V = (Math.PI * h / 3) * ((Math.Pow(a, 2)) + (Math.Pow(b, 2)) + a * b);
        Console.WriteLine($"Площадь трапеции: {S}");
        Console.WriteLine($"Объём усечённого конуса: {V}");
    }
}
