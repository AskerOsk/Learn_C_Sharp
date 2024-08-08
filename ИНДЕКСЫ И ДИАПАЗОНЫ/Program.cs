using System;

namespace ИНДЕКСЫ_И_ДИАПАЗОНЫ
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 111, 45, 546, 47, 4, 84, 10000, 4 };

            Console.WriteLine(myArray[^1]); // Последний пунт массива

            // int[] myArray2 = myArray[1..4]; // Диапозон с .. до 4
            // int[] myArray2 = myArray[4..];  // Диапозон с .. доконца
            // int[] myArray2 = myArray[..4];  //  Диапозон от начала  до 4
            // int[] myArray2 = myArray[^4..^1];  //  Диапозон от 4 с конца  до 1 конца


        }
    }
}
