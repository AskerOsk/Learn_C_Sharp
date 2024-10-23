using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<int, string> Student = new Dictionary<int, string>
            //{
            //    {20 , "Alice"},
            //    {800 , "Mark"},
            //    {4010 , "Gong"},

            //};
            //if (Student.TryGetValue(8100, out string studentName))
            //{
            //    Console.WriteLine($"Student name: {studentName}");
            //}
            //else
            //{
            //    Console.WriteLine($"Значение не найдено");

            //}
            //Console.ReadLine();

            string text = "hello world hello everyone";
            string[] words = text.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"Word: {kvp.Key}, Count: {kvp.Value}");
            }

        }

}
}
