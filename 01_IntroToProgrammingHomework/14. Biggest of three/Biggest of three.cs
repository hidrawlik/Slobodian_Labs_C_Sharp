using System;
class Biggest_of_three
{
    static void Main()
    {
        Console.WriteLine("Insert a,b,c:");
        int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());

        if(a > b && a > c)
        {
            Console.WriteLine($"Max = {a}");
        }
        else
            if (b > a && b > c)
            {
                Console.WriteLine($"Max = {b}");
            }
            else
                if (c > a && c > b)
                {
                    Console.WriteLine($"Max = {c}");
                }
    }
}
