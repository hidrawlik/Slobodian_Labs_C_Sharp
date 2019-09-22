using System;
class Fold_and_Sum
{
    static void Main()
    {
        Console.Write("4*");
        int k = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split(' ');
        int n = s1.Length;
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s1[i]);    // перетворення символів у числа.
        }

        int[,] a = new int[2, 2*k];

        for (int i = 0; i < k; i++)
        {
            int q = t[n - 1];

            for (int j = n - 1; j > 0; j--)
            {
                t[j] = t[j - 1];
            }

            t[0] = q;
        }

        int g = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2*k; j++)
            {
                a[i, j] = t[g];
                g++;
            }
        }

        for (int j = 0; j < 2*k; j++)
        {
            Console.Write($"{a[0, 2 * k - j - 1] +a[1,j]} ");
        }
        Console.WriteLine();
    }
}
