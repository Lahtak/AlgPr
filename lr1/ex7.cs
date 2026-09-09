using System;
class ex7
{
    static void Main()
    {
        Console.WriteLine("Введите x1 y1 x2 y2: ");
        string[] xy = Console.ReadLine().Split();
        double x1 = double.Parse(xy[0]);
        double y1 = double.Parse(xy[1]);
        double x2 = double.Parse(xy[2]);
        double y2 = double.Parse(xy[3]);

        double d = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
        Console.WriteLine($"Расстояние: {d}");
    }
}
