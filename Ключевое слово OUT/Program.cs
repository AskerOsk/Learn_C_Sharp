using System;

namespace Ключевое_слово_OUT
{
    class Program
    {

        static void Foo(ref int value)
        {
            Console.WriteLine(value);
        }

        static void Bar(out int value)      // при OUT, передаваемые данные обязаны быть изменены.
        {
            value = -55;
            Console.WriteLine(value);
           
        }

        static void Main(string[] args)
        {
            int a = 10;

            Foo(ref a);
            Bar(out a);

            Bar(out int c); // Можно инициировать переменную при вызове.


            // OUT Часто используюте для парса
            //string str = "Тект";
            string str = "45645";
            int.TryParse(str, out int result);

            Console.WriteLine(result);

        }
    }
}
