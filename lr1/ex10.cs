using System;
class ex10
{
    static void Main()
    {
        Console.WriteLine("Введите a b c: ");
        string[] abc = Console.ReadLine().Split();
        int a = int.Parse(abc[0]);
        int b = int.Parse(abc[1]);
        int c = int.Parse(abc[2]);
        double avg = (a + b + c) / 3;
        Console.WriteLine($"Среднее: {avg:F2}");
    }
}
