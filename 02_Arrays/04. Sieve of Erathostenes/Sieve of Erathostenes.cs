using System;
class Sieve_of_Erathostenes
{
    static void Main()
    {
       int n = int.Parse(Console.ReadLine());

        bool[] b = new bool[n];

        for (int i = 2; i < n; i++)
        {
            b[i] = true;
        }

        for (int j = 2; j < n; j++)
        {
            if (b[j])
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    b[p * j] = false;
                }
            }
        }

        for (int j = 2; j < n; j++)
        {
            if (b[j])
            {
                Console.Write($"{j} ");
            }
        }
        Console.WriteLine();
    }
}
