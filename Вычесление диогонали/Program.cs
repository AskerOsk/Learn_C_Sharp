using System;

namespace Вычесление_диогонали
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {
                    1, 2, 3, 4, 5
                },
                {
                    6, 7, 8, 9, 10
                },
                {
                    11, 12, 13, 14, 15
                },
                {
                    16, 17, 18, 19, 20
                },
                {
                    21, 22, 23, 24, 25
                },
            };

            int [,] res = new int[5,5];
            int resSum= 0;
            int arrLeng = 4;
            int last = 0;
            int right = 0;


            for (int i = 0; i < arrLeng; i++)
            {
                for (int j = i + 1; j < arrLeng - i; j++)
                {
                    resSum += array[i, j];
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

           // Console.WriteLine(resSum);

            for (int i = arrLeng; i > 0; i--)
            {
                for (int j = last + 1; j < arrLeng - last; j++)
                {
                    resSum += array[i, j];
                    Console.Write(array[i, j] + "\t");
                }
                last++;
                Console.WriteLine();
            }
            // Console.WriteLine(resSum);

            for (int i = 1; i < arrLeng; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    right++;
                    if (right <= arrLeng)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();


            int left = 1;

            for (int i = 1; i < arrLeng; i++)
            {

                for (int j = arrLeng; j > i && i == left;  j--)
                {
                    left++;
                    Console.Write(array[i, j] + "\t");

                    if (i == 2)
                    {
                        Console.Write(array[i, j - 1] + "\t");
                    }

                }

           Console.WriteLine();
            }

           // Console.WriteLine(resSum);

        }
    }
}





