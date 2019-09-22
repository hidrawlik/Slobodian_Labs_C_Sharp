using System;
class Index_of_Letters
{
    static void Main()
    {

        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"{s[i]} -> {(int)s[i]-97}");
        }

    }
}
