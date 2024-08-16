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

        //static void PrintArr(int[] myArr, int i = 0)
        //{
        //    if (i < myArr.Length)
        //    {
        //        Console.WriteLine(myArr[i]);
        //        PrintArr(myArr, i + 1);
        //    }
        //}

        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length) return 0;

            int res = Sum(myArray, i + 1);

            return myArray[i] + res;
        }

        static void Main(string[] args)
        {

            int[] myArray = { 45, 432, 67 };


            int res = Sum(myArray);

            Console.WriteLine(res);

            // PrintArr(myArray);
            // Foo(1);
        }
    }
}
