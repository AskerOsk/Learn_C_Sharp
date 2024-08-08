using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Clear();

                double a, b;
                string res;

                try
                {
                    Console.WriteLine("Введить первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введить Второе число число");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("--- Не удалось преобразовать строку в число!!! ---");
                    Console.ReadLine();
                    continue;
                    
                }

                Console.WriteLine("Выберите операцию: '+', '-', '*', '/' ");

                ConsoleKey consoleKey = Console.ReadKey().Key;
                res = Console.ReadLine();

                string otvet = "Ответ ";

                switch (consoleKey)
                {
                    case ConsoleKey.Multiply:
                        {
                            Console.WriteLine(otvet + a * b);

                        }
                        break;
                    case ConsoleKey.Add:
                        {
                            Console.WriteLine(otvet + a + b);

                        }
                        break;

                    case ConsoleKey.Subtract:
                        {

                            Console.WriteLine(a - b);

                        }
                        break;

                    case ConsoleKey.Divide:
                        {
                            if (b == 0) Console.WriteLine("На ноль делить нельзя");
                            else Console.WriteLine(otvet + a / b);
                        }
                        break;

                    default:
                        Console.WriteLine("Не известное значение");
                        break;
                }
                Console.ReadLine(); // Сделано для того чтобы консоль не закрывалась после выполнения.
            }

           
        }
    }
}
