using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор_1234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите 1 число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберете операцию: '+', '-', '*', '/'");
            action = Console.ReadLine();

            if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "*")
            {
                if (firstValue == 0)
                    Console.WriteLine(0);
                else
                    if (secondValue == 0)
                    Console.WriteLine(0);
                else
                Console.WriteLine(firstValue * secondValue);
            }
            else if (action == "/")
            {
                if (secondValue == 0)
                    Console.WriteLine(0);
                else
                    if (firstValue == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstValue / secondValue);
            }
            else
                Console.WriteLine("Такой операции не существует!");
            Console.ReadLine();
                


        }
    }
}
