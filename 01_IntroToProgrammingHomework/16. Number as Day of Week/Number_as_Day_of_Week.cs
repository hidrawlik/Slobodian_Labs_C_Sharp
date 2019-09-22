using System;
class Number_as_Day_of_Week
{
    static void Main()
    {
        int t = 1;
        while (t != 0)
        {
            Console.WriteLine("Insert n:");

            float n = float.Parse(Console.ReadLine());
            
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }

            Console.WriteLine("\n");
            Console.Write("Again? (1 - yes || 0 - no): ");

            t = int.Parse(Console.ReadLine());

            if (t != 0)
                Console.Clear();
        }
    }
}

