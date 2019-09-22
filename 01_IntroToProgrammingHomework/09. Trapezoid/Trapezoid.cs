using System;
class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Введiть значення a,b,h: ");
        float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine()), h = float.Parse(Console.ReadLine()), area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}
