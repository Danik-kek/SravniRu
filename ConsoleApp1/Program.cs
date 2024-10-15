
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два числа, разделённых пробелом:");
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');

            if (inputs.Length == 2 &&
                double.TryParse(inputs[0], out double number1) &&
                double.TryParse(inputs[1], out double number2))
            {
                Console.WriteLine($"Вы ввели числа: {number1} и {number2}");

                if (number1 > number2)
                {
                    Console.WriteLine($"{number1} > {number2}");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine($"{number1} < {number2}");
                }
                else
                {
                    Console.WriteLine($"{number1} = {number2}");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, убедитесь, что вы ввели два числа, разделённых пробелом.");
            }
        }
    }
}