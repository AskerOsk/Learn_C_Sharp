using System;

namespace ФУНКЦИИ_И_МЕТОДЫ
{
    class Program
    {

        static void Printline(string symbol, uint symbolCount)   // Если использовать char меняем тип.
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();   // Если будем использовать char, то меняем ввод на -- char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("Введите количество символов: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            Printline(symbol, symbolCount);
        }
    }
}
