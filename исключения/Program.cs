using System;
using System.IO;

namespace Исключения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            try
            {
                order.ProcessOrder(200);  // Попробуем указать сумму, превышающую баланс
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

    public class Order
    {
        private int orderSum = 100;

        public void ProcessOrder(int sum)
        {
            if (sum > orderSum)
            {
                // Генерируем собственное исключение
                throw new InsufficientFundsException();
            }
            Console.WriteLine("Заказ обработан успешно.");
        }
    }

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Сумма заказа превышает доступный баланс.")
        {
            LogException(this);  // Логируем исключение при его создании
        }

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