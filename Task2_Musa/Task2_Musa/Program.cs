using System;

namespace Task2_Musa
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("bmw","i5","cyan",2139029129);
            Console.WriteLine(car1.Info());

            Bus bus1 = new Bus("Scania", "Feeeeee", "Magenta", 10, 30);

            Console.WriteLine(bus1.Info());
        }
    }
}
