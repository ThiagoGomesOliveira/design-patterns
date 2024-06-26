﻿using System;

namespace Ocp.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando  moto {color}, {year}, {engine} cilindradas.");
            StartVehicle();
        }
    }
}
