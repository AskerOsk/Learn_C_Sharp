using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конверт_валют
{
    class Program
    {
        static void Main(string[] args)
        {

            double dollToKZT = 475.45;
            double dollToRUB = 85.78;
            double USD;

            USD = double.Parse(Console.ReadLine());
            Console.WriteLine(USD + " USD в KZT " + USD * dollToKZT);
            Console.WriteLine(USD + " USD в KZT " + USD * dollToRUB);

        }
    }
}
