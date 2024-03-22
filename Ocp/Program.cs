using Ocp.Vehicles;
using System;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2024, 2.0, 5, 4);
            }
            else
            {
                Motorcycle vehicle = new Motorcycle("Branco", 2024, 150);
            }

            Console.ReadLine();

        }
    }
}
