using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            String str = Console.ReadLine();
            String str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    str2 += str[i];
                }

            }
            Console.WriteLine(str2);
        }
    }

}
