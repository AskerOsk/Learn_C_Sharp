using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 13, 50, 546, 87465, 00147, 87410 };
            num.RemoveAll(x => x % 2 != 0);

            foreach (int x in num) {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
