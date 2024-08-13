using System;

namespace Ключевое_слово_IN
{
    class Program
    {

        static void Foo(in int value) // in только для чтения. Используются для увелечение скорости.
        {
            
        }
        static void Main(string[] args)
        {
            int a = 5;
            Foo(a); // Можно без in
        }
    }
}
