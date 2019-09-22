using System;
class Rotate_and_Sum
{
    static void Main(string[] args)
    {
        string[] s1 = Console.ReadLine().Split(' ');
        int k = int.Parse(Console.ReadLine()), n = s1.Length;
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s1[i]);
        }

        int[,] a = new int[k,n];

        for (int i = 0; i < k; i++)
        {
            int q = t[n - 1];

            for (int j = n-1; j>0; j--)
            {
                t[j] = t[j - 1];
            }

            t[0] = q;

            for (int j=0;j<n;j++)
            {
                a[i, j] = t[j];
            }
        }

        for(int i=0;i<n;i++)
        {
            t[i] = 0;
        }

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < k; i++)
            {
                t[j] += a[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{t[i]} ");
        }
        Console.WriteLine("\n");
    }
}