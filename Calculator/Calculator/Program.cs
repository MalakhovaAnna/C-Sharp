using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num1, num2;
                try
                {
                    Console.WriteLine("Введите число и нажмите Enter:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число и нажмите Enter:");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректные данные");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("\t+ - Сложение");
                Console.WriteLine("\t- - Вычитание");
                Console.WriteLine("\t* - Умножение");
                Console.WriteLine("\t/ - Деление");

                switch (Console.ReadLine())
                {
                    default:
                        Console.WriteLine("Некорректная операция!");
                        break;
                    case "+":
                        Console.WriteLine($"Результат: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Результат: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Результат: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine($"Результат: {num1} / {num2} = " + (num1 / num2));
                        }
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}