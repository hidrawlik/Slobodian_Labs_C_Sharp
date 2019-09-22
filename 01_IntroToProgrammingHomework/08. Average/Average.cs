using System;
class Average
{
    static void Main()
    {
        Console.WriteLine("Введiть значення a,b,c вiдповiдно: ");
        int a= int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine()); ;
        float average = (float)(a + b + c) / 3;
        Console.WriteLine(average);
    }
}
