using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_parity
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            a = int.Parse(Console.ReadLine());

           
            if(a % 2 == 0)
            {
                Console.WriteLine("Четное");
            } 
            else
            {
                Console.WriteLine("Не четное");

            }
            
        }
    }
}
