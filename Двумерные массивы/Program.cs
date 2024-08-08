using System;

namespace Двумерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
                 // int[,] myArray = new int[3, 5] // разные способы создания
                 // int[,] myArray = new int[,]    // разные способы создания
                int[,] myArray = 
                {
                    { 45, 456, 4, 78, 47},
                    { 5, 6, 8, 781, 457},
                    {01, 56, 14, 88, 97}
                };

            // Console.WriteLine(myArray.Rank); // Проверить сколько измерений содержит массив.
            // Console.WriteLine(myArray.GetLength(0)); // 0,1,2 итд количество строк в измерении

            int height = myArray.GetLength(0); // Ряд
            int width = myArray.GetLength(1); // Колонка

            for (int y = 0; y < height; y++)  // Обработка всех данныех в массиве
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
