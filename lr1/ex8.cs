using System;
class ex8
{
    static void Main()
    {
        Console.WriteLine("Введите a b: ");
        string[] ab = Console.ReadLine().Split();
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);
        int max = (a + b + Math.Abs(a - b)) / 2;
        Console.WriteLine($"Максимум: {max}");
    }
}
