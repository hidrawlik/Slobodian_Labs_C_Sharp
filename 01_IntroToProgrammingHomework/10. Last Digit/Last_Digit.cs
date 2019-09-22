using System;
class Last_Digit
{
    static void Main()
    {
        Console.WriteLine("Введiть значення n: ");
        int n = int.Parse(Console.ReadLine()), lastDigit = n % 10;
        Console.WriteLine(lastDigit);
    }
}
