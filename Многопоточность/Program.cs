using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{

    // ---------------------------------------------------------------------------------------//
    //static async Task Main(string[] args)
    //{
    //    List<Task> task = new List<Task>
    //    {
    //        Task.Run(()=> DoWork("Задача 1")),
    //        Task.Run(()=> DoWork("Задача 2")),
    //        Task.Run(()=> DoWork("Задача 3"))
    //    };

    //    await Task.WhenAll(task);
    //    Console.WriteLine("Все задачи завершены");

    //    Console.ReadLine();
    //}

    //static void DoWork(string taskName)
    //{
    //    Console.WriteLine($"{taskName} начата.");
    //    Task.Delay(1000).Wait();
    //    Console.WriteLine($"{taskName} завершена.");
    //}
    // -------------------------------------------------------------------------------------- //

    //static async Task Main(string[] args)
    //{
    //    Task<int> task = Task.Run(() => Calculate(10));
    //    int res = await task;

    //    Console.WriteLine($"Результат: {res}");
    //    Console.ReadLine();

    //}

    //static int Calculate(int n)
    //{
    //    int result = 0;
    //    for (int i = 0; i < n; i++)
    //    {
    //        result++;
    //        Task.Delay(100).Wait();
    //    }
    //    return result;
    //}
    // -------------------------------------------------------------------------------------- //
}