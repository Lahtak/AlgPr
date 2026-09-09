using System;
class ex12
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число: ");
        int n = int.Parse(Console.ReadLine());
        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;
        int sum = a + b + c;
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}