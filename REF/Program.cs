using System;

namespace REF
{
    class Program
    {
        static void Foo (ref int a)  
            /* с помощью указания ref, данные изменятся в том значении, которые было передано
             * без ref данные в переменной в Main не изменятся.
             С помощью ref мы можем значимый тип изменять как на ссылочный */
        {
            a = -10;
        }


        struct MySrtuct
        {
            public int a;
            public double b;
            public float c;
        }

        static void Bar(ref MySrtuct myStruct)
        /*
          Пример: 
        Если передает структура без ref: можно сраниить копирование файлов в другую папку.
        Если используем ref, то это можно сравнить с созданием ярлыка(ссылки на основную папку).

        Из-за этого объем файлов перегоняющих в разы уменьшается.
         */
        {
            myStruct.a = -5;
        }

        static void Main(string[] args)
        {
            MySrtuct mySrtuct = new MySrtuct();


            int a = 2;
            Foo(ref a); // Если использует ref в функции, то его необходимо указывать при использовании. 
        }



    }
}
