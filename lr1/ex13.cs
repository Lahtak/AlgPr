using System;
class ex13
{
    static void Main()
    {
        Console.WriteLine("Введите a b: ");
        string[] ab = Console.ReadLine().Split();
        double a = double.Parse(ab[0]);
        double b = double.Parse(ab[1]);
        double c = Math.Round(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)), 5);
        Console.WriteLine($"Гипотенуза: {c}");
    }
}
