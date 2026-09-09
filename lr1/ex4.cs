using System;
class ex4
{
    static void Main()
    {
        Console.WriteLine("Введите a b c: ");
        string[] abc = Console.ReadLine().Split();
        double a = double.Parse(abc[0]);
        double b = double.Parse(abc[1]);
        double c = double.Parse(abc[2]);

        double ma = 0.5 * Math.Sqrt(2 * Math.Pow(b,2) + 2 * Math.Pow(c,2) - Math.Pow(a,2));
        double mb = 0.5 * Math.Sqrt(2 * Math.Pow(a,2) + 2 * Math.Pow(c,2) - Math.Pow(b,2));
        double mc = 0.5 * Math.Sqrt(2 * Math.Pow(a,2) + 2 * Math.Pow(b,2) - Math.Pow(c,2));
        Console.WriteLine($"Медиана a: {ma}");
        Console.WriteLine($"Медиана b: {mb}");
        Console.WriteLine($"Медиана c: {mc}");
    }
}