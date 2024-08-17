using System;

namespace Арифметическое_переполнение
{
    class Program
    {
        static void Main(string[] args)
        {

            byte a = 1;

            byte b = 2;


            //checked
            //{
            //    a = (byte)a - b; // показыввает ошибку, так как в настроках включена проверка.  
            //}

            unchecked
            {
                a = (byte)((byte)a - b);  // Убрана проверка на переполнение
            }

            Console.WriteLine(a);
        }
    }
}
