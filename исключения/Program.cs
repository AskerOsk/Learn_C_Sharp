using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace исключения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.ProcessOrder(100);

        }

    }
    public class Order
    {

        public void ProcessOrder(int sum)
        {
            int orderSum = 100;
            if (sum > orderSum)
            {
                throw new InsufficientFundsException();
            }
        }

        class InsufficientFundsException : Exception
        {

            public InsufficientFundsException() : base("Сумма заказа превышает доступный") { }

            private void LogException(Exception ex)
            {
                string logFilePath = "error_log.txt";
                string logMessage = $"{DateTime.Now}: {ex.GetType().Name} - {ex.Message}\n{ex.StackTrace}\n";

                try
                {
                    File.AppendAllText(logFilePath, logMessage);
                    Console.WriteLine("Исключение залогировано в error_log.txt");
                }
                catch (Exception logEx)
                {
                    Console.WriteLine($"Ошибка логирования: {logEx.Message}");
                }
            }
        }
    }
}
