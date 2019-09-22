using System;
class Sign_of_product
{
    static void Main()
    {
        int t = 1;
        while ( t != 0)
        {
            Console.WriteLine("Insert a,b,c:");
            float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine()), c = float.Parse(Console.ReadLine());
            string product;
            if (a * b * c < 0)
            {
                product = "Negative";
                Console.WriteLine(product);
            }
            else
            {
                product = "Positive";
                Console.WriteLine(product);
            }
            Console.WriteLine("\n");
            Console.Write("Again? (1 - yes || 0 - no): ");
            t = int.Parse(Console.ReadLine());
            if (t != 0)
                Console.Clear();
        }   
    }
}

