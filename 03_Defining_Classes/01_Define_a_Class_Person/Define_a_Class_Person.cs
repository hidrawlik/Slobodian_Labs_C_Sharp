using System;

namespace _01_Define_a_Class_Person
{
    class Person
    {
        int age;
        string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public void  GetInfo()
        {
            Console.WriteLine($"{Name}  {Age}");
        }
    }
    class Define_a_Class_Person
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Person[] person = new Person[n];

            for (int i = 0; i < n; i++)
            {
                person[i] = new Person();

                Console.Write($"\nName[{i}]: ");
                person[i].Name = Console.ReadLine();

                Console.Write($"Age[{i}]: ");
                person[i].Age = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                person[i].GetInfo();
            }
            Console.WriteLine();

        }
    }
}

