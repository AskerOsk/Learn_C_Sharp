﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            for (int i = 0; i < height; i++)
            {

                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();

            }

            Console.WriteLine();


            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

        }
    }
}
