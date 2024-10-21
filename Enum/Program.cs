using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum TaskPriority
    {
        Low,
        Medium,
        High,
        Critical
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();

            // Пример вызова метода с разными уровнями приоритета
           task.TaskPri(TaskPriority.Low);
            task.TaskPri(TaskPriority.Medium);
            task.TaskPri(TaskPriority.High);
            task.TaskPri(TaskPriority.Critical);
        }
    }
    class Task
    {
        public void TaskPri(TaskPriority priority)
        {
            if (priority == TaskPriority.Low) {

                Console.WriteLine("Низкий приоритет");
            }
            if (priority == TaskPriority.Medium)
            {

                Console.WriteLine("Средний приоритет");
            }
            if (priority == TaskPriority.High)
            {

                Console.WriteLine("Высокий приоритет");
            }
            if (priority == TaskPriority.Critical)
            {

                Console.WriteLine("Критический приоритет");
            }

            Console.ReadLine();
        }
    }
   
}

