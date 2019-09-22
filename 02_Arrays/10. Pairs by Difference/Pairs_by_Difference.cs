using System;
class Pairs_by_Difference
{
    static void Main()
    {
        int var = 0, len = 0;
        string[] s1 = Console.ReadLine().Split(' ');
        int n = s1.Length, k= int.Parse(Console.ReadLine());
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s1[i]);    // перетворення символів у числа.
        }

        for (int i = 0; i < n; i++)
        {
            var = t[i];
            for (int j = i+1; j < n; j++)
            {
                if (var+k == t[j] || var - k == t[j])
                {
                    len++;
                }
            }
            
        }
        Console.WriteLine($"\n{len}\n");
    }
}
