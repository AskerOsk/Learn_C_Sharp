using System;

namespace Перегрузка_методов
{
    class Program
    {

        // Описание для методов.
        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму трех целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Возвращает сумму двух дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int res = Sum(2, 3);
            int res2 = Sum(5, 5, 7);
            double res3 = Sum(3.2, 1.4);

            Console.WriteLine("Первый результат: " + res + "\t Второй результат: " + res2 + "\t Третий результат: " + res3);
        }
    }
}
