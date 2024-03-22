using System;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Vehicle vehicle = new Vehicle("Azul", 2024, 2.0, 5, 4);
                vehicle.Car();
            }
            else
            {
                Vehicle vehicle = new Vehicle("Branco", 2024, 150, 0, 0);
                vehicle.Motorcycle();
            }

            Console.ReadLine();

        }
    }
}
