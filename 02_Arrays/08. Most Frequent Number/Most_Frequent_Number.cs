using System;
class Most_Frequent_Number
{
    static void Main()
    {
        int BestVar = 0, BestLen = 0, var = 0, len = 0;
        string[] s1 = Console.ReadLine().Split(' ');
        int n = s1.Length;
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s1[i]);    // перетворення символів у числа.
        }

        for (int i = 0; i < n; i++)
        {
            var = t[i];
            len = 0;
            for (int j = i; j < n; j++)
            {
                if(t[j]==var)
                {
                    len++;
                }
            }
            if(len>BestLen)
            {
                BestVar = var;
                BestLen = len;
            }
        }
        Console.WriteLine($"{BestVar}\n");
    }
}
