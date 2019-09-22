using System;
class Largest_Common_End
{
    static void Main()
    {
        string s0 = "hi php css hello its new for you hi and good hi php css lets try", s1 = "hi php css  jkgj ldf yjiyj jdfl php css lets try";
        string[] a0 = s0.Split(), a1 = s1.Split();
        int k, t = 0; ;

        Console.Write("Найбiльше спiльне речення ЗЛIВА на ПРАВО: ");

        if (a0.Length < a1.Length)
        {
            k = a0.Length;
        }
        else
        {
            k = a1.Length;
        }

        for (int i = 0; i < k; i++)
        {
            if (a0[i] == a1[i])
            {
                t++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(t);

        Console.Write("\nНайбiльше спiльне речення СПРАВА на НАЛIВО: ");

        t = 0;

        for (int i = 1; i <= k; i++)
        {
            if (a0[a0.Length-i] == a1[a1.Length - i])
            {
                t++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"{t}\n");

    }
}

