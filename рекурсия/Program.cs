using System;

namespace рекурсия
{
    class Program
    {

        //static void Foo(int i)
        //{
        //    Console.WriteLine(i);

        //    if (i > 3) return;
        //    i++;

        //    Foo(i);

        //}

        static void PrintArr(int[] myArr, int i = 0)
        {
            if (i < myArr.Length)
            {
                Console.WriteLine(myArr[i]);
                PrintArr(myArr, i + 1);
            }
        }

        static void Main(string[] args)
        {

            int[] myArray = { 45, 432, 67 };
            PrintArr(myArray);
            // Foo(1);
        }
    }
}
