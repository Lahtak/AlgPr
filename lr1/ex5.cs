using System;
class ex5
{
    static void Main()
    {
        Console.WriteLine("Введите R h: ");
        string[] rh = Console.ReadLine().Split();
        double R = double.Parse(rh[0]);
        double h = double.Parse(rh[1]);

        double l = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(h, 2));
        double V = (1.0 / 3) * Math.PI * Math.Pow(R, 2) * h;
        double S = Math.PI * R * (R + l); 
        Console.WriteLine($"Объём: {V}");
        Console.WriteLine($"Площадь полной поверхности: {S}");
    }
}