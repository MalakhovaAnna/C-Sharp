using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int even_sum = 0;
            Random Numb = new Random();
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] = Numb.Next(0, 10));
                if (arr[i] % 2 == 0)
                    even_sum += arr[i];
            }
            Console.WriteLine("Сумма чётных чисел в массивe: {0}", even_sum);
            Console.ReadLine();
        }
    }
}
