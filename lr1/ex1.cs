using System;
class ex1
{
    static void Main()
    {
        Console.WriteLine("Введите текущую секунду: ");
        int k = int.Parse(Console.ReadLine());
        int h = k / 3600;
        int m = (k % 3600) / 60;
        int s = k % 60;
        Console.WriteLine($"{h} ч, {m} мин, {s} с");
    }
}