﻿using System;

namespace Isp.Vehicles
{
    class Motorcycle
    {
        private string color;
        private int year;
        private double engine;
 

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            Console.WriteLine($"Criando moto ano {year}, {engine} cilindradas da cor{color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
