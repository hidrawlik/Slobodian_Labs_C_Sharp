using System;
class Max_Sequence_of_Increasing_Elements
{
    static void Main()
    {
        int BestStart = 0, BestLen = 0, start = 0, len = 0;
        string[] s1 = Console.ReadLine().Split(' ');
        int n = s1.Length;
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s1[i]);    // перетворення символів у числа.
        }

        for (int i = 1; i < n; i++)
        {
            if (t[i] - t[i - 1] == 1)
            {
                start = i;
                len++;
            }
            else
            if (len != 0 && len > BestLen)
            {
                BestStart = start - len;
                BestLen = len;
            }

            if (t[i] - t[i - 1] != 1)
            {
                len = 0;
            }
        }
        if (len != 0 && len > BestLen)
        {
            BestStart = start - len;
            BestLen = len;
        }

        for (int i = BestStart; i <= BestStart + BestLen; i++)
        {
            Console.Write($"{t[i]} ");
        }
        Console.WriteLine("\n");
    }
}
