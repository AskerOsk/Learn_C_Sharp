using System;

namespace Изменение_размера_массива
{
    class Program
    {

        static void Resize(ref int[] array, int newSize)  // Можно использовать дженерики <T>, для принятия любых типо данных - нужно изучить.
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        static void Main(string[] args)
        {

            int[] myArray = { 4, 65, 7 };
            Resize(ref myArray, 10);

          //  Array.Resize(ref myArray, 5);  // Уже есть готовый функционал для изменения размера массива.

        }
    }
}
