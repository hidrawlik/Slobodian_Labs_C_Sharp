using System;
class Equal_Sums
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int n = s.Length, LeftSum=0, RightSum=0;
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
        {
            t[i] = int.Parse(s[i]);    // перетворення символів у числа.
        }

        for (int i = 0; i < n; i++)
        {
            LeftSum = 0;
            RightSum = 0;
            for (int j = 0; j < i; j++)
            {
                LeftSum += t[j];
            }

            for (int j = n - 1; j > i; j--)
            {
                RightSum += t[j];
            }

            if (LeftSum == RightSum)
            {
                Console.WriteLine(i);
                break;
            }
        }

        if (LeftSum != RightSum)
        {
            Console.WriteLine("no");
        }
    }
}
