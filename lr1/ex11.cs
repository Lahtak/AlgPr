using System;
class ex11
{
    static void Main()
    {
        Console.WriteLine("Введите a b c: ");
        string[] abc = Console.ReadLine().Split();
        double a = double.Parse(abc[0]);
        double b = double.Parse(abc[1]);
        double c = double.Parse(abc[2]);
        double d = Math.Round((a + b + c) * 0.13, 1);
        Console.WriteLine($"Общая скидка: {d}");
    }
}
