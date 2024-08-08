using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четные_не_четные_кол_во_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадайте число");
            uint count = 0;
            uint userLimit = uint.Parse(Console.ReadLine());
            uint Chet = 0;
            uint NeChet = 0;

            while(count < userLimit)
            {
                count++;

                if (count % 2 == 0)
                {
                    Chet++;
                }
                else NeChet++;
            }

            Console.WriteLine("Заданное число " + userLimit + " Четных чисел " + Chet + " || Не четных чисел " + NeChet);
            

        }
    }
}
