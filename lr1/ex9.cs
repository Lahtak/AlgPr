using System;
class ex9
{
    static void Main()
    {
        Console.WriteLine("Введите a b: ");
        string[] ab = Console.ReadLine().Split();
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"{a} {b}");
    }
}
