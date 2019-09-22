using System;
class Calculate_N
{
    static void Main()
    {
        int t = 1;
        while (t != 0)
        {
            Console.WriteLine("Insert n:");

            int n = int.Parse(Console.ReadLine()), factorial = 1;

            while(n<0)
            {
                Console.WriteLine("\n Insert CORRECT number (n>=0):");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial: {factorial}");

            Console.WriteLine("\n");
            Console.Write("Again? (1 - yes || 0 - no): ");

            t = int.Parse(Console.ReadLine());

            if (t != 0)
                Console.Clear();
        }
    }
}

