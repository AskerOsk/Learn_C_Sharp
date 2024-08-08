using System;

namespace Трехмерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,,] myArray = new int [4, 7, 3];


            /*            
             *            // Пример как выглядит
             *            {
                            {
                                {32, 45, 6 },
                                {6, 1, 5 },
                            },
                            {
                                {12, 55, 16 },
                                {9, 5, 84}
                            },
                            {
                                {2, 74, 523 },
                                {4512, 45, 6354},
                            }
                        };
            */

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int x = 0; x < myArray.GetLength(2); x++)
                    {
                        myArray[i, j, x] = random.Next(100, 500);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int x = 0; x < myArray.GetLength(2); x++)
                    {
                        Console.Write(myArray[i, j, x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("__");

            }

        }
    }
}
