﻿using System;

namespace Isp.Vehicles
{
    class Car : IVehicle
    {

        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            Console.WriteLine($"Criando carro ano {year}, motor {engine} da cor{color}");
            StartVehicle();
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
        
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
