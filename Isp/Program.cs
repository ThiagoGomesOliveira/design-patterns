using Isp.Vehicles;
using System;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2023, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branco", 2023, 200);

            Console.ReadLine(); 

        }
    }
}
