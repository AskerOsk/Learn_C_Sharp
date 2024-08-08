using System;

namespace Двумерные_массивы_заполнение_с_клавы_и_случайными_числами
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 5];

            Random random = new Random();

                int height = myArray.GetLength(0); // Ряд
                int width = myArray.GetLength(1); // Колонка

            for (int i = 0; i < height; i++)  // Рандомно заполнить массив. Разные циклы, из-за зон отвесвенности
            {
                for (int j = 0; j < width; j++)
                {

                    myArray[i, j] = random.Next(100, 200);  // random.Next(); если не заполнен min/max то будут любые числа

                }
            }

                    for (int y = 0; y < height; y++)  // Обработка всех данныех в массиве
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(myArray[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
        }
    }
}
