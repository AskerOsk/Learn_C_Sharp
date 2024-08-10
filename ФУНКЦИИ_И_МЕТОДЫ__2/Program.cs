using System;

namespace ФУНКЦИИ_И_МЕТОДЫ__2
{
    class Program
    {
        static int IndexOf (int [] array, int value)  /// Ищем нужные нам данные и возвращаем индекс
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return i;
            }

            Console.WriteLine("Элемент не найден! ");
            return -1;
        }

        static int [] GetRandomArray(uint lenght, int minValue, int maxValue)  // Рандомная генерация одиночного массива.
        {
            int[] myArray = new int[lenght];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main(string[] args)
        {

            int[] myArray = GetRandomArray(10, 100, 500);
            int result = IndexOf(myArray, 200);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
