using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle myCar = new Car();
            myCar.Start();
            Console.WriteLine($"Current speed: {myCar.GetSpeed()} km/h");
            myCar.Stop();
            Console.ReadLine();
        }
    }

    interface IVehicle
    {
        void Start();
        void Stop();
        int GetSpeed();
    }

    public class Car : IVehicle
    {
        private int speed = 60;
        public void Start()
        {
            Console.WriteLine("Авто заведено");
        }
        public void Stop()
        {
            Console.WriteLine("Авто заглушено");
        }
        public int GetSpeed()
        {
            return speed;
        }
    }
}
