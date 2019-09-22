using System;
class Compare_Char_Arrays
{
    static void Main()
    {
        string s0 = Console.ReadLine(), s1 = Console.ReadLine();

        for (int i = 0; i < s0.Length; i++)
        {
            {

                if (s1[i] != s0[i])
                {
                    if (s1[i] < s0[i])
                    {
                        Console.WriteLine($"\n{s1}\n{s0}\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{s0}\n{s1}\n");
                        break;
                    }
                }
            }
            if (i + 1 == s1.Length)
            {
                Console.WriteLine($"\n{s1}\n{s0}\n");
                break;
            }

            if (i==s0.Length - 1 )
            {
                Console.WriteLine($"\n{s0}\n{s1}\n");
            }
        }
    }
}
