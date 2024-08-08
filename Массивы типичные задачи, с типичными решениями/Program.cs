using System;
using System.Collections.Generic;
using System.Linq; /// Используем при типизированной работе с массивами
using System.Text;
using System.Threading.Tasks;

namespace Массивы_типичные_задачи__с_типичными_решениями
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 111, 45, 546, 47, 4, 84, 10000, 4};
            int resMin = myArray.Min(); // Минимальное значение
            int res = myArray.Min(); // Минимальное значение
            int resMax = myArray.Sum(); // Сумма всех элементов
            int resSumArray = myArray.Where(i => i % 2 == 0).Sum(); // Сумма всех элементов c четным значением
            int resMinArray = myArray.Where(i => i % 2 != 0).Min(); // Самое маленькое не четное число

            int[] resDooble = myArray.Distinct().ToArray(); // Уникаотльные числа из массива
            int[] resPoradok = myArray.OrderBy(i => i).ToArray(); // Порядок по возврастанию, если нужно по убыванию то OrderByDescending

            Console.WriteLine(resMax + " " + resMin);
        }
    }
}
