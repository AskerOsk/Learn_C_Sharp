using System;

namespace УДАЛИТЬ_ЭЛЕМЕНТ_ИЗ_МАССИВА
{
    class Program
    {

        static void DeleteAt(ref int [] array, int index)  // Удаление элемента массива по указанному индексу.
        {
            int[] newArray = new int[array.Length -1];

            //for (int i = 0; i < index; i++)
            //{
            //    newArray[i] = array[i];
            //}
            //for (int i = index + 1; i < array.Length; i++)
            //{
            //    newArray[i - 1] = array[i];
            //}

            for (int i = 0, j = 0; i < array.Length; i++) // решение с Димашем
            {
                if (i == index) continue;
                newArray[j] = array[i];
                j++;
            }

            array = newArray;
        }
        
        static void DeleteFirs(ref int[] array) // Удаление первого элемента
        {
            DeleteAt(ref array, 0);
        }

        static void DeleteLast(ref int[] array) // Удаление последнего элемента
        {
            DeleteAt(ref array, array.Length - 1);
        }


        static void Main(string[] args)
        {
            int[] myArray ={ 10, 50, 401, 457, 594};

            DeleteAt(ref myArray, 2);
            DeleteFirs(ref myArray);
            DeleteLast(ref myArray);

        }
    }
}
