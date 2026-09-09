using System;
class pr1
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        string[] lwk = Console.ReadLine().Split();
        int L = int.Parse(lwk[0]);
        int W = int.Parse(lwk[1]);
        int K = int.Parse(lwk[2]);

        long S = 2 * N * (L + W + K) + W * N * (N - 1);
        Console.WriteLine(S);
    }
}