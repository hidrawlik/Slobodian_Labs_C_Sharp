using System;
class Pure_Divisor
{
    static void Main()
    {
        int t = 1;
        while (t != 0)
        {
            Console.WriteLine("Insert n:");
            int n = int.Parse(Console.ReadLine());
            bool result;

            if ((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0))
            {
                result = true;
            }
            else
                result = false;
            Console.WriteLine(result);
            Console.WriteLine("\n");
            Console.Write("Again? (1 - yes || 0 - no): ");
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }
    }
}
