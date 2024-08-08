using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сколько элементов в массиве?");

            int countArray = int.Parse(Console.ReadLine());
            int[] myArray = new int [countArray];

            for (int i = 0; i < countArray; i++)
            {
                Console.WriteLine("Введи " + i + " элемент для массива");

                int addArray = int.Parse(Console.ReadLine());
                myArray[i] = addArray;

            }

            Console.WriteLine("Массив содержит:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Минимальное число:");
            

            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {

                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }

            }

            Console.WriteLine("\nМинимальное число:" + minValue);

            Console.ReadLine();

        }
    }
}
