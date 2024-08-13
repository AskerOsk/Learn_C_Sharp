using System;

namespace Добавление_элемента_в_массив
{
    class Program
    {

        static void Insert(ref int[] array, int value, int index) // В данном функционале мы указаывем по какому индексу будет добавлен новое значение для массива.
        {
            int [] newArray = new int [array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length; i++)
            {
                newArray[i +1] = array[i];
            }

            array = newArray;

        }

        static void AddFirst(ref int[] array, int value) // Функционал по добавлению нового элемента в начало массива, переиспользуя Insert()
        {
            Insert(ref array, value, 0);
        }

        static void AddLast(ref int[] array, int value) // Функционал по добавлению нового элемента в конец массива, переиспользуя Insert(
        {
            Insert(ref array, value, array.Length);
        }

        static void Main(string[] args)
        {
            /* 
             Метод для добавления элемента массива:
            В начало,
            В конец,
            По указанному типу
             
             */

            int[] myArray = { 41, 54, 90, 10 };

            Insert(ref myArray, -95, 2);
            AddFirst(ref myArray, 40);
            AddLast(ref myArray, 8541);

        }
    }
}
