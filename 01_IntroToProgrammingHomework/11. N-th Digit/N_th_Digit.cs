using System;
class N_th_Digit
{
    static void Main()
    {
        Console.WriteLine("Введiть значення number: ");
        int n, number = int.Parse(Console.ReadLine()), nDigit;

        Console.WriteLine("Введiть номер цифри (рахувати справа на лiво): ");
        n = int.Parse(Console.ReadLine());

        nDigit = (int) (number /  Math.Pow(10, n - 1)) % 10;

        Console.WriteLine(nDigit);
    }
}
